namespace Lab1_WindowsForms
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
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.ckbSms = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.invalidEmailTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Location = new System.Drawing.Point(119, 86);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(18, 17);
            this.ckbEmail.TabIndex = 0;
            this.ckbEmail.UseVisualStyleBackColor = true;
            this.ckbEmail.CheckedChanged += new System.EventHandler(this.ckbEmail_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notification sent by email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(399, 80);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(261, 24);
            this.emailTxt.TabIndex = 2;
            // 
            // ckbSms
            // 
            this.ckbSms.AutoSize = true;
            this.ckbSms.Location = new System.Drawing.Point(119, 171);
            this.ckbSms.Name = "ckbSms";
            this.ckbSms.Size = new System.Drawing.Size(18, 17);
            this.ckbSms.TabIndex = 3;
            this.ckbSms.UseVisualStyleBackColor = true;
            this.ckbSms.CheckedChanged += new System.EventHandler(this.ckbSms_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notification sent by SMS";
            // 
            // numberTxt
            // 
            this.numberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.numberTxt.Location = new System.Drawing.Point(399, 165);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(261, 24);
            this.numberTxt.TabIndex = 5;
            this.numberTxt.Text = "XXX-XXX-XXXX";
            this.numberTxt.Enter += new System.EventHandler(this.numberTxt_Enter);
            this.numberTxt.Leave += new System.EventHandler(this.numberTxt_Leave);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(119, 317);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(147, 44);
            this.btnSubscribe.TabIndex = 6;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Unsubscribe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // invalidEmailTxt
            // 
            this.invalidEmailTxt.AutoSize = true;
            this.invalidEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidEmailTxt.Location = new System.Drawing.Point(399, 111);
            this.invalidEmailTxt.Name = "invalidEmailTxt";
            this.invalidEmailTxt.Size = new System.Drawing.Size(0, 18);
            this.invalidEmailTxt.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalidEmailTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbSms);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbEmail);
            this.Name = "Form2";
            this.Text = "Manage subscription";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.CheckBox ckbSms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label invalidEmailTxt;
    }
}