namespace Lab1_WindowsForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pubnot = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage subscription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pubnot
            // 
            this.btn_pubnot.Location = new System.Drawing.Point(316, 179);
            this.btn_pubnot.Name = "btn_pubnot";
            this.btn_pubnot.Size = new System.Drawing.Size(173, 57);
            this.btn_pubnot.TabIndex = 1;
            this.btn_pubnot.Text = "Publish Notification";
            this.btn_pubnot.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_pubnot);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Notification Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_pubnot;
        private System.Windows.Forms.Button button3;
    }
}

