﻿
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn1 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.bttn5 = new System.Windows.Forms.Button();
            this.bttn6 = new System.Windows.Forms.Button();
            this.bttn7 = new System.Windows.Forms.Button();
            this.bttn8 = new System.Windows.Forms.Button();
            this.bttn = new System.Windows.Forms.Button();
            this.bttn0 = new System.Windows.Forms.Button();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnDivide = new System.Windows.Forms.Button();
            this.bttnSubs = new System.Windows.Forms.Button();
            this.bttnSums = new System.Windows.Forms.Button();
            this.bttnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(72, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(148, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CALCULATOR";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(11, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bttn1
            // 
            this.bttn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn1.Location = new System.Drawing.Point(11, 70);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(50, 50);
            this.bttn1.TabIndex = 2;
            this.bttn1.Text = "1";
            this.bttn1.UseVisualStyleBackColor = true;
            // 
            // bttn2
            // 
            this.bttn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn2.Location = new System.Drawing.Point(67, 70);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(50, 50);
            this.bttn2.TabIndex = 2;
            this.bttn2.Text = "2";
            this.bttn2.UseVisualStyleBackColor = true;
            // 
            // bttn3
            // 
            this.bttn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn3.Location = new System.Drawing.Point(123, 70);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(50, 50);
            this.bttn3.TabIndex = 2;
            this.bttn3.Text = "3";
            this.bttn3.UseVisualStyleBackColor = true;
            // 
            // bttn4
            // 
            this.bttn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn4.Location = new System.Drawing.Point(11, 126);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(50, 50);
            this.bttn4.TabIndex = 2;
            this.bttn4.Text = "4";
            this.bttn4.UseVisualStyleBackColor = true;
            // 
            // bttn5
            // 
            this.bttn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn5.Location = new System.Drawing.Point(67, 126);
            this.bttn5.Name = "bttn5";
            this.bttn5.Size = new System.Drawing.Size(50, 50);
            this.bttn5.TabIndex = 2;
            this.bttn5.Text = "5";
            this.bttn5.UseVisualStyleBackColor = true;
            // 
            // bttn6
            // 
            this.bttn6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn6.Location = new System.Drawing.Point(123, 126);
            this.bttn6.Name = "bttn6";
            this.bttn6.Size = new System.Drawing.Size(50, 50);
            this.bttn6.TabIndex = 2;
            this.bttn6.Text = "6";
            this.bttn6.UseVisualStyleBackColor = true;
            // 
            // bttn7
            // 
            this.bttn7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn7.Location = new System.Drawing.Point(11, 182);
            this.bttn7.Name = "bttn7";
            this.bttn7.Size = new System.Drawing.Size(50, 50);
            this.bttn7.TabIndex = 2;
            this.bttn7.Text = "7";
            this.bttn7.UseVisualStyleBackColor = true;
            // 
            // bttn8
            // 
            this.bttn8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn8.Location = new System.Drawing.Point(67, 182);
            this.bttn8.Name = "bttn8";
            this.bttn8.Size = new System.Drawing.Size(50, 50);
            this.bttn8.TabIndex = 2;
            this.bttn8.Text = "8";
            this.bttn8.UseVisualStyleBackColor = true;
            // 
            // bttn
            // 
            this.bttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn.Location = new System.Drawing.Point(123, 182);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(50, 50);
            this.bttn.TabIndex = 2;
            this.bttn.Text = "9";
            this.bttn.UseVisualStyleBackColor = true;
            // 
            // bttn0
            // 
            this.bttn0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn0.Location = new System.Drawing.Point(11, 238);
            this.bttn0.Name = "bttn0";
            this.bttn0.Size = new System.Drawing.Size(50, 50);
            this.bttn0.TabIndex = 2;
            this.bttn0.Text = "0";
            this.bttn0.UseVisualStyleBackColor = true;
            // 
            // bttnRemove
            // 
            this.bttnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnRemove.Location = new System.Drawing.Point(179, 70);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(106, 50);
            this.bttnRemove.TabIndex = 2;
            this.bttnRemove.Text = "Remove";
            this.bttnRemove.UseVisualStyleBackColor = true;
            // 
            // bttnDivide
            // 
            this.bttnDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnDivide.Location = new System.Drawing.Point(179, 126);
            this.bttnDivide.Name = "bttnDivide";
            this.bttnDivide.Size = new System.Drawing.Size(106, 50);
            this.bttnDivide.TabIndex = 2;
            this.bttnDivide.Text = "/";
            this.bttnDivide.UseVisualStyleBackColor = true;
            // 
            // bttnSubs
            // 
            this.bttnSubs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSubs.Location = new System.Drawing.Point(179, 182);
            this.bttnSubs.Name = "bttnSubs";
            this.bttnSubs.Size = new System.Drawing.Size(106, 50);
            this.bttnSubs.TabIndex = 2;
            this.bttnSubs.Text = "-";
            this.bttnSubs.UseVisualStyleBackColor = true;
            // 
            // bttnSums
            // 
            this.bttnSums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnSums.Location = new System.Drawing.Point(179, 238);
            this.bttnSums.Name = "bttnSums";
            this.bttnSums.Size = new System.Drawing.Size(106, 50);
            this.bttnSums.TabIndex = 2;
            this.bttnSums.Text = "+";
            this.bttnSums.UseVisualStyleBackColor = true;
            // 
            // bttnEquals
            // 
            this.bttnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnEquals.Location = new System.Drawing.Point(67, 238);
            this.bttnEquals.Name = "bttnEquals";
            this.bttnEquals.Size = new System.Drawing.Size(106, 50);
            this.bttnEquals.TabIndex = 2;
            this.bttnEquals.Text = "=";
            this.bttnEquals.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 299);
            this.Controls.Add(this.bttnEquals);
            this.Controls.Add(this.bttnSums);
            this.Controls.Add(this.bttnSubs);
            this.Controls.Add(this.bttnDivide);
            this.Controls.Add(this.bttn);
            this.Controls.Add(this.bttnRemove);
            this.Controls.Add(this.bttn6);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn0);
            this.Controls.Add(this.bttn8);
            this.Controls.Add(this.bttn7);
            this.Controls.Add(this.bttn5);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn3;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.Button bttn5;
        private System.Windows.Forms.Button bttn6;
        private System.Windows.Forms.Button bttn7;
        private System.Windows.Forms.Button bttn8;
        private System.Windows.Forms.Button bttn;
        private System.Windows.Forms.Button bttn0;
        private System.Windows.Forms.Button bttnRemove;
        private System.Windows.Forms.Button bttnDivide;
        private System.Windows.Forms.Button bttnSubs;
        private System.Windows.Forms.Button bttnSums;
        private System.Windows.Forms.Button bttnEquals;
    }
}

