namespace SkypeCallingBot
{
    partial class SettingsForm
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
            this.SaveFilesForm = new System.Windows.Forms.GroupBox();
            this.isSaveResponseFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFolder = new System.Windows.Forms.TextBox();
            this.chooseFolderBtn = new System.Windows.Forms.Button();
            this.skypeSettings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skypeLogin = new System.Windows.Forms.TextBox();
            this.skypePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbSettings = new System.Windows.Forms.GroupBox();
            this.dbUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbUserLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveFilesForm.SuspendLayout();
            this.skypeSettings.SuspendLayout();
            this.dbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveFilesForm
            // 
            this.SaveFilesForm.Controls.Add(this.chooseFolderBtn);
            this.SaveFilesForm.Controls.Add(this.saveFolder);
            this.SaveFilesForm.Controls.Add(this.label1);
            this.SaveFilesForm.Controls.Add(this.isSaveResponseFiles);
            this.SaveFilesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFilesForm.Location = new System.Drawing.Point(16, 15);
            this.SaveFilesForm.Name = "SaveFilesForm";
            this.SaveFilesForm.Size = new System.Drawing.Size(500, 96);
            this.SaveFilesForm.TabIndex = 0;
            this.SaveFilesForm.TabStop = false;
            this.SaveFilesForm.Text = "Сохраниние файлов ответов";
            // 
            // isSaveResponseFiles
            // 
            this.isSaveResponseFiles.AutoSize = true;
            this.isSaveResponseFiles.Location = new System.Drawing.Point(8, 31);
            this.isSaveResponseFiles.Name = "isSaveResponseFiles";
            this.isSaveResponseFiles.Size = new System.Drawing.Size(279, 21);
            this.isSaveResponseFiles.TabIndex = 0;
            this.isSaveResponseFiles.Text = "Сохранять файлы с записями ответов";
            this.isSaveResponseFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка для сохранения";
            // 
            // saveFolder
            // 
            this.saveFolder.Location = new System.Drawing.Point(174, 64);
            this.saveFolder.Name = "saveFolder";
            this.saveFolder.Size = new System.Drawing.Size(219, 23);
            this.saveFolder.TabIndex = 2;
            // 
            // chooseFolderBtn
            // 
            this.chooseFolderBtn.Location = new System.Drawing.Point(407, 63);
            this.chooseFolderBtn.Name = "chooseFolderBtn";
            this.chooseFolderBtn.Size = new System.Drawing.Size(79, 24);
            this.chooseFolderBtn.TabIndex = 3;
            this.chooseFolderBtn.Text = "Выбрать";
            this.chooseFolderBtn.UseVisualStyleBackColor = true;
            // 
            // skypeSettings
            // 
            this.skypeSettings.Controls.Add(this.skypePassword);
            this.skypeSettings.Controls.Add(this.label3);
            this.skypeSettings.Controls.Add(this.skypeLogin);
            this.skypeSettings.Controls.Add(this.label2);
            this.skypeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skypeSettings.Location = new System.Drawing.Point(17, 123);
            this.skypeSettings.Name = "skypeSettings";
            this.skypeSettings.Size = new System.Drawing.Size(498, 94);
            this.skypeSettings.TabIndex = 1;
            this.skypeSettings.TabStop = false;
            this.skypeSettings.Text = "Настройки Skype";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
            // 
            // skypeLogin
            // 
            this.skypeLogin.Location = new System.Drawing.Point(71, 27);
            this.skypeLogin.Name = "skypeLogin";
            this.skypeLogin.Size = new System.Drawing.Size(167, 23);
            this.skypeLogin.TabIndex = 1;
            // 
            // skypePassword
            // 
            this.skypePassword.Location = new System.Drawing.Point(71, 56);
            this.skypePassword.Name = "skypePassword";
            this.skypePassword.Size = new System.Drawing.Size(167, 23);
            this.skypePassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // dbSettings
            // 
            this.dbSettings.Controls.Add(this.dbIP);
            this.dbSettings.Controls.Add(this.label7);
            this.dbSettings.Controls.Add(this.dbName);
            this.dbSettings.Controls.Add(this.label6);
            this.dbSettings.Controls.Add(this.dbUserPassword);
            this.dbSettings.Controls.Add(this.label4);
            this.dbSettings.Controls.Add(this.dbUserLogin);
            this.dbSettings.Controls.Add(this.label5);
            this.dbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbSettings.Location = new System.Drawing.Point(18, 223);
            this.dbSettings.Name = "dbSettings";
            this.dbSettings.Size = new System.Drawing.Size(498, 153);
            this.dbSettings.TabIndex = 2;
            this.dbSettings.TabStop = false;
            this.dbSettings.Text = "Настройки Базы Данных";
            // 
            // dbUserPassword
            // 
            this.dbUserPassword.Location = new System.Drawing.Point(71, 56);
            this.dbUserPassword.Name = "dbUserPassword";
            this.dbUserPassword.Size = new System.Drawing.Size(167, 23);
            this.dbUserPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Пароль";
            // 
            // dbUserLogin
            // 
            this.dbUserLogin.Location = new System.Drawing.Point(71, 27);
            this.dbUserLogin.Name = "dbUserLogin";
            this.dbUserLogin.Size = new System.Drawing.Size(167, 23);
            this.dbUserLogin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Логин";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(112, 85);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(167, 23);
            this.dbName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Название БД";
            // 
            // dbIP
            // 
            this.dbIP.Location = new System.Drawing.Point(71, 114);
            this.dbIP.Name = "dbIP";
            this.dbIP.Size = new System.Drawing.Size(167, 23);
            this.dbIP.TabIndex = 7;
            this.dbIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "IP БД";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 382);
            this.Controls.Add(this.dbSettings);
            this.Controls.Add(this.skypeSettings);
            this.Controls.Add(this.SaveFilesForm);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.SaveFilesForm.ResumeLayout(false);
            this.SaveFilesForm.PerformLayout();
            this.skypeSettings.ResumeLayout(false);
            this.skypeSettings.PerformLayout();
            this.dbSettings.ResumeLayout(false);
            this.dbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveFilesForm;
        private System.Windows.Forms.Button chooseFolderBtn;
        private System.Windows.Forms.TextBox saveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isSaveResponseFiles;
        private System.Windows.Forms.GroupBox skypeSettings;
        private System.Windows.Forms.TextBox skypeLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skypePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox dbSettings;
        private System.Windows.Forms.TextBox dbIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dbUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbUserLogin;
        private System.Windows.Forms.Label label5;
    }
}