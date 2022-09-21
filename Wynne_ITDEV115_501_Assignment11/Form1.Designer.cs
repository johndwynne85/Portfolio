namespace GUIAddressBook
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
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.emailTxtBx = new System.Windows.Forms.TextBox();
            this.phoneTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.nameMesLbl = new System.Windows.Forms.Label();
            this.emailMesLbl = new System.Windows.Forms.Label();
            this.phoneMesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(156, 68);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(148, 26);
            this.nameTxtBx.TabIndex = 0;
            this.nameTxtBx.TextChanged += new System.EventHandler(this.nameTxtBx_TextChanged);
            // 
            // emailTxtBx
            // 
            this.emailTxtBx.Location = new System.Drawing.Point(156, 142);
            this.emailTxtBx.Name = "emailTxtBx";
            this.emailTxtBx.Size = new System.Drawing.Size(148, 26);
            this.emailTxtBx.TabIndex = 1;
            // 
            // phoneTxtBx
            // 
            this.phoneTxtBx.Location = new System.Drawing.Point(156, 212);
            this.phoneTxtBx.Name = "phoneTxtBx";
            this.phoneTxtBx.Size = new System.Drawing.Size(148, 26);
            this.phoneTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(103, 293);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(124, 48);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.ForeColor = System.Drawing.Color.Red;
            this.messageLbl.Location = new System.Drawing.Point(108, 368);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 20);
            this.messageLbl.TabIndex = 7;
            // 
            // nameMesLbl
            // 
            this.nameMesLbl.AutoSize = true;
            this.nameMesLbl.ForeColor = System.Drawing.Color.Red;
            this.nameMesLbl.Location = new System.Drawing.Point(156, 101);
            this.nameMesLbl.Name = "nameMesLbl";
            this.nameMesLbl.Size = new System.Drawing.Size(0, 20);
            this.nameMesLbl.TabIndex = 8;
            // 
            // emailMesLbl
            // 
            this.emailMesLbl.AutoSize = true;
            this.emailMesLbl.ForeColor = System.Drawing.Color.Red;
            this.emailMesLbl.Location = new System.Drawing.Point(156, 175);
            this.emailMesLbl.Name = "emailMesLbl";
            this.emailMesLbl.Size = new System.Drawing.Size(0, 20);
            this.emailMesLbl.TabIndex = 9;
            // 
            // phoneMesLbl
            // 
            this.phoneMesLbl.AutoSize = true;
            this.phoneMesLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneMesLbl.Location = new System.Drawing.Point(156, 245);
            this.phoneMesLbl.Name = "phoneMesLbl";
            this.phoneMesLbl.Size = new System.Drawing.Size(0, 20);
            this.phoneMesLbl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 418);
            this.Controls.Add(this.phoneMesLbl);
            this.Controls.Add(this.emailMesLbl);
            this.Controls.Add(this.nameMesLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneTxtBx);
            this.Controls.Add(this.emailTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox emailTxtBx;
        private System.Windows.Forms.TextBox phoneTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label nameMesLbl;
        private System.Windows.Forms.Label emailMesLbl;
        private System.Windows.Forms.Label phoneMesLbl;
    }
}

