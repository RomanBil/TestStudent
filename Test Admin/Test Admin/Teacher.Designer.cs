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
            this.labelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.CreateGroup = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.nameGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.nameStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddTest = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.listView6 = new System.Windows.Forms.ListView();
            this.testGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddTtoG = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView5 = new System.Windows.Forms.ListView();
            this.test = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelGroup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.groupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewResult = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.DownloadTest.SuspendLayout();
            this.CreateGroup.SuspendLayout();
            this.AddTest.SuspendLayout();
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
            this.DownloadTest.Controls.Add(this.labelPath);
            this.DownloadTest.Controls.Add(this.label1);
            this.DownloadTest.Controls.Add(this.buttonSend);
            this.DownloadTest.Controls.Add(this.buttonOpen);
            this.DownloadTest.Location = new System.Drawing.Point(4, 22);
            this.DownloadTest.Name = "DownloadTest";
            this.DownloadTest.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTest.Size = new System.Drawing.Size(792, 424);
            this.DownloadTest.TabIndex = 0;
            this.DownloadTest.Text = "Download test";
            this.DownloadTest.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(117, 223);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "path  to test:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(138, 313);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(94, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send to server";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(26, 313);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open test";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // CreateGroup
            // 
            this.CreateGroup.Controls.Add(this.button6);
            this.CreateGroup.Controls.Add(this.button5);
            this.CreateGroup.Controls.Add(this.button4);
            this.CreateGroup.Controls.Add(this.button3);
            this.CreateGroup.Controls.Add(this.listView3);
            this.CreateGroup.Controls.Add(this.button2);
            this.CreateGroup.Controls.Add(this.button1);
            this.CreateGroup.Controls.Add(this.label2);
            this.CreateGroup.Controls.Add(this.textBoxGroup);
            this.CreateGroup.Controls.Add(this.listView2);
            this.CreateGroup.Controls.Add(this.listView1);
            this.CreateGroup.Location = new System.Drawing.Point(4, 22);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Padding = new System.Windows.Forms.Padding(3);
            this.CreateGroup.Size = new System.Drawing.Size(792, 424);
            this.CreateGroup.TabIndex = 1;
            this.CreateGroup.Text = "Create group";
            this.CreateGroup.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(349, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Add student";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(349, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Update group";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete student";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete group";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameGroup});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(598, 62);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(159, 215);
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // nameGroup
            // 
            this.nameGroup.Text = "Name group";
            this.nameGroup.Width = 77;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cencel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create group";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of group";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(460, 62);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroup.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameStudent});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(377, 119);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(183, 168);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // nameStudent
            // 
            this.nameStudent.Text = "Name student";
            this.nameStudent.Width = 91;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.Group});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 271);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name student";
            this.name.Width = 82;
            // 
            // Group
            // 
            this.Group.Text = "Group";
            // 
            // AddTest
            // 
            this.AddTest.Controls.Add(this.button8);
            this.AddTest.Controls.Add(this.listView6);
            this.AddTest.Controls.Add(this.buttonAddTtoG);
            this.AddTest.Controls.Add(this.labelTest);
            this.AddTest.Controls.Add(this.label4);
            this.AddTest.Controls.Add(this.listView5);
            this.AddTest.Controls.Add(this.labelGroup);
            this.AddTest.Controls.Add(this.label3);
            this.AddTest.Controls.Add(this.listView4);
            this.AddTest.Location = new System.Drawing.Point(4, 22);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(792, 424);
            this.AddTest.TabIndex = 2;
            this.AddTest.Text = "Add test to group";
            this.AddTest.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(657, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Delete test";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.testGroup});
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(254, 54);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(121, 97);
            this.listView6.TabIndex = 7;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // testGroup
            // 
            this.testGroup.Text = "Tests in group";
            this.testGroup.Width = 96;
            // 
            // buttonAddTtoG
            // 
            this.buttonAddTtoG.Location = new System.Drawing.Point(493, 372);
            this.buttonAddTtoG.Name = "buttonAddTtoG";
            this.buttonAddTtoG.Size = new System.Drawing.Size(113, 23);
            this.buttonAddTtoG.TabIndex = 6;
            this.buttonAddTtoG.Text = "Add test to group";
            this.buttonAddTtoG.UseVisualStyleBackColor = true;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(581, 13);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Test:";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.test});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(544, 54);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(139, 252);
            this.listView5.TabIndex = 3;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // test
            // 
            this.test.Text = "Test";
            this.test.Width = 58;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(79, 13);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(35, 13);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name group:";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.groupName});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(8, 38);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(137, 268);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // groupName
            // 
            this.groupName.Text = "Group";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.DownloadTest.ResumeLayout(false);
            this.DownloadTest.PerformLayout();
            this.CreateGroup.ResumeLayout(false);
            this.CreateGroup.PerformLayout();
            this.AddTest.ResumeLayout(false);
            this.AddTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DownloadTest;
        private System.Windows.Forms.TabPage CreateGroup;
        private System.Windows.Forms.TabPage AddTest;
        private System.Windows.Forms.TabPage ViewResult;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader nameGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader nameStudent;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader testGroup;
        private System.Windows.Forms.Button buttonAddTtoG;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader test;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader groupName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}