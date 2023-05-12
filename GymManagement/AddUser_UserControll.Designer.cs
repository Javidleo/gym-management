using System.Windows.Forms;

namespace GymManagement
{
    partial class AddUser_UserControll : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button UserSignUpButton;
            this.SixMonthCheck = new System.Windows.Forms.CheckBox();
            this.TwoMonthCheck = new System.Windows.Forms.CheckBox();
            this.ThreeMonthCheck = new System.Windows.Forms.CheckBox();
            this.MonthlyCheck = new System.Windows.Forms.CheckBox();
            this.ThreeDaysCheck = new System.Windows.Forms.CheckBox();
            this.EveryDayCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NationalCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FamilyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BirthDateBox = new System.Windows.Forms.PersianDatePicker();
            this.FromNowCheck = new System.Windows.Forms.CheckBox();
            this.FromFinishCheck = new System.Windows.Forms.CheckBox();
            UserSignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserSignUpButton
            // 
            UserSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            UserSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UserSignUpButton.ForeColor = System.Drawing.Color.White;
            UserSignUpButton.Location = new System.Drawing.Point(731, 422);
            UserSignUpButton.Margin = new System.Windows.Forms.Padding(4);
            UserSignUpButton.Name = "UserSignUpButton";
            UserSignUpButton.Size = new System.Drawing.Size(279, 65);
            UserSignUpButton.TabIndex = 11;
            UserSignUpButton.Text = "ثبت نام";
            UserSignUpButton.UseVisualStyleBackColor = false;
            UserSignUpButton.Click += new System.EventHandler(this.UserSignUpButton_Click);
            // 
            // SixMonthCheck
            // 
            this.SixMonthCheck.AutoSize = true;
            this.SixMonthCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixMonthCheck.Location = new System.Drawing.Point(148, 297);
            this.SixMonthCheck.Margin = new System.Windows.Forms.Padding(4);
            this.SixMonthCheck.Name = "SixMonthCheck";
            this.SixMonthCheck.Size = new System.Drawing.Size(96, 29);
            this.SixMonthCheck.TabIndex = 10;
            this.SixMonthCheck.Text = "شش ماهه";
            this.SixMonthCheck.UseVisualStyleBackColor = true;
            // 
            // TwoMonthCheck
            // 
            this.TwoMonthCheck.AutoSize = true;
            this.TwoMonthCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoMonthCheck.Location = new System.Drawing.Point(148, 188);
            this.TwoMonthCheck.Margin = new System.Windows.Forms.Padding(4);
            this.TwoMonthCheck.Name = "TwoMonthCheck";
            this.TwoMonthCheck.Size = new System.Drawing.Size(84, 29);
            this.TwoMonthCheck.TabIndex = 8;
            this.TwoMonthCheck.Text = "دو ماهه";
            this.TwoMonthCheck.UseVisualStyleBackColor = true;
            // 
            // ThreeMonthCheck
            // 
            this.ThreeMonthCheck.AutoSize = true;
            this.ThreeMonthCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeMonthCheck.Location = new System.Drawing.Point(148, 241);
            this.ThreeMonthCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ThreeMonthCheck.Name = "ThreeMonthCheck";
            this.ThreeMonthCheck.Size = new System.Drawing.Size(88, 29);
            this.ThreeMonthCheck.TabIndex = 9;
            this.ThreeMonthCheck.Text = "سه ماهه";
            this.ThreeMonthCheck.UseVisualStyleBackColor = true;
            // 
            // MonthlyCheck
            // 
            this.MonthlyCheck.AutoSize = true;
            this.MonthlyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyCheck.Location = new System.Drawing.Point(148, 136);
            this.MonthlyCheck.Margin = new System.Windows.Forms.Padding(4);
            this.MonthlyCheck.Name = "MonthlyCheck";
            this.MonthlyCheck.Size = new System.Drawing.Size(86, 29);
            this.MonthlyCheck.TabIndex = 7;
            this.MonthlyCheck.Text = "یک ماهه";
            this.MonthlyCheck.UseVisualStyleBackColor = true;
            // 
            // ThreeDaysCheck
            // 
            this.ThreeDaysCheck.AutoSize = true;
            this.ThreeDaysCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeDaysCheck.Location = new System.Drawing.Point(411, 188);
            this.ThreeDaysCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ThreeDaysCheck.Name = "ThreeDaysCheck";
            this.ThreeDaysCheck.Size = new System.Drawing.Size(140, 29);
            this.ThreeDaysCheck.TabIndex = 6;
            this.ThreeDaysCheck.Text = "سه روز در هفته";
            this.ThreeDaysCheck.UseVisualStyleBackColor = true;
            // 
            // EveryDayCheck
            // 
            this.EveryDayCheck.AutoSize = true;
            this.EveryDayCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EveryDayCheck.Location = new System.Drawing.Point(411, 136);
            this.EveryDayCheck.Margin = new System.Windows.Forms.Padding(4);
            this.EveryDayCheck.Name = "EveryDayCheck";
            this.EveryDayCheck.Size = new System.Drawing.Size(118, 29);
            this.EveryDayCheck.TabIndex = 5;
            this.EveryDayCheck.Text = "هر روز هفته";
            this.EveryDayCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1061, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "تاریخ تولد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1061, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "کد ملی";
            // 
            // NationalCodeBox
            // 
            this.NationalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCodeBox.Location = new System.Drawing.Point(707, 259);
            this.NationalCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.NationalCodeBox.MaxLength = 100;
            this.NationalCodeBox.Name = "NationalCodeBox";
            this.NationalCodeBox.ShortcutsEnabled = false;
            this.NationalCodeBox.Size = new System.Drawing.Size(327, 37);
            this.NationalCodeBox.TabIndex = 3;
            this.NationalCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1061, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "نام خانوادگی";
            // 
            // FamilyBox
            // 
            this.FamilyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyBox.Location = new System.Drawing.Point(707, 180);
            this.FamilyBox.Margin = new System.Windows.Forms.Padding(4);
            this.FamilyBox.MaxLength = 100;
            this.FamilyBox.Name = "FamilyBox";
            this.FamilyBox.ShortcutsEnabled = false;
            this.FamilyBox.Size = new System.Drawing.Size(327, 37);
            this.FamilyBox.TabIndex = 2;
            this.FamilyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1061, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "نام";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(707, 105);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.MaxLength = 100;
            this.NameBox.Name = "NameBox";
            this.NameBox.ShortcutsEnabled = false;
            this.NameBox.Size = new System.Drawing.Size(327, 37);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.AutoSize = true;
            this.BirthDateBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BirthDateBox.BackColor = System.Drawing.Color.White;
            this.BirthDateBox.GeorgianDate = null;
            this.BirthDateBox.Location = new System.Drawing.Point(707, 344);
            this.BirthDateBox.Margin = new System.Windows.Forms.Padding(0);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.PersianDate.Day = 0;
            this.BirthDateBox.PersianDate.Month = 0;
            this.BirthDateBox.PersianDate.Year = 0;
            this.BirthDateBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BirthDateBox.Size = new System.Drawing.Size(327, 25);
            this.BirthDateBox.TabIndex = 4;
            // 
            // FromNowCheck
            // 
            this.FromNowCheck.AutoSize = true;
            this.FromNowCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromNowCheck.Location = new System.Drawing.Point(411, 241);
            this.FromNowCheck.Margin = new System.Windows.Forms.Padding(4);
            this.FromNowCheck.Name = "FromNowCheck";
            this.FromNowCheck.Size = new System.Drawing.Size(174, 29);
            this.FromNowCheck.TabIndex = 40;
            this.FromNowCheck.Text = "شروع دوره از امروز";
            this.FromNowCheck.UseVisualStyleBackColor = true;
            this.FromNowCheck.Visible = false;
            // 
            // FromFinishCheck
            // 
            this.FromFinishCheck.AutoSize = true;
            this.FromFinishCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromFinishCheck.Location = new System.Drawing.Point(411, 297);
            this.FromFinishCheck.Margin = new System.Windows.Forms.Padding(4);
            this.FromFinishCheck.Name = "FromFinishCheck";
            this.FromFinishCheck.Size = new System.Drawing.Size(230, 29);
            this.FromFinishCheck.TabIndex = 41;
            this.FromFinishCheck.Text = "شروع دوره از اتمام دوره قبلی";
            this.FromFinishCheck.UseVisualStyleBackColor = true;
            this.FromFinishCheck.Visible = false;
            // 
            // AddUser_UserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(UserSignUpButton);
            this.Controls.Add(this.FromFinishCheck);
            this.Controls.Add(this.FromNowCheck);
            this.Controls.Add(this.BirthDateBox);
            this.Controls.Add(this.SixMonthCheck);
            this.Controls.Add(this.TwoMonthCheck);
            this.Controls.Add(this.ThreeMonthCheck);
            this.Controls.Add(this.MonthlyCheck);
            this.Controls.Add(this.ThreeDaysCheck);
            this.Controls.Add(this.EveryDayCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NationalCodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FamilyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUser_UserControll";
            this.Size = new System.Drawing.Size(1268, 611);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.CheckBox SixMonthCheck;
        private System.Windows.Forms.CheckBox TwoMonthCheck;
        private System.Windows.Forms.CheckBox ThreeMonthCheck;
        private System.Windows.Forms.CheckBox MonthlyCheck;
        private System.Windows.Forms.CheckBox ThreeDaysCheck;
        private System.Windows.Forms.CheckBox EveryDayCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NationalCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FamilyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;

        #endregion

        private System.Windows.Forms.PersianDatePicker BirthDateBox;
        private System.Windows.Forms.CheckBox FromNowCheck;
        private System.Windows.Forms.CheckBox FromFinishCheck;
    }
}
