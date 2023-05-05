namespace WinForms_les_sozdaniye_dop_form
{
    partial class Form2
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
            this.button1_sohranit = new System.Windows.Forms.Button();
            this.button_otmenit = new System.Windows.Forms.Button();
            this.textBox_form2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1_sohranit
            // 
            this.button1_sohranit.Location = new System.Drawing.Point(12, 182);
            this.button1_sohranit.Name = "button1_sohranit";
            this.button1_sohranit.Size = new System.Drawing.Size(122, 23);
            this.button1_sohranit.TabIndex = 0;
            this.button1_sohranit.Text = "Сохранить";
            this.button1_sohranit.UseVisualStyleBackColor = true;
            this.button1_sohranit.Click += new System.EventHandler(this.button1_sohranit_Click);
            // 
            // button_otmenit
            // 
            this.button_otmenit.Location = new System.Drawing.Point(150, 182);
            this.button_otmenit.Name = "button_otmenit";
            this.button_otmenit.Size = new System.Drawing.Size(122, 23);
            this.button_otmenit.TabIndex = 1;
            this.button_otmenit.Text = "Отменить";
            this.button_otmenit.UseVisualStyleBackColor = true;
            this.button_otmenit.Click += new System.EventHandler(this.button_otmenit_Click);
            // 
            // textBox_form2
            // 
            this.textBox_form2.Location = new System.Drawing.Point(12, 12);
            this.textBox_form2.Multiline = true;
            this.textBox_form2.Name = "textBox_form2";
            this.textBox_form2.Size = new System.Drawing.Size(260, 137);
            this.textBox_form2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_form2);
            this.Controls.Add(this.button_otmenit);
            this.Controls.Add(this.button1_sohranit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_sohranit;
        private System.Windows.Forms.Button button_otmenit;
        private System.Windows.Forms.TextBox textBox_form2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}