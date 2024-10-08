namespace A_TrayMsg
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
            this.plBlack = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.LinkLabel();
            this.plBlack.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBlack
            // 
            this.plBlack.BackColor = System.Drawing.Color.LightBlue;
            this.plBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBlack.Controls.Add(this.lblResult);
            this.plBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBlack.Location = new System.Drawing.Point(0, 0);
            this.plBlack.Name = "plBlack";
            this.plBlack.Size = new System.Drawing.Size(170, 120);
            this.plBlack.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(73, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 1;
            this.lblResult.TabStop = true;
            this.lblResult.Text = "결과";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblResult_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 120);
            this.Controls.Add(this.plBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "메시지 창";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.plBlack.ResumeLayout(false);
            this.plBlack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBlack;
        private System.Windows.Forms.LinkLabel lblResult;
    }
}