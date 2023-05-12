namespace GymManagement
{
    partial class AdminForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FamilyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NationalCodeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDateBox = new System.Windows.Forms.PersianDatePicker();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(562, 84);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.ShortcutsEnabled = false;
            this.NameBox.Size = new System.Drawing.Size(333, 30);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(907, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(907, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام خانوادگی";
            // 
            // FamilyBox
            // 
            this.FamilyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyBox.Location = new System.Drawing.Point(562, 142);
            this.FamilyBox.Margin = new System.Windows.Forms.Padding(4);
            this.FamilyBox.MaxLength = 100;
            this.FamilyBox.Name = "FamilyBox";
            this.FamilyBox.ShortcutsEnabled = false;
            this.FamilyBox.Size = new System.Drawing.Size(333, 30);
            this.FamilyBox.TabIndex = 2;
            this.FamilyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(907, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "تاریخ تولد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(907, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "کدملی";
            // 
            // NationalCodeBox
            // 
            this.NationalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCodeBox.Location = new System.Drawing.Point(562, 271);
            this.NationalCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.NationalCodeBox.MaxLength = 100;
            this.NationalCodeBox.Name = "NationalCodeBox";
            this.NationalCodeBox.ShortcutsEnabled = false;
            this.NationalCodeBox.Size = new System.Drawing.Size(333, 30);
            this.NationalCodeBox.TabIndex = 4;
            this.NationalCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(441, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "نام کاربری";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(441, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "رمز عبور";
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.AutoSize = true;
            this.BirthDateBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BirthDateBox.BackColor = System.Drawing.Color.White;
            this.BirthDateBox.GeorgianDate = null;
            this.BirthDateBox.Location = new System.Drawing.Point(562, 215);
            this.BirthDateBox.Margin = new System.Windows.Forms.Padding(0);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.PersianDate.Day = 0;
            this.BirthDateBox.PersianDate.Month = 0;
            this.BirthDateBox.PersianDate.Year = 0;
            this.BirthDateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BirthDateBox.Size = new System.Drawing.Size(327, 25);
            this.BirthDateBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(100, 148);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.MaxLength = 100;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.ShortcutsEnabled = false;
            this.PasswordBox.Size = new System.Drawing.Size(333, 30);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(100, 84);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameBox.MaxLength = 100;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.ShortcutsEnabled = false;
            this.UserNameBox.Size = new System.Drawing.Size(333, 30);
            this.UserNameBox.TabIndex = 5;
            this.UserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(100, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "ثبت نام";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1005, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.BirthDateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NationalCodeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FamilyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FamilyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NationalCodeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PersianDatePicker BirthDateBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button button1;
    }
}