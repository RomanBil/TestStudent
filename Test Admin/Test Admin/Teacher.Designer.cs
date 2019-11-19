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
            this.button7 = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.DownloadTest.SuspendLayout();
            this.CreateGroup.SuspendLayout();
            this.AddTest.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.labelPath.Location = new System.Drawing.Point(188, 68);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "path  to test:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(219, 110);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(94, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send to server";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(107, 110);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open test";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // CreateGroup
            // 
            this.CreateGroup.Controls.Add(this.tableLayoutPanel1);
            this.CreateGroup.Controls.Add(this.listView3);
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
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Location = new System.Drawing.Point(163, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 28);
            this.button6.TabIndex = 10;
            this.button6.Text = "Add student";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(131, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "Update group";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(260, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete student";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(259, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 28);
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
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(387, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cencel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
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
            this.AddTest.Controls.Add(this.button7);
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
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(493, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Add test to group";
            this.button7.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(71, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 251);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 174);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(515, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(515, 165);
            this.tableLayoutPanel4.TabIndex = 2;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader test;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader groupName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}