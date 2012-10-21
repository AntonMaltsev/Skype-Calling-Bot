namespace SkypeCallingBot
{
    partial class MainForm
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
            this.TestBtn = new System.Windows.Forms.Button();
            this.callQueueLabel = new System.Windows.Forms.Label();
            this.numberList = new System.Windows.Forms.ListBox();
            this.StartCallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phonesCount = new System.Windows.Forms.Label();
            this.phonesRefreshBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.callSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(278, 253);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(124, 51);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // callQueueLabel
            // 
            this.callQueueLabel.AutoSize = true;
            this.callQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callQueueLabel.Location = new System.Drawing.Point(37, 19);
            this.callQueueLabel.Name = "callQueueLabel";
            this.callQueueLabel.Size = new System.Drawing.Size(170, 24);
            this.callQueueLabel.TabIndex = 1;
            this.callQueueLabel.Text = "Очередь звонков";
            // 
            // numberList
            // 
            this.numberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberList.FormattingEnabled = true;
            this.numberList.ItemHeight = 16;
            this.numberList.Location = new System.Drawing.Point(9, 59);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(234, 212);
            this.numberList.TabIndex = 2;
            // 
            // StartCallBtn
            // 
            this.StartCallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCallBtn.Location = new System.Drawing.Point(11, 282);
            this.StartCallBtn.Name = "StartCallBtn";
            this.StartCallBtn.Size = new System.Drawing.Size(232, 34);
            this.StartCallBtn.TabIndex = 3;
            this.StartCallBtn.Text = "Начать прозвон";
            this.StartCallBtn.UseVisualStyleBackColor = true;
            this.StartCallBtn.Click += new System.EventHandler(this.StartCallBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Осталось телефонов";
            // 
            // phonesCount
            // 
            this.phonesCount.AutoSize = true;
            this.phonesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonesCount.Location = new System.Drawing.Point(189, 330);
            this.phonesCount.Name = "phonesCount";
            this.phonesCount.Size = new System.Drawing.Size(18, 20);
            this.phonesCount.TabIndex = 5;
            this.phonesCount.Text = "0";
            // 
            // phonesRefreshBtn
            // 
            this.phonesRefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonesRefreshBtn.Location = new System.Drawing.Point(265, 59);
            this.phonesRefreshBtn.Name = "phonesRefreshBtn";
            this.phonesRefreshBtn.Size = new System.Drawing.Size(180, 39);
            this.phonesRefreshBtn.TabIndex = 6;
            this.phonesRefreshBtn.Text = "Обновить список";
            this.phonesRefreshBtn.UseVisualStyleBackColor = true;
            this.phonesRefreshBtn.Click += new System.EventHandler(this.phonesRefreshBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Location = new System.Drawing.Point(265, 104);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(180, 53);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.Text = "Настройки соединений";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // callSettings
            // 
            this.callSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callSettings.Location = new System.Drawing.Point(265, 167);
            this.callSettings.Name = "callSettings";
            this.callSettings.Size = new System.Drawing.Size(179, 58);
            this.callSettings.TabIndex = 8;
            this.callSettings.Text = "Настройки вопросов и ответов";
            this.callSettings.UseVisualStyleBackColor = true;
            this.callSettings.Click += new System.EventHandler(this.callSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 390);
            this.Controls.Add(this.callSettings);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.phonesRefreshBtn);
            this.Controls.Add(this.phonesCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartCallBtn);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.callQueueLabel);
            this.Controls.Add(this.TestBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Label callQueueLabel;
        private System.Windows.Forms.ListBox numberList;
        private System.Windows.Forms.Button StartCallBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phonesCount;
        private System.Windows.Forms.Button phonesRefreshBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button callSettings;
    }
}

