namespace BookClass
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
            this.button_AddBook = new System.Windows.Forms.Button();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label_Author = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Language = new System.Windows.Forms.TextBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.textBox_YearPublication = new System.Windows.Forms.TextBox();
            this.label_YearPublication = new System.Windows.Forms.Label();
            this.textBox_Binding = new System.Windows.Forms.TextBox();
            this.label_Binding = new System.Windows.Forms.Label();
            this.textBox_NumberPages = new System.Windows.Forms.TextBox();
            this.label_NumberPages = new System.Windows.Forms.Label();
            this.textBox_TitleMore = new System.Windows.Forms.TextBox();
            this.label_TitleMore = new System.Windows.Forms.Label();
            this.button_More = new System.Windows.Forms.Button();
            this.textBox_More = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddBook
            // 
            this.button_AddBook.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddBook.Location = new System.Drawing.Point(16, 228);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(407, 37);
            this.button_AddBook.TabIndex = 12;
            this.button_AddBook.Text = "Добавить книгу";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // textBox_Author
            // 
            this.textBox_Author.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Author.Location = new System.Drawing.Point(193, 6);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(230, 29);
            this.textBox_Author.TabIndex = 11;
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Author.Location = new System.Drawing.Point(12, 9);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(60, 21);
            this.label_Author.TabIndex = 10;
            this.label_Author.Text = "Автор";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Title.Location = new System.Drawing.Point(193, 41);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(230, 29);
            this.textBox_Title.TabIndex = 14;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(12, 44);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(84, 21);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "Название";
            // 
            // textBox_Language
            // 
            this.textBox_Language.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Language.Location = new System.Drawing.Point(193, 76);
            this.textBox_Language.Name = "textBox_Language";
            this.textBox_Language.Size = new System.Drawing.Size(230, 29);
            this.textBox_Language.TabIndex = 16;
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Language.Location = new System.Drawing.Point(12, 79);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(53, 21);
            this.label_Language.TabIndex = 15;
            this.label_Language.Text = "Язык";
            // 
            // textBox_YearPublication
            // 
            this.textBox_YearPublication.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_YearPublication.Location = new System.Drawing.Point(193, 111);
            this.textBox_YearPublication.Name = "textBox_YearPublication";
            this.textBox_YearPublication.Size = new System.Drawing.Size(230, 29);
            this.textBox_YearPublication.TabIndex = 18;
            // 
            // label_YearPublication
            // 
            this.label_YearPublication.AutoSize = true;
            this.label_YearPublication.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_YearPublication.Location = new System.Drawing.Point(12, 114);
            this.label_YearPublication.Name = "label_YearPublication";
            this.label_YearPublication.Size = new System.Drawing.Size(108, 21);
            this.label_YearPublication.TabIndex = 17;
            this.label_YearPublication.Text = "Год издания";
            // 
            // textBox_Binding
            // 
            this.textBox_Binding.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Binding.Location = new System.Drawing.Point(193, 146);
            this.textBox_Binding.Name = "textBox_Binding";
            this.textBox_Binding.Size = new System.Drawing.Size(230, 29);
            this.textBox_Binding.TabIndex = 20;
            // 
            // label_Binding
            // 
            this.label_Binding.AutoSize = true;
            this.label_Binding.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Binding.Location = new System.Drawing.Point(12, 149);
            this.label_Binding.Name = "label_Binding";
            this.label_Binding.Size = new System.Drawing.Size(84, 21);
            this.label_Binding.TabIndex = 19;
            this.label_Binding.Text = "Переплёт";
            // 
            // textBox_NumberPages
            // 
            this.textBox_NumberPages.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_NumberPages.Location = new System.Drawing.Point(193, 181);
            this.textBox_NumberPages.Name = "textBox_NumberPages";
            this.textBox_NumberPages.Size = new System.Drawing.Size(230, 29);
            this.textBox_NumberPages.TabIndex = 22;
            // 
            // label_NumberPages
            // 
            this.label_NumberPages.AutoSize = true;
            this.label_NumberPages.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberPages.Location = new System.Drawing.Point(12, 184);
            this.label_NumberPages.Name = "label_NumberPages";
            this.label_NumberPages.Size = new System.Drawing.Size(175, 21);
            this.label_NumberPages.TabIndex = 21;
            this.label_NumberPages.Text = "Количество страниц";
            // 
            // textBox_TitleMore
            // 
            this.textBox_TitleMore.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TitleMore.Location = new System.Drawing.Point(672, 1);
            this.textBox_TitleMore.Name = "textBox_TitleMore";
            this.textBox_TitleMore.Size = new System.Drawing.Size(230, 29);
            this.textBox_TitleMore.TabIndex = 25;
            // 
            // label_TitleMore
            // 
            this.label_TitleMore.AutoSize = true;
            this.label_TitleMore.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleMore.Location = new System.Drawing.Point(582, 4);
            this.label_TitleMore.Name = "label_TitleMore";
            this.label_TitleMore.Size = new System.Drawing.Size(84, 21);
            this.label_TitleMore.TabIndex = 24;
            this.label_TitleMore.Text = "Название";
            // 
            // button_More
            // 
            this.button_More.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_More.Location = new System.Drawing.Point(586, 36);
            this.button_More.Name = "button_More";
            this.button_More.Size = new System.Drawing.Size(316, 37);
            this.button_More.TabIndex = 23;
            this.button_More.Text = "Подробнее о книге";
            this.button_More.UseVisualStyleBackColor = true;
            this.button_More.Click += new System.EventHandler(this.button_More_Click);
            // 
            // textBox_More
            // 
            this.textBox_More.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_More.Location = new System.Drawing.Point(516, 79);
            this.textBox_More.Multiline = true;
            this.textBox_More.Name = "textBox_More";
            this.textBox_More.Size = new System.Drawing.Size(456, 211);
            this.textBox_More.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 326);
            this.Controls.Add(this.textBox_More);
            this.Controls.Add(this.textBox_TitleMore);
            this.Controls.Add(this.label_TitleMore);
            this.Controls.Add(this.button_More);
            this.Controls.Add(this.textBox_NumberPages);
            this.Controls.Add(this.label_NumberPages);
            this.Controls.Add(this.textBox_Binding);
            this.Controls.Add(this.label_Binding);
            this.Controls.Add(this.textBox_YearPublication);
            this.Controls.Add(this.label_YearPublication);
            this.Controls.Add(this.textBox_Language);
            this.Controls.Add(this.label_Language);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_AddBook);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label_Author);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Language;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.TextBox textBox_YearPublication;
        private System.Windows.Forms.Label label_YearPublication;
        private System.Windows.Forms.TextBox textBox_Binding;
        private System.Windows.Forms.Label label_Binding;
        private System.Windows.Forms.TextBox textBox_NumberPages;
        private System.Windows.Forms.Label label_NumberPages;
        private System.Windows.Forms.TextBox textBox_TitleMore;
        private System.Windows.Forms.Label label_TitleMore;
        private System.Windows.Forms.Button button_More;
        private System.Windows.Forms.TextBox textBox_More;
    }
}

