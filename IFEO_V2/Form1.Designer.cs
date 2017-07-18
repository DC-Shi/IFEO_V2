namespace IFEO_V2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxContent
            // 
            this.listBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.Location = new System.Drawing.Point(12, 12);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(320, 199);
            this.listBoxContent.TabIndex = 0;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetting.Controls.Add(this.labelImage);
            this.groupBoxSetting.Controls.Add(this.labelName);
            this.groupBoxSetting.Controls.Add(this.textBoxImage);
            this.groupBoxSetting.Controls.Add(this.textBoxName);
            this.groupBoxSetting.Controls.Add(this.buttonDel);
            this.groupBoxSetting.Controls.Add(this.buttonApply);
            this.groupBoxSetting.Location = new System.Drawing.Point(12, 217);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(253, 116);
            this.groupBoxSetting.TabIndex = 1;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Settings";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(7, 50);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(39, 13);
            this.labelImage.TabIndex = 2;
            this.labelImage.Text = "Image:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImage.Location = new System.Drawing.Point(51, 47);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(196, 20);
            this.textBoxImage.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(51, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(51, 73);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(97, 37);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(154, 73);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(93, 37);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(271, 230);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(61, 35);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(271, 298);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(61, 35);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 345);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "IFEO Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonExit;
    }
}

