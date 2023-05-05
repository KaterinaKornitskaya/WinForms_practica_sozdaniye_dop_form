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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button_zagrusit_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            //openFileDialog1.InitialDirectory = "C:\\Users\\Alex\\Desktop\\для формы";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                textBox_form1.Text = reader.ReadToEnd();
                reader.Close();
            }
            button_redaktir.Enabled = true;
        }

        public Form2 ChildForm { get; set; }

        private void button_redaktir_Click(object sender, EventArgs e)
        {
            if (ChildForm != null)
            {
                ChildForm.Activate();
                return;
            }
            ChildForm = new Form2(textBox_form1.Text);
            ChildForm.MainForm = this;
            ChildForm.Show();
        }
    }
}
