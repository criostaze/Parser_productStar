using AngleSharp.Browser;
using Parser_productStar.CoreParse;
using Parser_productStar.CoreParse.Habra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser_productStar
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(
                    new HabraParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }


        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Settings = new HabraSettings((int)NumericStart1.Value, (int)NumericEnd1.Value);
            parser.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }
    }
}
