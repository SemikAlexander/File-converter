namespace FileConverter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.browseFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.Button();
            this.ConvertFilePath = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File converter";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FileConverter.Properties.Resources.hideWindow;
            this.button2.Location = new System.Drawing.Point(383, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FileConverter.Properties.Resources.closeWindow;
            this.button1.Location = new System.Drawing.Point(424, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(12, 52);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FilePath.Size = new System.Drawing.Size(364, 25);
            this.FilePath.TabIndex = 1;
            // 
            // browseFiles
            // 
            this.browseFiles.FlatAppearance.BorderSize = 0;
            this.browseFiles.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFiles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseFiles.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.browseFiles.Location = new System.Drawing.Point(382, 52);
            this.browseFiles.Name = "browseFiles";
            this.browseFiles.Size = new System.Drawing.Size(77, 25);
            this.browseFiles.TabIndex = 2;
            this.browseFiles.Text = "Browse";
            this.browseFiles.UseVisualStyleBackColor = true;
            this.browseFiles.Click += new System.EventHandler(this.browseFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.FlatAppearance.BorderSize = 0;
            this.saveFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveFile.Location = new System.Drawing.Point(383, 80);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(77, 25);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ConvertFilePath
            // 
            this.ConvertFilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertFilePath.Location = new System.Drawing.Point(12, 80);
            this.ConvertFilePath.Multiline = true;
            this.ConvertFilePath.Name = "ConvertFilePath";
            this.ConvertFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ConvertFilePath.Size = new System.Drawing.Size(364, 25);
            this.ConvertFilePath.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(123, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Convert file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(464, 146);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ConvertFilePath);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.browseFiles);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button browseFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.TextBox ConvertFilePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}

