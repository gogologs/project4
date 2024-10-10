namespace Лаба_4
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
            this.label8 = new System.Windows.Forms.Label();
            this.deshifr2 = new System.Windows.Forms.Button();
            this.decrypt_error = new System.Windows.Forms.Label();
            this.decrypt_text = new System.Windows.Forms.Label();
            this.xor_error = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crypt_text = new System.Windows.Forms.Label();
            this.input_error = new System.Windows.Forms.Label();
            this.key_error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.eng = new System.Windows.Forms.CheckBox();
            this.rus = new System.Windows.Forms.CheckBox();
            this.shifr = new System.Windows.Forms.Button();
            this.key_text = new System.Windows.Forms.TextBox();
            this.input_binary = new System.Windows.Forms.Label();
            this.key_binary = new System.Windows.Forms.Label();
            this.key_bin_but = new System.Windows.Forms.Button();
            this.input_bin_but = new System.Windows.Forms.Button();
            this.input_text = new System.Windows.Forms.TextBox();
            this.decrypt_nonbin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(-77, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Взлом:";
            // 
            // deshifr2
            // 
            this.deshifr2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deshifr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deshifr2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deshifr2.ForeColor = System.Drawing.Color.Lime;
            this.deshifr2.Location = new System.Drawing.Point(12, 561);
            this.deshifr2.Name = "deshifr2";
            this.deshifr2.Size = new System.Drawing.Size(194, 39);
            this.deshifr2.TabIndex = 56;
            this.deshifr2.Text = "Расшифровать";
            this.deshifr2.UseVisualStyleBackColor = false;
            this.deshifr2.Click += new System.EventHandler(this.deshifr2_Click);
            // 
            // decrypt_error
            // 
            this.decrypt_error.AutoSize = true;
            this.decrypt_error.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_error.ForeColor = System.Drawing.Color.Red;
            this.decrypt_error.Location = new System.Drawing.Point(216, 580);
            this.decrypt_error.Name = "decrypt_error";
            this.decrypt_error.Size = new System.Drawing.Size(233, 17);
            this.decrypt_error.TabIndex = 53;
            this.decrypt_error.Text = "Нет зашифрованного текста";
            this.decrypt_error.Visible = false;
            // 
            // decrypt_text
            // 
            this.decrypt_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decrypt_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decrypt_text.ForeColor = System.Drawing.Color.Lime;
            this.decrypt_text.Location = new System.Drawing.Point(12, 603);
            this.decrypt_text.Name = "decrypt_text";
            this.decrypt_text.Size = new System.Drawing.Size(1355, 44);
            this.decrypt_text.TabIndex = 52;
            // 
            // xor_error
            // 
            this.xor_error.AutoSize = true;
            this.xor_error.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xor_error.ForeColor = System.Drawing.Color.Red;
            this.xor_error.Location = new System.Drawing.Point(216, 426);
            this.xor_error.Name = "xor_error";
            this.xor_error.Size = new System.Drawing.Size(215, 17);
            this.xor_error.TabIndex = 51;
            this.xor_error.Text = "Ошибка текста или ключа";
            this.xor_error.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Введите ваш текст:";
            // 
            // crypt_text
            // 
            this.crypt_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crypt_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crypt_text.ForeColor = System.Drawing.Color.Lime;
            this.crypt_text.Location = new System.Drawing.Point(12, 446);
            this.crypt_text.Name = "crypt_text";
            this.crypt_text.Size = new System.Drawing.Size(1355, 109);
            this.crypt_text.TabIndex = 49;
            // 
            // input_error
            // 
            this.input_error.AutoSize = true;
            this.input_error.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_error.ForeColor = System.Drawing.Color.Red;
            this.input_error.Location = new System.Drawing.Point(216, 122);
            this.input_error.Name = "input_error";
            this.input_error.Size = new System.Drawing.Size(314, 17);
            this.input_error.TabIndex = 48;
            this.input_error.Text = "Вводите только на выбранном языке!";
            this.input_error.Visible = false;
            // 
            // key_error
            // 
            this.key_error.AutoSize = true;
            this.key_error.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_error.ForeColor = System.Drawing.Color.Red;
            this.key_error.Location = new System.Drawing.Point(216, 301);
            this.key_error.Name = "key_error";
            this.key_error.Size = new System.Drawing.Size(116, 17);
            this.key_error.TabIndex = 47;
            this.key_error.Text = "Ошибка ввода";
            this.key_error.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(9, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ключ (слово):";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Lime;
            this.title.Location = new System.Drawing.Point(13, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1265, 26);
            this.title.TabIndex = 45;
            this.title.Text = "Приветствуем! Программа посвящена шифру XOR. Выберите язык, введите текст, ключ и" +
    " выберите нужную опцию.\r\n";
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eng.ForeColor = System.Drawing.Color.Lime;
            this.eng.Location = new System.Drawing.Point(115, 76);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(120, 21);
            this.eng.TabIndex = 44;
            this.eng.Text = "английский";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.eng_CheckedChanged);
            // 
            // rus
            // 
            this.rus.AutoSize = true;
            this.rus.Checked = true;
            this.rus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rus.ForeColor = System.Drawing.Color.Lime;
            this.rus.Location = new System.Drawing.Point(16, 76);
            this.rus.Name = "rus";
            this.rus.Size = new System.Drawing.Size(93, 21);
            this.rus.TabIndex = 43;
            this.rus.Text = "русский";
            this.rus.UseVisualStyleBackColor = true;
            this.rus.CheckedChanged += new System.EventHandler(this.rus_CheckedChanged);
            // 
            // shifr
            // 
            this.shifr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shifr.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr.ForeColor = System.Drawing.Color.Lime;
            this.shifr.Location = new System.Drawing.Point(12, 404);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(194, 39);
            this.shifr.TabIndex = 41;
            this.shifr.Text = "Зашифровать (XOR)";
            this.shifr.UseVisualStyleBackColor = true;
            this.shifr.Click += new System.EventHandler(this.shifr_Click);
            // 
            // key_text
            // 
            this.key_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.key_text.ForeColor = System.Drawing.Color.Lime;
            this.key_text.Location = new System.Drawing.Point(12, 321);
            this.key_text.Name = "key_text";
            this.key_text.Size = new System.Drawing.Size(1355, 22);
            this.key_text.TabIndex = 40;
            this.key_text.TextChanged += new System.EventHandler(this.key_text_TextChanged);
            // 
            // input_binary
            // 
            this.input_binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_binary.ForeColor = System.Drawing.Color.Lime;
            this.input_binary.Location = new System.Drawing.Point(12, 237);
            this.input_binary.Name = "input_binary";
            this.input_binary.Size = new System.Drawing.Size(1355, 55);
            this.input_binary.TabIndex = 64;
            // 
            // key_binary
            // 
            this.key_binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.key_binary.ForeColor = System.Drawing.Color.Lime;
            this.key_binary.Location = new System.Drawing.Point(12, 380);
            this.key_binary.Name = "key_binary";
            this.key_binary.Size = new System.Drawing.Size(1355, 21);
            this.key_binary.TabIndex = 65;
            // 
            // key_bin_but
            // 
            this.key_bin_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key_bin_but.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_bin_but.ForeColor = System.Drawing.Color.Lime;
            this.key_bin_but.Location = new System.Drawing.Point(12, 349);
            this.key_bin_but.Name = "key_bin_but";
            this.key_bin_but.Size = new System.Drawing.Size(315, 28);
            this.key_bin_but.TabIndex = 66;
            this.key_bin_but.Text = "двоичное представление ключа";
            this.key_bin_but.UseVisualStyleBackColor = true;
            this.key_bin_but.Click += new System.EventHandler(this.key_bin_but_Click);
            // 
            // input_bin_but
            // 
            this.input_bin_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_bin_but.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_bin_but.ForeColor = System.Drawing.Color.Lime;
            this.input_bin_but.Location = new System.Drawing.Point(12, 206);
            this.input_bin_but.Name = "input_bin_but";
            this.input_bin_but.Size = new System.Drawing.Size(315, 28);
            this.input_bin_but.TabIndex = 67;
            this.input_bin_but.Text = "двоичное представление текста\r\n";
            this.input_bin_but.UseVisualStyleBackColor = true;
            this.input_bin_but.Click += new System.EventHandler(this.input_bin_but_Click);
            // 
            // input_text
            // 
            this.input_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_text.ForeColor = System.Drawing.Color.Lime;
            this.input_text.Location = new System.Drawing.Point(12, 141);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(1355, 59);
            this.input_text.TabIndex = 68;
            this.input_text.TextChanged += new System.EventHandler(this.input_text_TextChanged);
            // 
            // decrypt_nonbin
            // 
            this.decrypt_nonbin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decrypt_nonbin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decrypt_nonbin.ForeColor = System.Drawing.Color.Lime;
            this.decrypt_nonbin.Location = new System.Drawing.Point(12, 656);
            this.decrypt_nonbin.Name = "decrypt_nonbin";
            this.decrypt_nonbin.Size = new System.Drawing.Size(1355, 44);
            this.decrypt_nonbin.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1384, 725);
            this.Controls.Add(this.decrypt_nonbin);
            this.Controls.Add(this.input_text);
            this.Controls.Add(this.input_bin_but);
            this.Controls.Add(this.key_bin_but);
            this.Controls.Add(this.key_binary);
            this.Controls.Add(this.input_binary);
            this.Controls.Add(this.deshifr2);
            this.Controls.Add(this.decrypt_error);
            this.Controls.Add(this.decrypt_text);
            this.Controls.Add(this.xor_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crypt_text);
            this.Controls.Add(this.input_error);
            this.Controls.Add(this.key_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eng);
            this.Controls.Add(this.rus);
            this.Controls.Add(this.shifr);
            this.Controls.Add(this.key_text);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deshifr2;
        private System.Windows.Forms.Label decrypt_error;
        private System.Windows.Forms.Label decrypt_text;
        private System.Windows.Forms.Label xor_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label crypt_text;
        private System.Windows.Forms.Label input_error;
        private System.Windows.Forms.Label key_error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox eng;
        private System.Windows.Forms.CheckBox rus;
        private System.Windows.Forms.Button shifr;
        private System.Windows.Forms.TextBox key_text;
        private System.Windows.Forms.Label input_binary;
        private System.Windows.Forms.Label key_binary;
        private System.Windows.Forms.Button key_bin_but;
        private System.Windows.Forms.Button input_bin_but;
        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Label decrypt_nonbin;
    }
}

