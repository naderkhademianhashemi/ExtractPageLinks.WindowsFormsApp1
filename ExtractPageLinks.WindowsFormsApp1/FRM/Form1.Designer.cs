namespace WindowsFormsApplication7
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetPageLinks = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGetHtmlFileLinks = new System.Windows.Forms.Button();
            this.btnMp4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGetCapital = new System.Windows.Forms.Button();
            this.btnTdTags = new System.Windows.Forms.Button();
            this.btnGetNDgt = new System.Windows.Forms.Button();
            this.txtNNbr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(97, 108);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(196, 22);
            this.txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnGetPageLinks
            // 
            this.btnGetPageLinks.Location = new System.Drawing.Point(16, 201);
            this.btnGetPageLinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetPageLinks.Name = "btnGetPageLinks";
            this.btnGetPageLinks.Size = new System.Drawing.Size(147, 28);
            this.btnGetPageLinks.TabIndex = 2;
            this.btnGetPageLinks.Text = "Get page links";
            this.btnGetPageLinks.UseVisualStyleBackColor = true;
            this.btnGetPageLinks.Click += new System.EventHandler(this.btnGetPageLinks_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(97, 52);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(196, 22);
            this.txtFileName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "file name";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(320, 49);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGetHtmlFileLinks
            // 
            this.btnGetHtmlFileLinks.Location = new System.Drawing.Point(16, 256);
            this.btnGetHtmlFileLinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetHtmlFileLinks.Name = "btnGetHtmlFileLinks";
            this.btnGetHtmlFileLinks.Size = new System.Drawing.Size(147, 28);
            this.btnGetHtmlFileLinks.TabIndex = 6;
            this.btnGetHtmlFileLinks.Text = "get html file links";
            this.btnGetHtmlFileLinks.UseVisualStyleBackColor = true;
            this.btnGetHtmlFileLinks.Click += new System.EventHandler(this.btnGetHtmlFileLinks_Click);
            // 
            // btnMp4
            // 
            this.btnMp4.Location = new System.Drawing.Point(195, 201);
            this.btnMp4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMp4.Name = "btnMp4";
            this.btnMp4.Size = new System.Drawing.Size(100, 28);
            this.btnMp4.TabIndex = 7;
            this.btnMp4.Text = "btnMp4";
            this.btnMp4.UseVisualStyleBackColor = true;
            this.btnMp4.Click += new System.EventHandler(this.btnMp4_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "G:\\links-logs";
            // 
            // btnGetCapital
            // 
            this.btnGetCapital.Location = new System.Drawing.Point(332, 201);
            this.btnGetCapital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetCapital.Name = "btnGetCapital";
            this.btnGetCapital.Size = new System.Drawing.Size(100, 28);
            this.btnGetCapital.TabIndex = 8;
            this.btnGetCapital.Text = "Get capital";
            this.btnGetCapital.UseVisualStyleBackColor = true;
            this.btnGetCapital.Click += new System.EventHandler(this.btnGetCapital_Click);
            // 
            // btnTdTags
            // 
            this.btnTdTags.Location = new System.Drawing.Point(332, 256);
            this.btnTdTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTdTags.Name = "btnTdTags";
            this.btnTdTags.Size = new System.Drawing.Size(100, 28);
            this.btnTdTags.TabIndex = 9;
            this.btnTdTags.Text = "Get Td tags";
            this.btnTdTags.UseVisualStyleBackColor = true;
            this.btnTdTags.Click += new System.EventHandler(this.btnTdTags_Click);
            // 
            // btnGetNDgt
            // 
            this.btnGetNDgt.Location = new System.Drawing.Point(320, 155);
            this.btnGetNDgt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetNDgt.Name = "btnGetNDgt";
            this.btnGetNDgt.Size = new System.Drawing.Size(100, 28);
            this.btnGetNDgt.TabIndex = 10;
            this.btnGetNDgt.Text = "Get N Digit";
            this.btnGetNDgt.UseVisualStyleBackColor = true;
            this.btnGetNDgt.Click += new System.EventHandler(this.btnGetNDgt_Click);
            // 
            // txtNNbr
            // 
            this.txtNNbr.Location = new System.Drawing.Point(97, 159);
            this.txtNNbr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNNbr.Name = "txtNNbr";
            this.txtNNbr.Size = new System.Drawing.Size(196, 22);
            this.txtNNbr.TabIndex = 11;
            this.txtNNbr.Text = "11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 316);
            this.Controls.Add(this.txtNNbr);
            this.Controls.Add(this.btnGetNDgt);
            this.Controls.Add(this.btnTdTags);
            this.Controls.Add(this.btnGetCapital);
            this.Controls.Add(this.btnMp4);
            this.Controls.Add(this.btnGetHtmlFileLinks);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnGetPageLinks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "App-ExtractPageLinks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetPageLinks;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGetHtmlFileLinks;
        private System.Windows.Forms.Button btnMp4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGetCapital;
        private System.Windows.Forms.Button btnTdTags;
        private System.Windows.Forms.Button btnGetNDgt;
        private System.Windows.Forms.TextBox txtNNbr;
    }
}

