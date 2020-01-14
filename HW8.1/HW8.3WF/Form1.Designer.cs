namespace HW8._3WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfo = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripСopyright = new System.Windows.Forms.ToolStripMenuItem();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip,
            this.toolStripInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.miExit});
            this.ToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ToolStrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ToolStrip.Image")));
            this.ToolStrip.ImageTransparentColor = System.Drawing.Color.GreenYellow;
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RightToLeftAutoMirrorImage = true;
            this.ToolStrip.Size = new System.Drawing.Size(54, 27);
            this.ToolStrip.Text = "File";
            this.ToolStrip.ButtonClick += new System.EventHandler(this.ToolStrip_ButtonClick);
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(216, 28);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(216, 28);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(216, 28);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(216, 28);
            this.miSaveAs.Text = "Save As";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(216, 28);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAuthor,
            this.toolStripVersion,
            this.toolStripСopyright});
            this.toolStripInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInfo.Image")));
            this.toolStripInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(59, 27);
            this.toolStripInfo.Text = "Info";
            this.toolStripInfo.ButtonClick += new System.EventHandler(this.toolStripInfo_ButtonClick);
            // 
            // toolStripAuthor
            // 
            this.toolStripAuthor.Name = "toolStripAuthor";
            this.toolStripAuthor.Size = new System.Drawing.Size(216, 28);
            this.toolStripAuthor.Text = "Author";
            // 
            // toolStripVersion
            // 
            this.toolStripVersion.Name = "toolStripVersion";
            this.toolStripVersion.Size = new System.Drawing.Size(216, 28);
            this.toolStripVersion.Text = "Version";
            // 
            // toolStripСopyright
            // 
            this.toolStripСopyright.Name = "toolStripСopyright";
            this.toolStripСopyright.Size = new System.Drawing.Size(216, 28);
            this.toolStripСopyright.Text = "Сopyright";
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNumber.Location = new System.Drawing.Point(493, 383);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(54, 23);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTrue.Location = new System.Drawing.Point(590, 382);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(79, 21);
            this.cboxTrue.TabIndex = 2;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = true;
            this.cboxTrue.CheckedChanged += new System.EventHandler(this.cboxTrue_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(12, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Location = new System.Drawing.Point(170, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.BackColor = System.Drawing.SystemColors.Info;
            this.btnSaveQuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveQuest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveQuest.Location = new System.Drawing.Point(305, 382);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(119, 44);
            this.btnSaveQuest.TabIndex = 5;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = false;
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 338);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveQuest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveQuest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripAuthor;
        private System.Windows.Forms.ToolStripMenuItem toolStripVersion;
        private System.Windows.Forms.ToolStripMenuItem toolStripСopyright;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripSplitButton ToolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolStripInfo;
    }
}

