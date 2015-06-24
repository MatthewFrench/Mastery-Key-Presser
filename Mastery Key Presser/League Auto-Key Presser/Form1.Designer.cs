namespace League_Auto_Key_Presser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autoKeyOn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // autoKeyOn
            // 
            this.autoKeyOn.AutoSize = true;
            this.autoKeyOn.Checked = true;
            this.autoKeyOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoKeyOn.Location = new System.Drawing.Point(12, 12);
            this.autoKeyOn.Name = "autoKeyOn";
            this.autoKeyOn.Size = new System.Drawing.Size(192, 17);
            this.autoKeyOn.TabIndex = 6;
            this.autoKeyOn.Text = "Mastery Key Presser On (control+6)";
            this.autoKeyOn.UseVisualStyleBackColor = true;
            this.autoKeyOn.CheckedChanged += new System.EventHandler(this.autoKeyOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 44);
            this.Controls.Add(this.autoKeyOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mastery Key Presser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox autoKeyOn;
    }
}

