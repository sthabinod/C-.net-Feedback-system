namespace Login_Form
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.inputPassword = new ns1.BunifuTextbox();
            this.inputPasswordAgain = new ns1.BunifuTextbox();
            this.btnChangePassword = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.Silver;
            this.inputPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputPassword.BackgroundImage")));
            this.inputPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.inputPassword.Icon = ((System.Drawing.Image)(resources.GetObject("inputPassword.Icon")));
            this.inputPassword.Location = new System.Drawing.Point(103, 44);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(250, 42);
            this.inputPassword.TabIndex = 0;
            this.inputPassword.text = "";
            // 
            // inputPasswordAgain
            // 
            this.inputPasswordAgain.BackColor = System.Drawing.Color.Silver;
            this.inputPasswordAgain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputPasswordAgain.BackgroundImage")));
            this.inputPasswordAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputPasswordAgain.ForeColor = System.Drawing.Color.SeaGreen;
            this.inputPasswordAgain.Icon = ((System.Drawing.Image)(resources.GetObject("inputPasswordAgain.Icon")));
            this.inputPasswordAgain.Location = new System.Drawing.Point(103, 122);
            this.inputPasswordAgain.Name = "inputPasswordAgain";
            this.inputPasswordAgain.Size = new System.Drawing.Size(250, 42);
            this.inputPasswordAgain.TabIndex = 1;
            this.inputPasswordAgain.text = "";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangePassword.BorderRadius = 0;
            this.btnChangePassword.ButtonText = "Change Password";
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnChangePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Iconimage")));
            this.btnChangePassword.Iconimage_right = null;
            this.btnChangePassword.Iconimage_right_Selected = null;
            this.btnChangePassword.Iconimage_Selected = null;
            this.btnChangePassword.IconMarginLeft = 0;
            this.btnChangePassword.IconMarginRight = 0;
            this.btnChangePassword.IconRightVisible = true;
            this.btnChangePassword.IconRightZoom = 0D;
            this.btnChangePassword.IconVisible = true;
            this.btnChangePassword.IconZoom = 90D;
            this.btnChangePassword.IsTab = false;
            this.btnChangePassword.Location = new System.Drawing.Point(103, 200);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChangePassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnChangePassword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChangePassword.selected = false;
            this.btnChangePassword.Size = new System.Drawing.Size(250, 48);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Textcolor = System.Drawing.Color.White;
            this.btnChangePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(103, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 18);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Old Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(103, 97);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 18);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "New Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 275);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.inputPasswordAgain);
            this.Controls.Add(this.inputPassword);
            this.Name = "Form3";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuTextbox inputPassword;
        private ns1.BunifuTextbox inputPasswordAgain;
        private ns1.BunifuFlatButton btnChangePassword;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
    }
}