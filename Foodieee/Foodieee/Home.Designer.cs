
namespace Foodieee
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLemonade = new System.Windows.Forms.Label();
            this.labelPromo = new System.Windows.Forms.Label();
            this.buttonRecom = new System.Windows.Forms.Button();
            this.buttonNear = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLemon = new System.Windows.Forms.PictureBox();
            this.secondControl1 = new Foodieee.SecondControl();
            this.firstControl1 = new Foodieee.FirstControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelLemonade);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxLemon);
            this.panel1.Controls.Add(this.labelPromo);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 186);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Markobar\r\n22k";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nasi Goreng\r\n25k";
            // 
            // labelLemonade
            // 
            this.labelLemonade.AutoSize = true;
            this.labelLemonade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLemonade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLemonade.ForeColor = System.Drawing.Color.White;
            this.labelLemonade.Location = new System.Drawing.Point(13, 132);
            this.labelLemonade.Name = "labelLemonade";
            this.labelLemonade.Size = new System.Drawing.Size(86, 36);
            this.labelLemonade.TabIndex = 4;
            this.labelLemonade.Text = "Lemonade\r\n9k";
            this.labelLemonade.Click += new System.EventHandler(this.labelLemonade_Click);
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPromo.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromo.ForeColor = System.Drawing.Color.White;
            this.labelPromo.Location = new System.Drawing.Point(3, 13);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(79, 23);
            this.labelPromo.TabIndex = 0;
            this.labelPromo.Text = "Promo";
            // 
            // buttonRecom
            // 
            this.buttonRecom.BackColor = System.Drawing.Color.White;
            this.buttonRecom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecom.ForeColor = System.Drawing.Color.Black;
            this.buttonRecom.Location = new System.Drawing.Point(6, 211);
            this.buttonRecom.Name = "buttonRecom";
            this.buttonRecom.Size = new System.Drawing.Size(102, 26);
            this.buttonRecom.TabIndex = 1;
            this.buttonRecom.Text = "Recomended";
            this.buttonRecom.UseVisualStyleBackColor = false;
            this.buttonRecom.Click += new System.EventHandler(this.buttonRecom_Click);
            // 
            // buttonNear
            // 
            this.buttonNear.BackColor = System.Drawing.Color.White;
            this.buttonNear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonNear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNear.ForeColor = System.Drawing.Color.Black;
            this.buttonNear.Location = new System.Drawing.Point(114, 211);
            this.buttonNear.Name = "buttonNear";
            this.buttonNear.Size = new System.Drawing.Size(82, 26);
            this.buttonNear.TabIndex = 2;
            this.buttonNear.Text = "Near You";
            this.buttonNear.UseVisualStyleBackColor = false;
            this.buttonNear.Click += new System.EventHandler(this.buttonNear_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.Color.Coral;
            this.comboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.ForeColor = System.Drawing.Color.White;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Termurah",
            "Termahal",
            "Terlaris"});
            this.comboBoxFilter.Location = new System.Drawing.Point(202, 211);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(94, 26);
            this.comboBoxFilter.TabIndex = 3;
            this.comboBoxFilter.Text = "Filter";
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Coral;
            this.SidePanel.Location = new System.Drawing.Point(6, 210);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(5, 26);
            this.SidePanel.TabIndex = 13;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Foodieee.Properties.Resources._3678904283;
            this.pictureBox3.Location = new System.Drawing.Point(228, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Foodieee.Properties.Resources.nasi_goreng_pedas_43;
            this.pictureBox2.Location = new System.Drawing.Point(121, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxLemon
            // 
            this.pictureBoxLemon.Image = global::Foodieee.Properties.Resources.lemonade;
            this.pictureBoxLemon.Location = new System.Drawing.Point(13, 49);
            this.pictureBoxLemon.Name = "pictureBoxLemon";
            this.pictureBoxLemon.Size = new System.Drawing.Size(89, 70);
            this.pictureBoxLemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLemon.TabIndex = 1;
            this.pictureBoxLemon.TabStop = false;
            this.pictureBoxLemon.Click += new System.EventHandler(this.pictureBoxLemon_Click);
            // 
            // secondControl1
            // 
            this.secondControl1.Location = new System.Drawing.Point(6, 243);
            this.secondControl1.Name = "secondControl1";
            this.secondControl1.Size = new System.Drawing.Size(325, 163);
            this.secondControl1.TabIndex = 15;
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(-1, 243);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(325, 163);
            this.firstControl1.TabIndex = 14;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.secondControl1);
            this.Controls.Add(this.firstControl1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonNear);
            this.Controls.Add(this.buttonRecom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxLemon;
        private System.Windows.Forms.Label labelPromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLemonade;
        private System.Windows.Forms.Button buttonRecom;
        private System.Windows.Forms.Button buttonNear;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Panel SidePanel;
        private FirstControl firstControl1;
        private SecondControl secondControl1;
    }
}