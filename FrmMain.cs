using System.Threading;
using System.Windows.Forms;

namespace ProducerAndConsumer
{
    public partial class FrmMain : Form
    {
        private Repository<string> repository = null;
        private Producer<string> producer = null;
        private Consumer<string> consumer = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            pbarRepository.Maximum = tbarRepository.Value;

            repository = new Repository<string>(pbarRepository.Maximum);
            repository.OnRepositoryChanged += OnRepositoryChanged;

            producer = new Producer<string>(repository, tbarProducer.Value);
            consumer = new Consumer<string>(repository, tBarConsumer.Value);

            ThreadPool.QueueUserWorkItem((target) => producer.Produce());
            ThreadPool.QueueUserWorkItem((target) => consumer.Consume());
        }

        private void OnRepositoryChanged(int count)
        {
            try
            {
                if (pbarRepository.InvokeRequired)
                {
                    OnRepositoryChangedHandler handler = OnRepositoryChanged;
                    this.Invoke(handler, count);
                }
                else
                {
                    pbarRepository.Value = count;
                }
            }
            catch
            {
            }
        }

        private void btnStopConsume_Click(object sender, System.EventArgs e)
        {
            if (consumer != null)
            {
                consumer.Stop();
            }
        }

        private void btnStopProduce_Click(object sender, System.EventArgs e)
        {
            if (producer != null)
            {
                producer.Stop();
            }
        }

        private void pbarRepository_MouseHover(object sender, System.EventArgs e)
        {
            string desc = string.Format("当前库存：{0}，最大库存：{1}，消费者总数：{2}，生产者总数：{3}", repository == null ? 0 : repository.Products.Count, pbarRepository.Maximum, tBarConsumer.Value, tbarProducer.Value);
            tipRepository.SetToolTip(pbarRepository, desc);
        }
    }
}