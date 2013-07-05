using System;
using System.Collections.Generic;
using System.Threading;

namespace ProducerAndConsumer
{
    public class Consumer<T>
    {
        private int _consumeId = 1;
        private bool _isStop = true;
        private int _count = 0;

        private readonly Repository<T> _repository;
        private List<Thread> _threads = null;

        public Consumer(Repository<T> repository, int count)
        {
            _repository = repository;
            _count = count;
            _threads = new List<Thread>();
        }

        public void Consume()
        {
            _isStop = false;
            for (int i = 0; i < _count; i++)
            {
                Thread th = new Thread(Run);
                th.IsBackground = true;
                th.Name = "Consumer" + i;
                th.Start(th);
                _threads.Add(th);
            }
        }

        private void Run(object token)
        {
            try
            {
                Thread th = token as Thread;
                while (!_isStop)
                {
                    Interlocked.Increment(ref _consumeId);
                    T obj = _repository.Get(); //互斥访问缓冲区
                    Console.WriteLine(string.Format("\t\t\t\t\t\t\t\t[{1}] delete {0} ", obj, th.Name));
                }
            }
            catch (Exception ex)
            {
                //Maybe interupt
                Console.WriteLine("D0002\r\n" + ex);
            }
        }

        public void Stop()
        {
            _isStop = true;
            //foreach (var thread in _threads)
            //{
            //    thread.Interrupt();
            //}
            //_repository.Clear();
            //_threads.Clear();
        }
    }
}