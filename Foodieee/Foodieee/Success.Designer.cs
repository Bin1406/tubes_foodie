
namespace Foodieee
{
    partial class Success
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSuccess = new System.Windows.Forms.Button();
            this.labelSucces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Foodieee.Properties.Resources.undraw_Checklist__re_2w7v_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSuccess
            // 
            this.buttonSuccess.BackColor = System.Drawing.Color.Coral;
            this.buttonSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuccess.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSuccess.Location = new System.Drawing.Point(75, 381);
            this.buttonSuccess.Name = "buttonSuccess";
            this.buttonSuccess.Size = new System.Drawing.Size(139, 40);
            this.buttonSuccess.TabIndex = 1;
            this.buttonSuccess.Text = "Back to Menu";
            this.buttonSuccess.UseVisualStyleBackColor = false;
            this.buttonSuccess.Click += new System.EventHandler(this.buttonSuccess_Click);
            // 
            // labelSucces
            // 
            this.labelSucces.AutoSize = true;
            this.labelSucces.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucces.Location = new System.Drawing.Point(57, 322);
            this.labelSucces.Name = "labelSucces";
            this.labelSucces.Size = new System.Drawing.Size(191, 26);
            this.labelSucces.TabIndex = 2;
            this.labelSucces.Text = "Payment Success!";
            this.labelSucces.Click += new System.EventHandler(this.labelSucces_Click);
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.labelSucces);
            this.Controls.Add(this.buttonSuccess);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Succes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSuccess;
        private System.Windows.Forms.Label labelSucces;
    }
}