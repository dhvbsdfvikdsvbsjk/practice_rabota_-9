
namespace pr9
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
            this.CreateAsmKeys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptFile = new System.Windows.Forms.Button();
            this.DecryptFile = new System.Windows.Forms.Button();
            this.ExportPublicKey = new System.Windows.Forms.Button();
            this.ImportPublicKey = new System.Windows.Forms.Button();
            this.GetPrivateKey = new System.Windows.Forms.Button();
            this._encryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._decryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // CreateAsmKeys
            // 
            this.CreateAsmKeys.Location = new System.Drawing.Point(218, 110);
            this.CreateAsmKeys.Name = "CreateAsmKeys";
            this.CreateAsmKeys.Size = new System.Drawing.Size(75, 23);
            this.CreateAsmKeys.TabIndex = 0;
            this.CreateAsmKeys.Text = "CreateAsmKeys";
            this.CreateAsmKeys.UseVisualStyleBackColor = true;
            this.CreateAsmKeys.Click += new System.EventHandler(this.CreateAsmKeys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // EncryptFile
            // 
            this.EncryptFile.Location = new System.Drawing.Point(218, 178);
            this.EncryptFile.Name = "EncryptFile";
            this.EncryptFile.Size = new System.Drawing.Size(75, 23);
            this.EncryptFile.TabIndex = 2;
            this.EncryptFile.Text = "EncryptFile";
            this.EncryptFile.UseVisualStyleBackColor = true;
            this.EncryptFile.Click += new System.EventHandler(this.EncryptFile_Click);
            // 
            // DecryptFile
            // 
            this.DecryptFile.Location = new System.Drawing.Point(218, 253);
            this.DecryptFile.Name = "DecryptFile";
            this.DecryptFile.Size = new System.Drawing.Size(75, 23);
            this.DecryptFile.TabIndex = 3;
            this.DecryptFile.Text = "DecryptFile";
            this.DecryptFile.UseVisualStyleBackColor = true;
            this.DecryptFile.Click += new System.EventHandler(this.DecryptFile_Click);
            // 
            // ExportPublicKey
            // 
            this.ExportPublicKey.Location = new System.Drawing.Point(399, 110);
            this.ExportPublicKey.Name = "ExportPublicKey";
            this.ExportPublicKey.Size = new System.Drawing.Size(75, 23);
            this.ExportPublicKey.TabIndex = 4;
            this.ExportPublicKey.Text = "ExportPublicKey";
            this.ExportPublicKey.UseVisualStyleBackColor = true;
            this.ExportPublicKey.Click += new System.EventHandler(this.ExportPublicKey_Click);
            // 
            // ImportPublicKey
            // 
            this.ImportPublicKey.Location = new System.Drawing.Point(399, 178);
            this.ImportPublicKey.Name = "ImportPublicKey";
            this.ImportPublicKey.Size = new System.Drawing.Size(75, 23);
            this.ImportPublicKey.TabIndex = 5;
            this.ImportPublicKey.Text = "ImportPublicKey";
            this.ImportPublicKey.UseVisualStyleBackColor = true;
            this.ImportPublicKey.Click += new System.EventHandler(this.ImportPublicKey_Click);
            // 
            // GetPrivateKey
            // 
            this.GetPrivateKey.Location = new System.Drawing.Point(399, 253);
            this.GetPrivateKey.Name = "GetPrivateKey";
            this.GetPrivateKey.Size = new System.Drawing.Size(75, 23);
            this.GetPrivateKey.TabIndex = 6;
            this.GetPrivateKey.Text = "GetPrivateKey";
            this.GetPrivateKey.UseVisualStyleBackColor = true;
            this.GetPrivateKey.Click += new System.EventHandler(this.GetPrivateKey_Click);
            // 
            // _encryptOpenFileDialog
            // 
            this._encryptOpenFileDialog.FileName = "_encryptOpenFileDialog";
            // 
            // _decryptOpenFileDialog
            // 
            this._decryptOpenFileDialog.FileName = "_decryptOpenFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetPrivateKey);
            this.Controls.Add(this.ImportPublicKey);
            this.Controls.Add(this.ExportPublicKey);
            this.Controls.Add(this.DecryptFile);
            this.Controls.Add(this.EncryptFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAsmKeys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAsmKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptFile;
        private System.Windows.Forms.Button DecryptFile;
        private System.Windows.Forms.Button ExportPublicKey;
        private System.Windows.Forms.Button ImportPublicKey;
        private System.Windows.Forms.Button GetPrivateKey;
        private System.Windows.Forms.OpenFileDialog _encryptOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog _decryptOpenFileDialog;
    }
}

