namespace Production
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
            this.InitialFacts = new System.Windows.Forms.CheckedListBox();
            this.Result = new System.Windows.Forms.ListBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.Finals = new System.Windows.Forms.ListBox();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialFacts
            // 
            this.InitialFacts.FormattingEnabled = true;
            this.InitialFacts.Location = new System.Drawing.Point(12, 81);
            this.InitialFacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitialFacts.Name = "InitialFacts";
            this.InitialFacts.Size = new System.Drawing.Size(239, 556);
            this.InitialFacts.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(648, 12);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(378, 624);
            this.Result.TabIndex = 1;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(1030, 12);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(127, 49);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // Finals
            // 
            this.Finals.FormattingEnabled = true;
            this.Finals.ItemHeight = 20;
            this.Finals.Location = new System.Drawing.Point(258, 12);
            this.Finals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Finals.Name = "Finals";
            this.Finals.Size = new System.Drawing.Size(384, 624);
            this.Finals.TabIndex = 4;
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(1030, 68);
            this.BackwardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(127, 50);
            this.BackwardButton.TabIndex = 5;
            this.BackwardButton.Text = "Backward";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(12, 12);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(239, 62);
            this.SelectAllButton.TabIndex = 6;
            this.SelectAllButton.Text = "Select all";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 651);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.Finals);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InitialFacts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox InitialFacts;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.ListBox Finals;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button SelectAllButton;
    }
}

