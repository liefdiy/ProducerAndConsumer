namespace ProducerAndConsumer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbarRepository = new System.Windows.Forms.ProgressBar();
            this.tBarConsumer = new System.Windows.Forms.TrackBar();
            this.tbarProducer = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStopConsume = new System.Windows.Forms.Button();
            this.btnStopProduce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbarRepository = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tBarConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarProducer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // pbarRepository
            // 
            this.pbarRepository.Location = new System.Drawing.Point(15, 181);
            this.pbarRepository.Name = "pbarRepository";
            this.pbarRepository.Size = new System.Drawing.Size(332, 36);
            this.pbarRepository.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarRepository.TabIndex = 0;
            // 
            // tBarConsumer
            // 
            this.tBarConsumer.Location = new System.Drawing.Point(72, 63);
            this.tBarConsumer.Name = "tBarConsumer";
            this.tBarConsumer.Size = new System.Drawing.Size(273, 45);
            this.tBarConsumer.TabIndex = 1;
            // 
            // tbarProducer
            // 
            this.tbarProducer.Location = new System.Drawing.Point(72, 12);
            this.tbarProducer.Name = "tbarProducer";
            this.tbarProducer.Size = new System.Drawing.Size(273, 45);
            this.tbarProducer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "生产者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "消费者：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 44);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStopConsume
            // 
            this.btnStopConsume.Location = new System.Drawing.Point(141, 241);
            this.btnStopConsume.Name = "btnStopConsume";
            this.btnStopConsume.Size = new System.Drawing.Size(75, 44);
            this.btnStopConsume.TabIndex = 6;
            this.btnStopConsume.Text = "停止消费";
            this.btnStopConsume.UseVisualStyleBackColor = true;
            this.btnStopConsume.Click += new System.EventHandler(this.btnStopConsume_Click);
            // 
            // btnStopProduce
            // 
            this.btnStopProduce.Location = new System.Drawing.Point(272, 241);
            this.btnStopProduce.Name = "btnStopProduce";
            this.btnStopProduce.Size = new System.Drawing.Size(75, 44);
            this.btnStopProduce.TabIndex = 7;
            this.btnStopProduce.Text = "停止生产";
            this.btnStopProduce.UseVisualStyleBackColor = true;
            this.btnStopProduce.Click += new System.EventHandler(this.btnStopProduce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "库  存：";
            // 
            // tbarRepository
            // 
            this.tbarRepository.Location = new System.Drawing.Point(72, 114);
            this.tbarRepository.Maximum = 20;
            this.tbarRepository.Name = "tbarRepository";
            this.tbarRepository.Size = new System.Drawing.Size(273, 45);
            this.tbarRepository.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 313);
            this.Controls.Add(this.tbarRepository);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStopProduce);
            this.Controls.Add(this.btnStopConsume);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbarProducer);
            this.Controls.Add(this.tBarConsumer);
            this.Controls.Add(this.pbarRepository);
            this.Name = "FrmMain";
            this.Text = "生产者和消费者";
            ((System.ComponentModel.ISupportInitialize)(this.tBarConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarProducer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbarRepository;
        private System.Windows.Forms.TrackBar tBarConsumer;
        private System.Windows.Forms.TrackBar tbarProducer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopConsume;
        private System.Windows.Forms.Button btnStopProduce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbarRepository;
    }
}

