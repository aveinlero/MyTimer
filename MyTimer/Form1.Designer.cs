namespace MyTimer
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
            this.SetTimer = new System.Windows.Forms.TextBox();
            this.GetMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetTimer
            // 
            this.SetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetTimer.Location = new System.Drawing.Point(12, 12);
            this.SetTimer.Name = "SetTimer";
            this.SetTimer.Size = new System.Drawing.Size(156, 29);
            this.SetTimer.TabIndex = 0;
            this.SetTimer.Text = "0";
            this.SetTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GetMessage
            // 
            this.GetMessage.Location = new System.Drawing.Point(12, 47);
            this.GetMessage.Name = "GetMessage";
            this.GetMessage.Size = new System.Drawing.Size(156, 33);
            this.GetMessage.TabIndex = 1;
            this.GetMessage.Text = "Задать таймер";
            this.GetMessage.UseVisualStyleBackColor = true;
            this.GetMessage.Click += new System.EventHandler(this.GetMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 105);
            this.Controls.Add(this.GetMessage);
            this.Controls.Add(this.SetTimer);
            this.Name = "Form1";
            this.Text = "MyTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetTimer;
        private System.Windows.Forms.Button GetMessage;
    }
}

