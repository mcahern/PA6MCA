﻿
namespace PA6MCA
{
    partial class frmCWID
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
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.btnCWID = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Location = new System.Drawing.Point(29, 51);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(158, 24);
            this.lblCWID.TabIndex = 0;
            this.lblCWID.Text = "Enter Your CWID:";
            this.lblCWID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(206, 48);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(199, 29);
            this.txtCWID.TabIndex = 1;
            // 
            // btnCWID
            // 
            this.btnCWID.Location = new System.Drawing.Point(231, 98);
            this.btnCWID.Name = "btnCWID";
            this.btnCWID.Size = new System.Drawing.Size(67, 32);
            this.btnCWID.TabIndex = 2;
            this.btnCWID.Text = "OK";
            this.btnCWID.UseVisualStyleBackColor = true;
            this.btnCWID.Click += new System.EventHandler(this.btnCWID_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 98);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 180);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCWID);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lblCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCWID";
            this.Text = "CWID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button btnCWID;
        private System.Windows.Forms.Button btnClose;
    }
}

