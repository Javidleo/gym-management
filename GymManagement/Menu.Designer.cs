namespace GymManagement
{
    partial class Menu
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
            this.UserSignUpButton = new System.Windows.Forms.Button();
            this.DurationRenewButton = new System.Windows.Forms.Button();
            this.TransactionListButton = new System.Windows.Forms.Button();
            this.UserListButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserSignUpButton
            // 
            this.UserSignUpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSignUpButton.Location = new System.Drawing.Point(982, 46);
            this.UserSignUpButton.Name = "UserSignUpButton";
            this.UserSignUpButton.Size = new System.Drawing.Size(186, 63);
            this.UserSignUpButton.TabIndex = 0;
            this.UserSignUpButton.Text = "ثبت نام";
            this.UserSignUpButton.UseVisualStyleBackColor = true;
            // 
            // DurationRenewButton
            // 
            this.DurationRenewButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationRenewButton.Location = new System.Drawing.Point(982, 150);
            this.DurationRenewButton.Name = "DurationRenewButton";
            this.DurationRenewButton.Size = new System.Drawing.Size(186, 63);
            this.DurationRenewButton.TabIndex = 1;
            this.DurationRenewButton.Text = "پرداخت شهریه";
            this.DurationRenewButton.UseVisualStyleBackColor = true;
            // 
            // TransactionListButton
            // 
            this.TransactionListButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionListButton.Location = new System.Drawing.Point(982, 259);
            this.TransactionListButton.Name = "TransactionListButton";
            this.TransactionListButton.Size = new System.Drawing.Size(186, 67);
            this.TransactionListButton.TabIndex = 2;
            this.TransactionListButton.Text = "گزارش مالی";
            this.TransactionListButton.UseVisualStyleBackColor = true;
            // 
            // UserListButton
            // 
            this.UserListButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserListButton.Location = new System.Drawing.Point(982, 382);
            this.UserListButton.Name = "UserListButton";
            this.UserListButton.Size = new System.Drawing.Size(186, 65);
            this.UserListButton.TabIndex = 3;
            this.UserListButton.Text = "لیست افراد";
            this.UserListButton.UseVisualStyleBackColor = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(1, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(951, 562);
            this.MenuPanel.TabIndex = 4;
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(982, 486);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(186, 65);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "خروج";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 563);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.UserListButton);
            this.Controls.Add(this.TransactionListButton);
            this.Controls.Add(this.DurationRenewButton);
            this.Controls.Add(this.UserSignUpButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserSignUpButton;
        private System.Windows.Forms.Button DurationRenewButton;
        private System.Windows.Forms.Button TransactionListButton;
        private System.Windows.Forms.Button UserListButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button QuitButton;
    }
}