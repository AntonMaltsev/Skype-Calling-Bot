namespace SkypeCallingBot
{
    partial class CallSettingsForm
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
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.callFileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.affirmativeForm = new System.Windows.Forms.GroupBox();
            this.SaveFilesForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveFilesForm
            // 
            this.SaveFilesForm.Controls.Add(this.chooseFileBtn);
            this.SaveFilesForm.Controls.Add(this.callFileTxt);
            this.SaveFilesForm.Controls.Add(this.label1);
            this.SaveFilesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFilesForm.Location = new System.Drawing.Point(12, 12);
            this.SaveFilesForm.Name = "SaveFilesForm";
            this.SaveFilesForm.Size = new System.Drawing.Size(528, 71);
            this.SaveFilesForm.TabIndex = 1;
            this.SaveFilesForm.TabStop = false;
            this.SaveFilesForm.Text = "Файл вопроса";
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(436, 29);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(79, 24);
            this.chooseFileBtn.TabIndex = 3;
            this.chooseFileBtn.Text = "Выбрать";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            // 
            // callFileTxt
            // 
            this.callFileTxt.Location = new System.Drawing.Point(183, 30);
            this.callFileTxt.Name = "callFileTxt";
            this.callFileTxt.Size = new System.Drawing.Size(236, 23);
            this.callFileTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл со звуком вопроса";
            // 
            // affirmativeForm
            // 
            this.affirmativeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.affirmativeForm.Location = new System.Drawing.Point(15, 94);
            this.affirmativeForm.Name = "affirmativeForm";
            this.affirmativeForm.Size = new System.Drawing.Size(524, 153);
            this.affirmativeForm.TabIndex = 2;
            this.affirmativeForm.TabStop = false;
            this.affirmativeForm.Text = "Утвердительные ответы";
            // 
            // CallSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.affirmativeForm);
            this.Controls.Add(this.SaveFilesForm);
            this.Name = "CallSettingsForm";
            this.Text = "CallSettingsForm";
            this.SaveFilesForm.ResumeLayout(false);
            this.SaveFilesForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveFilesForm;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox callFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox affirmativeForm;
    }
}