namespace Parser_productStar
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NumericStart1 = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd1 = new System.Windows.Forms.NumericUpDown();
            this.ListTitles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumericStart1
            // 
            this.NumericStart1.Location = new System.Drawing.Point(184, 62);
            this.NumericStart1.Name = "NumericStart1";
            this.NumericStart1.Size = new System.Drawing.Size(120, 20);
            this.NumericStart1.TabIndex = 2;
            // 
            // NumericEnd1
            // 
            this.NumericEnd1.Location = new System.Drawing.Point(184, 112);
            this.NumericEnd1.Name = "NumericEnd1";
            this.NumericEnd1.Size = new System.Drawing.Size(120, 20);
            this.NumericEnd1.TabIndex = 3;
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(380, 62);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(389, 381);
            this.ListTitles.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Controls.Add(this.ListTitles);
            this.Controls.Add(this.NumericEnd1);
            this.Controls.Add(this.NumericStart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown NumericStart1;
        private System.Windows.Forms.NumericUpDown NumericEnd1;
        private System.Windows.Forms.ListBox ListTitles;
    }
}

