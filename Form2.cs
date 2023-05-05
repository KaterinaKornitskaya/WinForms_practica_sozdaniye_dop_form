using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_les_sozdaniye_dop_form
{
    public partial class Form2 : Form
    {
        public Form1 MainForm { get; set; }

        public Form2(string text)  // в этом конструкторе сделали так, что бы в ТекстБокс 2ой формы
        {                          // открывался текс из ТекстБокса 1ой формы
            InitializeComponent();
            textBox_form2.Text = text;
        }
              
        private void button1_sohranit_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(textBox_form2.Text);
                writer.Close();
            }
        }

        private void button_otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }      
    }
}
