
namespace WFA_ATM
{
    partial class Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.usergrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTARGET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCASH = new System.Windows.Forms.TextBox();
            this.bttnGET = new System.Windows.Forms.Button();
            this.bttSEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnWITH = new System.Windows.Forms.Button();
            this.bttnDEPOSIT = new System.Windows.Forms.Button();
            this.textTARGETAMOUNT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMONEY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNAME = new System.Windows.Forms.Label();
            this.lblGENDER = new System.Windows.Forms.Label();
            this.lblSURNAME = new System.Windows.Forms.Label();
            this.lblLOCATION = new System.Windows.Forms.Label();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblCONTACT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usergrid
            // 
            this.usergrid.AllowUserToAddRows = false;
            this.usergrid.AllowUserToDeleteRows = false;
            this.usergrid.AllowUserToResizeColumns = false;
            this.usergrid.AllowUserToResizeRows = false;
            this.usergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usergrid.Location = new System.Drawing.Point(3, 45);
            this.usergrid.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.usergrid.MultiSelect = false;
            this.usergrid.Name = "usergrid";
            this.usergrid.ReadOnly = true;
            this.usergrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usergrid.Size = new System.Drawing.Size(546, 145);
            this.usergrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTARGET);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPASS);
            this.groupBox1.Controls.Add(this.txtCASH);
            this.groupBox1.Controls.Add(this.bttnGET);
            this.groupBox1.Controls.Add(this.bttSEND);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usergrid);
            this.groupBox1.Location = new System.Drawing.Point(7, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TARGET";
            // 
            // txtTARGET
            // 
            this.txtTARGET.Enabled = false;
            this.txtTARGET.Location = new System.Drawing.Point(6, 216);
            this.txtTARGET.Name = "txtTARGET";
            this.txtTARGET.Size = new System.Drawing.Size(354, 20);
            this.txtTARGET.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Targets Password (only for asking)\r\n";
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(6, 259);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.PasswordChar = '*';
            this.txtPASS.Size = new System.Drawing.Size(156, 20);
            this.txtPASS.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CASH";
            // 
            // txtCASH
            // 
            this.txtCASH.Location = new System.Drawing.Point(378, 216);
            this.txtCASH.Name = "txtCASH";
            this.txtCASH.Size = new System.Drawing.Size(171, 20);
            this.txtCASH.TabIndex = 4;
            this.txtCASH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCASH_KeyPress);
            // 
            // bttnGET
            // 
            this.bttnGET.Location = new System.Drawing.Point(189, 256);
            this.bttnGET.Name = "bttnGET";
            this.bttnGET.Size = new System.Drawing.Size(171, 23);
            this.bttnGET.TabIndex = 3;
            this.bttnGET.Text = "ASK";
            this.bttnGET.UseVisualStyleBackColor = true;
            this.bttnGET.Click += new System.EventHandler(this.bttnGET_Click);
            // 
            // bttSEND
            // 
            this.bttSEND.Location = new System.Drawing.Point(378, 256);
            this.bttSEND.Name = "bttSEND";
            this.bttSEND.Size = new System.Drawing.Size(171, 23);
            this.bttSEND.TabIndex = 2;
            this.bttSEND.Text = "SEND";
            this.bttSEND.UseVisualStyleBackColor = true;
            this.bttSEND.Click += new System.EventHandler(this.bttSEND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "InnerCustomer Transactions";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bttnWITH);
            this.groupBox2.Controls.Add(this.bttnDEPOSIT);
            this.groupBox2.Controls.Add(this.textTARGETAMOUNT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMONEY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(1, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 126);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bttnWITH
            // 
            this.bttnWITH.Location = new System.Drawing.Point(431, 149);
            this.bttnWITH.Name = "bttnWITH";
            this.bttnWITH.Size = new System.Drawing.Size(93, 23);
            this.bttnWITH.TabIndex = 12;
            this.bttnWITH.Text = "WITHDRAW";
            this.bttnWITH.UseVisualStyleBackColor = true;
            this.bttnWITH.Click += new System.EventHandler(this.bttnWITH_Click);
            // 
            // bttnDEPOSIT
            // 
            this.bttnDEPOSIT.Location = new System.Drawing.Point(321, 149);
            this.bttnDEPOSIT.Name = "bttnDEPOSIT";
            this.bttnDEPOSIT.Size = new System.Drawing.Size(93, 23);
            this.bttnDEPOSIT.TabIndex = 11;
            this.bttnDEPOSIT.Text = "DEPOSIT";
            this.bttnDEPOSIT.UseVisualStyleBackColor = true;
            this.bttnDEPOSIT.Click += new System.EventHandler(this.bttnDEPOSIT_Click);
            // 
            // textTARGETAMOUNT
            // 
            this.textTARGETAMOUNT.Location = new System.Drawing.Point(321, 115);
            this.textTARGETAMOUNT.Name = "textTARGETAMOUNT";
            this.textTARGETAMOUNT.Size = new System.Drawing.Size(203, 20);
            this.textTARGETAMOUNT.TabIndex = 10;
            this.textTARGETAMOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTARGET_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Target Amount";
            // 
            // txtMONEY
            // 
            this.txtMONEY.Enabled = false;
            this.txtMONEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMONEY.Location = new System.Drawing.Point(321, 15);
            this.txtMONEY.Name = "txtMONEY";
            this.txtMONEY.Size = new System.Drawing.Size(203, 30);
            this.txtMONEY.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(173, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current Money";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblNAME);
            this.groupBox3.Controls.Add(this.lblGENDER);
            this.groupBox3.Controls.Add(this.lblSURNAME);
            this.groupBox3.Controls.Add(this.lblLOCATION);
            this.groupBox3.Controls.Add(this.lblMAIL);
            this.groupBox3.Controls.Add(this.lblCONTACT);
            this.groupBox3.Location = new System.Drawing.Point(6, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 180);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "PERSONAL INFO";
            // 
            // lblNAME
            // 
            this.lblNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNAME.AutoSize = true;
            this.lblNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNAME.Location = new System.Drawing.Point(6, 38);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(47, 17);
            this.lblNAME.TabIndex = 0;
            this.lblNAME.Text = "NAME";
            // 
            // lblGENDER
            // 
            this.lblGENDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGENDER.AutoSize = true;
            this.lblGENDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGENDER.Location = new System.Drawing.Point(6, 150);
            this.lblGENDER.Name = "lblGENDER";
            this.lblGENDER.Size = new System.Drawing.Size(67, 17);
            this.lblGENDER.TabIndex = 5;
            this.lblGENDER.Text = "GENDER";
            // 
            // lblSURNAME
            // 
            this.lblSURNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSURNAME.AutoSize = true;
            this.lblSURNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSURNAME.Location = new System.Drawing.Point(6, 60);
            this.lblSURNAME.Name = "lblSURNAME";
            this.lblSURNAME.Size = new System.Drawing.Size(76, 17);
            this.lblSURNAME.TabIndex = 1;
            this.lblSURNAME.Text = "SURNAME";
            // 
            // lblLOCATION
            // 
            this.lblLOCATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLOCATION.AutoSize = true;
            this.lblLOCATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLOCATION.Location = new System.Drawing.Point(6, 127);
            this.lblLOCATION.Name = "lblLOCATION";
            this.lblLOCATION.Size = new System.Drawing.Size(78, 17);
            this.lblLOCATION.TabIndex = 4;
            this.lblLOCATION.Text = "LOCATION";
            // 
            // lblMAIL
            // 
            this.lblMAIL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMAIL.Location = new System.Drawing.Point(6, 82);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(39, 17);
            this.lblMAIL.TabIndex = 2;
            this.lblMAIL.Text = "MAIL";
            // 
            // lblCONTACT
            // 
            this.lblCONTACT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCONTACT.AutoSize = true;
            this.lblCONTACT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCONTACT.Location = new System.Drawing.Point(6, 104);
            this.lblCONTACT.Name = "lblCONTACT";
            this.lblCONTACT.Size = new System.Drawing.Size(74, 17);
            this.lblCONTACT.TabIndex = 3;
            this.lblCONTACT.Text = "CONTACT";
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bank";
            this.Text = "Bank";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankUI_FormClosed);
            this.Load += new System.EventHandler(this.BankUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usergrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnGET;
        private System.Windows.Forms.Button bttSEND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCASH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTARGET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.Label lblSURNAME;
        private System.Windows.Forms.Label lblLOCATION;
        private System.Windows.Forms.Label lblCONTACT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGENDER;
        private System.Windows.Forms.TextBox txtMONEY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTARGETAMOUNT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnWITH;
        private System.Windows.Forms.Button bttnDEPOSIT;
    }
}