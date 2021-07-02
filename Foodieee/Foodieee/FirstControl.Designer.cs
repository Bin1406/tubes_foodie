
/*
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
*/
namespace Foodieee
{
    partial class FirstControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            string[] list_makanan = { "Jus Anggur", "Ice Cream", "Sang Pisang" };
            string[] list_harga = { "22.000", "25.000", "30.000" };

            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelMorning = new System.Windows.Forms.Label();
            this.hargaMakanan1 = new System.Windows.Forms.Label();
            this.hargaMakanan2 = new System.Windows.Forms.Label();
            this.hargaMakanan3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(228, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = list_makanan[0];
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(120, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = list_makanan[1];
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = list_makanan[2];
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Foodieee.Properties.Resources.Sang_Pisang_Nugget_Pisang_Kekinian;
            this.pictureBox6.Location = new System.Drawing.Point(230, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Foodieee.Properties.Resources.REST_284_727x720_FIT_AND_TRIM_f1c371073b2ffe160cbf115724ff355d;
            this.pictureBox5.Location = new System.Drawing.Point(123, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Foodieee.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(9, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // labelMorning
            // 
            this.labelMorning.AutoSize = true;
            this.labelMorning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMorning.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMorning.ForeColor = System.Drawing.Color.Black;
            this.labelMorning.Location = new System.Drawing.Point(5, 9);
            this.labelMorning.Name = "labelMorning";
            this.labelMorning.Size = new System.Drawing.Size(97, 23);
            this.labelMorning.TabIndex = 14;
            this.labelMorning.Text = "Morning";
            // 
            // hargaMakanan1
            // 
            this.hargaMakanan1.AutoSize = true;
            this.hargaMakanan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hargaMakanan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaMakanan1.ForeColor = System.Drawing.Color.Black;
            this.hargaMakanan1.Location = new System.Drawing.Point(12, 136);
            this.hargaMakanan1.Name = "hargaMakanan1";
            this.hargaMakanan1.Size = new System.Drawing.Size(88, 18);
            this.hargaMakanan1.TabIndex = 19;
            this.hargaMakanan1.Text = list_harga[2];
            // 
            // hargaMakanan2
            // 
            this.hargaMakanan2.AutoSize = true;
            this.hargaMakanan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hargaMakanan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaMakanan2.ForeColor = System.Drawing.Color.Black;
            this.hargaMakanan2.Location = new System.Drawing.Point(120, 136);
            this.hargaMakanan2.Name = "hargaMakanan2";
            this.hargaMakanan2.Size = new System.Drawing.Size(92, 18);
            this.hargaMakanan2.TabIndex = 20;
            this.hargaMakanan2.Text = list_harga[1];
            // 
            // hargaMakanan3
            // 
            this.hargaMakanan3.AutoSize = true;
            this.hargaMakanan3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hargaMakanan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaMakanan3.ForeColor = System.Drawing.Color.Black;
            this.hargaMakanan3.Location = new System.Drawing.Point(227, 136);
            this.hargaMakanan3.Name = "hargaMakanan3";
            this.hargaMakanan3.Size = new System.Drawing.Size(88, 18);
            this.hargaMakanan3.TabIndex = 21;
            this.hargaMakanan3.Text = list_harga[0];
            // 
            // FirstControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hargaMakanan3);
            this.Controls.Add(this.hargaMakanan2);
            this.Controls.Add(this.hargaMakanan1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelMorning);
            this.Name = "FirstControl";
            this.Size = new System.Drawing.Size(325, 163);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelMorning;
        private System.Windows.Forms.Label hargaMakanan1;
        private System.Windows.Forms.Label hargaMakanan2;
        private System.Windows.Forms.Label hargaMakanan3;
    }
}
