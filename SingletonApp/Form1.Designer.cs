namespace SingletonApp
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSaveDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(63, 85);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(179, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSaveDocument
            // 
            this.btnSaveDocument.Location = new System.Drawing.Point(63, 138);
            this.btnSaveDocument.Name = "btnSaveDocument";
            this.btnSaveDocument.Size = new System.Drawing.Size(179, 23);
            this.btnSaveDocument.TabIndex = 1;
            this.btnSaveDocument.Text = "Save Document";
            this.btnSaveDocument.UseVisualStyleBackColor = true;
            this.btnSaveDocument.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveDocument);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSaveDocument;
    }
}

