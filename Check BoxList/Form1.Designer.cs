namespace Check_BoxList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbBody = new System.Windows.Forms.CheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddTask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChected = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUnSelected = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbTaskChecked = new System.Windows.Forms.Label();
            this.lbTasksNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbpnl = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbInsidetb = new System.Windows.Forms.Label();
            this.btnCncele = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcLinkedin = new System.Windows.Forms.PictureBox();
            this.pcGithub = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbpnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBody
            // 
            this.cbBody.BackColor = System.Drawing.Color.Beige;
            this.cbBody.Font = new System.Drawing.Font("Tahoma", 12.75F);
            this.cbBody.ForeColor = System.Drawing.Color.Black;
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(-3, 136);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(750, 349);
            this.cbBody.TabIndex = 0;
            this.cbBody.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbBody_ItemCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            this.imageList1.Images.SetKeyName(3, "checklist (1).png");
            this.imageList1.Images.SetKeyName(4, "dust.png");
            this.imageList1.Images.SetKeyName(5, "delete.png");
            this.imageList1.Images.SetKeyName(6, "x-button.png");
            this.imageList1.Images.SetKeyName(7, "pencil.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Daily Task";
            // 
            // tbAddTask
            // 
            this.tbAddTask.BackColor = System.Drawing.Color.Beige;
            this.tbAddTask.Location = new System.Drawing.Point(0, 18);
            this.tbAddTask.Multiline = true;
            this.tbAddTask.Name = "tbAddTask";
            this.tbAddTask.Size = new System.Drawing.Size(200, 30);
            this.tbAddTask.TabIndex = 12;
            this.tbAddTask.TextChanged += new System.EventHandler(this.tbAddTask_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Organize your day and get things done!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnChected);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnUnSelected);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(743, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 349);
            this.panel1.TabIndex = 17;
            // 
            // btnChected
            // 
            this.btnChected.BackColor = System.Drawing.Color.Transparent;
            this.btnChected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChected.ImageIndex = 3;
            this.btnChected.ImageList = this.imageList1;
            this.btnChected.Location = new System.Drawing.Point(10, 241);
            this.btnChected.Name = "btnChected";
            this.btnChected.Size = new System.Drawing.Size(140, 34);
            this.btnChected.TabIndex = 9;
            this.btnChected.Text = "Compeleted";
            this.btnChected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChected.UseVisualStyleBackColor = false;
            this.btnChected.Click += new System.EventHandler(this.btnChected_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 7;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(15, 131);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUnSelected
            // 
            this.btnUnSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnUnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnSelected.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnSelected.ImageIndex = 6;
            this.btnUnSelected.ImageList = this.imageList1;
            this.btnUnSelected.Location = new System.Drawing.Point(10, 295);
            this.btnUnSelected.Name = "btnUnSelected";
            this.btnUnSelected.Size = new System.Drawing.Size(140, 38);
            this.btnUnSelected.TabIndex = 7;
            this.btnUnSelected.Text = "Unselect All";
            this.btnUnSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnSelected.UseVisualStyleBackColor = false;
            this.btnUnSelected.Click += new System.EventHandler(this.btnUnSelected_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearAll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.ImageIndex = 4;
            this.btnClearAll.ImageList = this.imageList1;
            this.btnClearAll.Location = new System.Drawing.Point(10, 186);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(140, 35);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(15, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(15, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.lbRate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbTaskChecked);
            this.panel2.Controls.Add(this.lbTasksNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-3, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 66);
            this.panel2.TabIndex = 19;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.ForeColor = System.Drawing.Color.Lime;
            this.lbRate.Location = new System.Drawing.Point(795, 31);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(31, 18);
            this.lbRate.TabIndex = 8;
            this.lbRate.Text = "0%";
            this.lbRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(639, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(643, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(146, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(321, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Completed";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Check_BoxList.Properties.Resources._checked;
            this.pictureBox3.Location = new System.Drawing.Point(249, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lbTaskChecked
            // 
            this.lbTaskChecked.AutoSize = true;
            this.lbTaskChecked.BackColor = System.Drawing.Color.Transparent;
            this.lbTaskChecked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskChecked.ForeColor = System.Drawing.Color.Blue;
            this.lbTaskChecked.Location = new System.Drawing.Point(374, 41);
            this.lbTaskChecked.Name = "lbTaskChecked";
            this.lbTaskChecked.Size = new System.Drawing.Size(19, 19);
            this.lbTaskChecked.TabIndex = 4;
            this.lbTaskChecked.Text = "0";
            // 
            // lbTasksNumber
            // 
            this.lbTasksNumber.AutoSize = true;
            this.lbTasksNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbTasksNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasksNumber.ForeColor = System.Drawing.Color.Blue;
            this.lbTasksNumber.Location = new System.Drawing.Point(121, 41);
            this.lbTasksNumber.Name = "lbTasksNumber";
            this.lbTasksNumber.Size = new System.Drawing.Size(19, 19);
            this.lbTasksNumber.TabIndex = 2;
            this.lbTasksNumber.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(82, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tasks Number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Check_BoxList.Properties.Resources.to_do_list;
            this.pictureBox2.Location = new System.Drawing.Point(13, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbpnl
            // 
            this.tbpnl.Controls.Add(this.btnSave);
            this.tbpnl.Controls.Add(this.lbInsidetb);
            this.tbpnl.Controls.Add(this.btnCncele);
            this.tbpnl.Controls.Add(this.tbAddTask);
            this.tbpnl.Location = new System.Drawing.Point(529, 63);
            this.tbpnl.Name = "tbpnl";
            this.tbpnl.Size = new System.Drawing.Size(377, 67);
            this.tbpnl.TabIndex = 21;
            this.tbpnl.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 2;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(196, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 35);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbInsidetb
            // 
            this.lbInsidetb.AutoSize = true;
            this.lbInsidetb.BackColor = System.Drawing.Color.Beige;
            this.lbInsidetb.Location = new System.Drawing.Point(3, 21);
            this.lbInsidetb.Name = "lbInsidetb";
            this.lbInsidetb.Size = new System.Drawing.Size(93, 13);
            this.lbInsidetb.TabIndex = 22;
            this.lbInsidetb.Text = "Add a new task...";
            // 
            // btnCncele
            // 
            this.btnCncele.BackColor = System.Drawing.Color.Transparent;
            this.btnCncele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCncele.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCncele.ImageIndex = 6;
            this.btnCncele.ImageList = this.imageList1;
            this.btnCncele.Location = new System.Drawing.Point(282, 18);
            this.btnCncele.Name = "btnCncele";
            this.btnCncele.Size = new System.Drawing.Size(89, 35);
            this.btnCncele.TabIndex = 21;
            this.btnCncele.Text = "Cancel";
            this.btnCncele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCncele.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pcLinkedin);
            this.panel3.Controls.Add(this.pcGithub);
            this.panel3.Location = new System.Drawing.Point(-3, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 76);
            this.panel3.TabIndex = 23;
            // 
            // pcLinkedin
            // 
            this.pcLinkedin.Image = global::Check_BoxList.Properties.Resources.linkedin;
            this.pcLinkedin.Location = new System.Drawing.Point(798, 25);
            this.pcLinkedin.Name = "pcLinkedin";
            this.pcLinkedin.Size = new System.Drawing.Size(55, 48);
            this.pcLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLinkedin.TabIndex = 23;
            this.pcLinkedin.TabStop = false;
            this.pcLinkedin.Click += new System.EventHandler(this.pcLinkedin_Click);
            // 
            // pcGithub
            // 
            this.pcGithub.Image = global::Check_BoxList.Properties.Resources.github;
            this.pcGithub.Location = new System.Drawing.Point(675, 28);
            this.pcGithub.Name = "pcGithub";
            this.pcGithub.Size = new System.Drawing.Size(53, 45);
            this.pcGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcGithub.TabIndex = 22;
            this.pcGithub.TabStop = false;
            this.pcGithub.Click += new System.EventHandler(this.pcGithub_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Check_BoxList.Properties.Resources.reminders__1_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Developed by Anwer El-Sayed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(918, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbpnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbpnl.ResumeLayout(false);
            this.tbpnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnUnSelected;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTasksNumber;
        private System.Windows.Forms.Label lbTaskChecked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel tbpnl;
        private System.Windows.Forms.Button btnCncele;
        private System.Windows.Forms.Label lbInsidetb;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Button btnChected;
        private System.Windows.Forms.PictureBox pcGithub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcLinkedin;
        private System.Windows.Forms.Label label2;
    }
}

