namespace HW7._1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnCancelMove = new System.Windows.Forms.Button();
            this.lblRandow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(485, 60);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(183, 39);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "btnCommand1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(485, 135);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(183, 34);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "btnCommand2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(485, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(66, 63);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "lblNumber";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(66, 111);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(59, 17);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "lblCount";
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.SystemColors.Info;
            this.btnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGame.Location = new System.Drawing.Point(69, 13);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(157, 35);
            this.btnGame.TabIndex = 5;
            this.btnGame.Text = "btnGame";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnCancelMove
            // 
            this.btnCancelMove.Location = new System.Drawing.Point(485, 199);
            this.btnCancelMove.Name = "btnCancelMove";
            this.btnCancelMove.Size = new System.Drawing.Size(183, 35);
            this.btnCancelMove.TabIndex = 6;
            this.btnCancelMove.Text = "btnCancelMove";
            this.btnCancelMove.UseVisualStyleBackColor = true;
            this.btnCancelMove.Click += new System.EventHandler(this.btnCancelMove_Click);
            // 
            // lblRandow
            // 
            this.lblRandow.AutoSize = true;
            this.lblRandow.Location = new System.Drawing.Point(69, 375);
            this.lblRandow.Name = "lblRandow";
            this.lblRandow.Size = new System.Drawing.Size(73, 17);
            this.lblRandow.TabIndex = 7;
            this.lblRandow.Text = "lblRandow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRandow);
            this.Controls.Add(this.btnCancelMove);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnCancelMove;
        private System.Windows.Forms.Label lblRandow;
    }
}

