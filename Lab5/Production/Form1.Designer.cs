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
            this.CanCookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialFacts
            // 
            this.InitialFacts.FormattingEnabled = true;
            this.InitialFacts.Location = new System.Drawing.Point(12, 13);
            this.InitialFacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitialFacts.Name = "InitialFacts";
            this.InitialFacts.Size = new System.Drawing.Size(239, 625);
            this.InitialFacts.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 20;
            this.Result.Location = new System.Drawing.Point(648, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(377, 624);
            this.Result.TabIndex = 1;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(1031, 13);
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
            this.Finals.Location = new System.Drawing.Point(258, 13);
            this.Finals.Name = "Finals";
            this.Finals.Size = new System.Drawing.Size(384, 624);
            this.Finals.TabIndex = 4;
            this.Finals.SelectedIndexChanged += new System.EventHandler(this.Finals_SelectedIndexChanged);
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(1031, 68);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(127, 50);
            this.BackwardButton.TabIndex = 5;
            this.BackwardButton.Text = "Backward";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // CanCookButton
            // 
            this.CanCookButton.Location = new System.Drawing.Point(1031, 124);
            this.CanCookButton.Name = "CanCookButton";
            this.CanCookButton.Size = new System.Drawing.Size(127, 50);
            this.CanCookButton.TabIndex = 6;
            this.CanCookButton.Text = "Can cook?";
            this.CanCookButton.UseVisualStyleBackColor = true;
            this.CanCookButton.Click += new System.EventHandler(this.CanCookButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 651);
            this.Controls.Add(this.CanCookButton);
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
        private System.Windows.Forms.Button CanCookButton;
    }
}

