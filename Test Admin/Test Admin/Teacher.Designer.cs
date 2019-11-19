namespace Test_Admin
{
    partial class Teacher
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DownloadTest = new System.Windows.Forms.TabPage();
            this.CreateGroup = new System.Windows.Forms.TabPage();
            this.AddTest = new System.Windows.Forms.TabPage();
            this.ViewResult = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DownloadTest);
            this.tabControl1.Controls.Add(this.CreateGroup);
            this.tabControl1.Controls.Add(this.AddTest);
            this.tabControl1.Controls.Add(this.ViewResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // DownloadTest
            // 
            this.DownloadTest.Location = new System.Drawing.Point(4, 22);
            this.DownloadTest.Name = "DownloadTest";
            this.DownloadTest.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTest.Size = new System.Drawing.Size(792, 424);
            this.DownloadTest.TabIndex = 0;
            this.DownloadTest.Text = "Download test";
            this.DownloadTest.UseVisualStyleBackColor = true;
            // 
            // CreateGroup
            // 
            this.CreateGroup.Location = new System.Drawing.Point(4, 22);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Padding = new System.Windows.Forms.Padding(3);
            this.CreateGroup.Size = new System.Drawing.Size(792, 424);
            this.CreateGroup.TabIndex = 1;
            this.CreateGroup.Text = "Create group";
            this.CreateGroup.UseVisualStyleBackColor = true;
            // 
            // AddTest
            // 
            this.AddTest.Location = new System.Drawing.Point(4, 22);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(792, 424);
            this.AddTest.TabIndex = 2;
            this.AddTest.Text = "Add test to group";
            this.AddTest.UseVisualStyleBackColor = true;
            // 
            // ViewResult
            // 
            this.ViewResult.Location = new System.Drawing.Point(4, 22);
            this.ViewResult.Name = "ViewResult";
            this.ViewResult.Size = new System.Drawing.Size(792, 424);
            this.ViewResult.TabIndex = 3;
            this.ViewResult.Text = "View result";
            this.ViewResult.UseVisualStyleBackColor = true;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DownloadTest;
        private System.Windows.Forms.TabPage CreateGroup;
        private System.Windows.Forms.TabPage AddTest;
        private System.Windows.Forms.TabPage ViewResult;
    }
}