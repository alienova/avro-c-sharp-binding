namespace Avro_Keyboard_Mode_Switching
{
    partial class frmExample
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
            this.txtNameBangla = new System.Windows.Forms.TextBox();
            this.txtNameEnglish = new System.Windows.Forms.TextBox();
            this.lblNameEnglish = new System.Windows.Forms.Label();
            this.lblNameBangla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameBangla
            // 
            this.txtNameBangla.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBangla.Location = new System.Drawing.Point(67, 59);
            this.txtNameBangla.Name = "txtNameBangla";
            this.txtNameBangla.Size = new System.Drawing.Size(203, 29);
            this.txtNameBangla.TabIndex = 1;
            this.txtNameBangla.Enter += new System.EventHandler(this.txtNameBangla_Enter);
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(67, 15);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Size = new System.Drawing.Size(203, 20);
            this.txtNameEnglish.TabIndex = 0;
            this.txtNameEnglish.Enter += new System.EventHandler(this.txtNameEnglish_Enter);
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.AutoSize = true;
            this.lblNameEnglish.Location = new System.Drawing.Point(13, 21);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(35, 13);
            this.lblNameEnglish.TabIndex = 2;
            this.lblNameEnglish.Text = "Name";
            // 
            // lblNameBangla
            // 
            this.lblNameBangla.AutoSize = true;
            this.lblNameBangla.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBangla.Location = new System.Drawing.Point(12, 67);
            this.lblNameBangla.Name = "lblNameBangla";
            this.lblNameBangla.Size = new System.Drawing.Size(30, 21);
            this.lblNameBangla.TabIndex = 3;
            this.lblNameBangla.Text = "নাম";
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 101);
            this.Controls.Add(this.lblNameBangla);
            this.Controls.Add(this.lblNameEnglish);
            this.Controls.Add(this.txtNameEnglish);
            this.Controls.Add(this.txtNameBangla);
            this.Name = "frmExample";
            this.Text = "Example Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameBangla;
        private System.Windows.Forms.TextBox txtNameEnglish;
        private System.Windows.Forms.Label lblNameEnglish;
        private System.Windows.Forms.Label lblNameBangla;
    }
}

