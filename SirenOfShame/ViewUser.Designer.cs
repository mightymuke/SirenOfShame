﻿namespace SirenOfShame
{
    partial class ViewUser
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
            this.components = new System.ComponentModel.Container();
            this._userName = new System.Windows.Forms.Label();
            this._closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._obtainedTemplate = new System.Windows.Forms.Label();
            this._unobtainedTemplate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._viewAllAchievements = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this._closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // _userName
            // 
            this._userName.AutoSize = true;
            this._userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userName.Location = new System.Drawing.Point(3, 3);
            this._userName.Name = "_userName";
            this._userName.Size = new System.Drawing.Size(70, 26);
            this._userName.TabIndex = 0;
            this._userName.Text = "label1";
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this._closeButton.Image = global::SirenOfShame.Properties.Resources.CloseButton2;
            this._closeButton.Location = new System.Drawing.Point(618, 3);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(12, 12);
            this._closeButton.TabIndex = 1;
            this._closeButton.TabStop = false;
            this._closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Achievements";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(595, 226);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // _obtainedTemplate
            // 
            this._obtainedTemplate.AutoSize = true;
            this._obtainedTemplate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._obtainedTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._obtainedTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._obtainedTemplate.ForeColor = System.Drawing.SystemColors.Window;
            this._obtainedTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._obtainedTemplate.Location = new System.Drawing.Point(392, 3);
            this._obtainedTemplate.Margin = new System.Windows.Forms.Padding(3);
            this._obtainedTemplate.Name = "_obtainedTemplate";
            this._obtainedTemplate.Size = new System.Drawing.Size(143, 18);
            this._obtainedTemplate.TabIndex = 4;
            this._obtainedTemplate.Text = "Obtained Template";
            this._obtainedTemplate.Visible = false;
            // 
            // _unobtainedTemplate
            // 
            this._unobtainedTemplate.AccessibleDescription = "";
            this._unobtainedTemplate.AccessibleName = "";
            this._unobtainedTemplate.AutoSize = true;
            this._unobtainedTemplate.BackColor = System.Drawing.Color.LightGray;
            this._unobtainedTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._unobtainedTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._unobtainedTemplate.ForeColor = System.Drawing.Color.Gray;
            this._unobtainedTemplate.Location = new System.Drawing.Point(226, 3);
            this._unobtainedTemplate.Margin = new System.Windows.Forms.Padding(3);
            this._unobtainedTemplate.Name = "_unobtainedTemplate";
            this._unobtainedTemplate.Size = new System.Drawing.Size(141, 18);
            this._unobtainedTemplate.TabIndex = 5;
            this._unobtainedTemplate.Text = "Unobtained Template";
            this._unobtainedTemplate.Visible = false;
            // 
            // _viewAllAchievements
            // 
            this._viewAllAchievements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._viewAllAchievements.AutoSize = true;
            this._viewAllAchievements.Location = new System.Drawing.Point(586, 36);
            this._viewAllAchievements.Name = "_viewAllAchievements";
            this._viewAllAchievements.Size = new System.Drawing.Size(44, 13);
            this._viewAllAchievements.TabIndex = 6;
            this._viewAllAchievements.TabStop = true;
            this._viewAllAchievements.Text = "View All";
            this._viewAllAchievements.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._viewAllAchievements_LinkClicked);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._viewAllAchievements);
            this.Controls.Add(this._obtainedTemplate);
            this.Controls.Add(this._unobtainedTemplate);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._userName);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(633, 281);
            ((System.ComponentModel.ISupportInitialize)(this._closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _userName;
        private System.Windows.Forms.PictureBox _closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label _obtainedTemplate;
        private System.Windows.Forms.Label _unobtainedTemplate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel _viewAllAchievements;
    }
}