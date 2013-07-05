ProducerAndConsumer
===================

简单的生产者消费者示例

伪代码如下：
void  producer()
    { 
       while (true)
　　 {  …
         produce an item in nextp;
         …
　　P(empty);
        P(mutex);
        buffer(in)=nextp;
        in=(in+1)mod% n;
        V(mutex);
        V(full);
        }
    }                                   


void  consumer()
    {
      while (true)
       { P(full);
        P(mutex);
        nextc=buffer(out);
        out=(out+1) % n;
        V(mutex);
        V(empty);
        consume the item in nextc;
       }
   }

产品放入缓冲区后通过V操作唤醒等待产品的消费者进程，产品消费后通过V操作唤醒等待空缓冲区的生产者进程。
