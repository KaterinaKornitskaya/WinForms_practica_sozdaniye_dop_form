namespace WinForms_les_sozdaniye_dop_form
{
    partial class Form1
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
            this.textBox_form1 = new System.Windows.Forms.TextBox();
            this.button_zagrusit = new System.Windows.Forms.Button();
            this.button_redaktir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_form1
            // 
            this.textBox_form1.Location = new System.Drawing.Point(12, 12);
            this.textBox_form1.Multiline = true;
            this.textBox_form1.Name = "textBox_form1";
            this.textBox_form1.ReadOnly = true;
            this.textBox_form1.Size = new System.Drawing.Size(260, 136);
            this.textBox_form1.TabIndex = 0;
            // 
            // button_zagrusit
            // 
            this.button_zagrusit.Location = new System.Drawing.Point(12, 181);
            this.button_zagrusit.Name = "button_zagrusit";
            this.button_zagrusit.Size = new System.Drawing.Size(122, 23);
            this.button_zagrusit.TabIndex = 1;
            this.button_zagrusit.Text = "Загрузить файл";
            this.button_zagrusit.UseVisualStyleBackColor = true;
            this.button_zagrusit.Click += new System.EventHandler(this.button_zagrusit_Click);
            // 
            // button_redaktir
            // 
            this.button_redaktir.Enabled = false;
            this.button_redaktir.Location = new System.Drawing.Point(150, 181);
            this.button_redaktir.Name = "button_redaktir";
            this.button_redaktir.Size = new System.Drawing.Size(122, 23);
            this.button_redaktir.TabIndex = 2;
            this.button_redaktir.Text = "Редактировать";
            this.button_redaktir.UseVisualStyleBackColor = true;
            this.button_redaktir.Click += new System.EventHandler(this.button_redaktir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_redaktir);
            this.Controls.Add(this.button_zagrusit);
            this.Controls.Add(this.textBox_form1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_form1;
        private System.Windows.Forms.Button button_zagrusit;
        private System.Windows.Forms.Button button_redaktir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

