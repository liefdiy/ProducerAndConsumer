using System;
using System.Collections.Generic;
using System.Threading;

namespace ProducerAndConsumer
{
    public class Producer<T>
    {
        private int _productId = 1;
        private bool _isStop = true;
        private int _count = 0;

        private readonly Repository<T> _repository;
        private List<Thread> _threads = null;

        public Producer(Repository<T> repository, int count)
        {
            _repository = repository;
            _count = count;
            _threads = new List<Thread>();
        }

        public void Produce()
        {
            _isStop = false;
            for (int i = 0; i < _count; i++)
            {
                Thread th = new Thread(Run);
                th.IsBackground = true;
                th.Name = "Producer" + i;
                th.Start(th);
                _threads.Add(th);
            }
        }

        public void Stop()
        {
            _isStop = true;
            //foreach (var thread in _threads)
            //{
            //    thread.Interrupt();
            //}
            //_threads.Clear();
            //_repository.Clear();
        }

        private void Run(object token)
        {
            try
            {
                Thread th = token as Thread;
                while (!_isStop)
                {
                    Interlocked.Increment(ref _productId);
                    string product = string.Format("[{1}] create {0} ", _productId, th.Name);
                    _repository.Add((T)(object)product); //互斥访问缓冲区
                }
            }
            catch (Exception ex)
            {
                //Maybe interupt
                Console.WriteLine("D0001\r\n" + ex);
            }
        }
    }

    public delegate void OnRepositoryChangedHandler(int count);

    public class Repository<T>
    {
        private event OnRepositoryChangedHandler _OnRepositoryChanged;

        public event OnRepositoryChangedHandler OnRepositoryChanged
        {
            add { _OnRepositoryChanged += value; }
            remove { _OnRepositoryChanged -= value; }
        }

        public Queue<T> Products { get; private set; }

        private Semaphore empty;
        private Semaphore full;

        public Repository(int capacity)
        {
            Products = new Queue<T>(capacity);

            //有名字的构造函数是系统信号量，不指定名字的是局部信号量
            //http://msdn.microsoft.com/zh-cn/library/system.threading.semaphore(v=vs.80).aspx

            //string s_empty = Guid.NewGuid().ToString() + "-empty";
            //string s_full = Guid.NewGuid().ToString() + "-full";

            //empty = new Semaphore(capacity, capacity, s_empty);
            //full = new Semaphore(0, capacity, s_full);

            empty = new Semaphore(capacity, capacity);
            full = new Semaphore(0, capacity);
        }

        public void Add(T product)
        {
            empty.WaitOne();

            lock (this)
            {
                Products.Enqueue(product);

                Console.WriteLine(product);

                if (_OnRepositoryChanged != null)
                {
                    _OnRepositoryChanged(Products.Count);
                }
            }

            full.Release();
        }

        public T Get()
        {
            full.WaitOne();

            T obj;
            lock (this)
            {
                obj = Products.Dequeue();

                if (_OnRepositoryChanged != null)
                {
                    _OnRepositoryChanged(Products.Count);
                }
            }
            empty.Release();
            return obj;
        }

        public void Clear()
        {
            try
            {
                empty.Close();
                full.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("D0003\r\n" + ex);
            }
        }
    }
}