namespace Cinema
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
            this.txtQueue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQueue
            // 
            this.txtQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQueue.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtQueue.ForeColor = System.Drawing.Color.White;
            this.txtQueue.Location = new System.Drawing.Point(23, 166);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.ReadOnly = true;
            this.txtQueue.Size = new System.Drawing.Size(158, 237);
            this.txtQueue.TabIndex = 0;
            this.txtQueue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Очередь:";
            // 
            // btnRefill
            // 
            this.btnRefill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefill.Location = new System.Drawing.Point(23, 77);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(405, 43);
            this.btnRefill.TabIndex = 2;
            this.btnRefill.Text = "Пересобрать";
            this.btnRefill.UseVisualStyleBackColor = false;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtName.Location = new System.Drawing.Point(192, 166);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtName.Size = new System.Drawing.Size(236, 42);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(192, 215);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(236, 91);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "Нажмите кнопку \"Пересобрать\", чтобы заполнить список фильмов";
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGet.Location = new System.Drawing.Point(192, 313);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(236, 90);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "Смотреть";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(136, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кино";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(221, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ваш выбор:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(447, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQueue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Раздача кино";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

