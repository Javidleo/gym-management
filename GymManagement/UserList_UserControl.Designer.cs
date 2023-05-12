namespace GymManagement
{
    partial class UserList_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.SearchParamBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameCheck = new System.Windows.Forms.CheckBox();
            this.BirthDateCheck = new System.Windows.Forms.CheckBox();
            this.NationalCodeCheck = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExpiredCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGridView
            // 
            this.UserGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserGridView.Location = new System.Drawing.Point(0, 279);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserGridView.RowHeadersWidth = 51;
            this.UserGridView.RowTemplate.Height = 24;
            this.UserGridView.Size = new System.Drawing.Size(1268, 332);
            this.UserGridView.TabIndex = 0;
            this.UserGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGridView_CellContentClick);
            // 
            // SearchParamBox
            // 
            this.SearchParamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchParamBox.Location = new System.Drawing.Point(735, 59);
            this.SearchParamBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchParamBox.MaxLength = 100;
            this.SearchParamBox.Name = "SearchParamBox";
            this.SearchParamBox.ShortcutsEnabled = false;
            this.SearchParamBox.Size = new System.Drawing.Size(327, 37);
            this.SearchParamBox.TabIndex = 1;
            this.SearchParamBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1096, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "پارامتر جستجو";
            // 
            // NameCheck
            // 
            this.NameCheck.AutoSize = true;
            this.NameCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCheck.Location = new System.Drawing.Point(485, 67);
            this.NameCheck.Margin = new System.Windows.Forms.Padding(4);
            this.NameCheck.Name = "NameCheck";
            this.NameCheck.Size = new System.Drawing.Size(112, 29);
            this.NameCheck.TabIndex = 2;
            this.NameCheck.Text = "بر اساس نام";
            this.NameCheck.UseVisualStyleBackColor = true;
            // 
            // BirthDateCheck
            // 
            this.BirthDateCheck.AutoSize = true;
            this.BirthDateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateCheck.Location = new System.Drawing.Point(268, 67);
            this.BirthDateCheck.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDateCheck.Name = "BirthDateCheck";
            this.BirthDateCheck.Size = new System.Drawing.Size(160, 29);
            this.BirthDateCheck.TabIndex = 3;
            this.BirthDateCheck.Text = "بر اساس تاریخ تولد";
            this.BirthDateCheck.UseVisualStyleBackColor = true;
            // 
            // NationalCodeCheck
            // 
            this.NationalCodeCheck.AutoSize = true;
            this.NationalCodeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCodeCheck.Location = new System.Drawing.Point(268, 145);
            this.NationalCodeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.NationalCodeCheck.Name = "NationalCodeCheck";
            this.NationalCodeCheck.Size = new System.Drawing.Size(139, 29);
            this.NationalCodeCheck.TabIndex = 5;
            this.NationalCodeCheck.Text = "بر اساس کد ملی";
            this.NationalCodeCheck.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Location = new System.Drawing.Point(735, 145);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(327, 65);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExpiredCheck
            // 
            this.ExpiredCheck.AutoSize = true;
            this.ExpiredCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredCheck.Location = new System.Drawing.Point(485, 145);
            this.ExpiredCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ExpiredCheck.Name = "ExpiredCheck";
            this.ExpiredCheck.Size = new System.Drawing.Size(129, 29);
            this.ExpiredCheck.TabIndex = 4;
            this.ExpiredCheck.Text = "منقضی شده ها";
            this.ExpiredCheck.UseVisualStyleBackColor = true;
            // 
            // UserList_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExpiredCheck);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NationalCodeCheck);
            this.Controls.Add(this.BirthDateCheck);
            this.Controls.Add(this.NameCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchParamBox);
            this.Controls.Add(this.UserGridView);
            this.DoubleBuffered = true;
            this.Name = "UserList_UserControl";
            this.Size = new System.Drawing.Size(1268, 611);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.TextBox SearchParamBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox NameCheck;
        private System.Windows.Forms.CheckBox BirthDateCheck;
        private System.Windows.Forms.CheckBox NationalCodeCheck;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox ExpiredCheck;
    }
}
