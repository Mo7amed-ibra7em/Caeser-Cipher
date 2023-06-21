
namespace Caeser_Ciphere
{
    partial class Form1
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
            this.b_Encrypt = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_del = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.t_plain = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_cipher = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_key = new Guna.UI2.WinForms.Guna2TextBox();
            this.b_Decrypt = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // b_Encrypt
            // 
            this.b_Encrypt.Animated = true;
            this.b_Encrypt.AnimationHoverSpeed = 0.07F;
            this.b_Encrypt.AnimationSpeed = 0.03F;
            this.b_Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.b_Encrypt.BaseColor = System.Drawing.Color.Green;
            this.b_Encrypt.BorderColor = System.Drawing.Color.LightBlue;
            this.b_Encrypt.BorderSize = 2;
            this.b_Encrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.b_Encrypt.FocusedColor = System.Drawing.Color.Empty;
            this.b_Encrypt.Font = new System.Drawing.Font("DecoType Naskh Variants", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_Encrypt.ForeColor = System.Drawing.Color.LightBlue;
            this.b_Encrypt.Image = null;
            this.b_Encrypt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_Encrypt.ImageSize = new System.Drawing.Size(20, 20);
            this.b_Encrypt.Location = new System.Drawing.Point(257, 332);
            this.b_Encrypt.Margin = new System.Windows.Forms.Padding(4);
            this.b_Encrypt.Name = "b_Encrypt";
            this.b_Encrypt.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.b_Encrypt.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.b_Encrypt.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_Encrypt.OnHoverImage = null;
            this.b_Encrypt.OnPressedColor = System.Drawing.Color.Gold;
            this.b_Encrypt.Radius = 15;
            this.b_Encrypt.Size = new System.Drawing.Size(103, 44);
            this.b_Encrypt.TabIndex = 5;
            this.b_Encrypt.Text = "تشفير";
            this.b_Encrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_Encrypt.Click += new System.EventHandler(this.b_Encrypt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plain/Cipher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(24, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_del
            // 
            this.b_del.Animated = true;
            this.b_del.AnimationHoverSpeed = 0.07F;
            this.b_del.AnimationSpeed = 0.03F;
            this.b_del.BackColor = System.Drawing.Color.Transparent;
            this.b_del.BaseColor = System.Drawing.Color.Green;
            this.b_del.BorderColor = System.Drawing.Color.LightBlue;
            this.b_del.BorderSize = 2;
            this.b_del.DialogResult = System.Windows.Forms.DialogResult.None;
            this.b_del.FocusedColor = System.Drawing.Color.Empty;
            this.b_del.Font = new System.Drawing.Font("DecoType Naskh Variants", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_del.ForeColor = System.Drawing.Color.LightBlue;
            this.b_del.Image = null;
            this.b_del.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_del.ImageSize = new System.Drawing.Size(20, 20);
            this.b_del.Location = new System.Drawing.Point(65, 332);
            this.b_del.Margin = new System.Windows.Forms.Padding(4);
            this.b_del.Name = "b_del";
            this.b_del.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.b_del.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.b_del.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_del.OnHoverImage = null;
            this.b_del.OnPressedColor = System.Drawing.Color.Gold;
            this.b_del.Radius = 15;
            this.b_del.Size = new System.Drawing.Size(60, 44);
            this.b_del.TabIndex = 10;
            this.b_del.Text = "حذف";
            this.b_del.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Urdu Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(104, -9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 54);
            this.label4.TabIndex = 11;
            this.label4.Text = "Caeser Cipher";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // t_plain
            // 
            this.t_plain.Animated = true;
            this.t_plain.AutoRoundedCorners = true;
            this.t_plain.BackColor = System.Drawing.Color.Transparent;
            this.t_plain.BorderColor = System.Drawing.Color.LightBlue;
            this.t_plain.BorderRadius = 18;
            this.t_plain.BorderThickness = 2;
            this.t_plain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_plain.DefaultText = "";
            this.t_plain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_plain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_plain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_plain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_plain.FillColor = System.Drawing.Color.Green;
            this.t_plain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.t_plain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_plain.ForeColor = System.Drawing.Color.White;
            this.t_plain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_plain.Location = new System.Drawing.Point(133, 110);
            this.t_plain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_plain.Name = "t_plain";
            this.t_plain.PasswordChar = '\0';
            this.t_plain.PlaceholderForeColor = System.Drawing.Color.White;
            this.t_plain.PlaceholderText = "";
            this.t_plain.SelectedText = "";
            this.t_plain.Size = new System.Drawing.Size(227, 39);
            this.t_plain.TabIndex = 12;
            // 
            // t_cipher
            // 
            this.t_cipher.Animated = true;
            this.t_cipher.AutoRoundedCorners = true;
            this.t_cipher.BackColor = System.Drawing.Color.Transparent;
            this.t_cipher.BorderColor = System.Drawing.Color.LightBlue;
            this.t_cipher.BorderRadius = 18;
            this.t_cipher.BorderThickness = 2;
            this.t_cipher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_cipher.DefaultText = "";
            this.t_cipher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_cipher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_cipher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_cipher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_cipher.FillColor = System.Drawing.Color.Green;
            this.t_cipher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.t_cipher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cipher.ForeColor = System.Drawing.Color.White;
            this.t_cipher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_cipher.Location = new System.Drawing.Point(133, 248);
            this.t_cipher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_cipher.Name = "t_cipher";
            this.t_cipher.PasswordChar = '\0';
            this.t_cipher.PlaceholderForeColor = System.Drawing.Color.White;
            this.t_cipher.PlaceholderText = "";
            this.t_cipher.SelectedText = "";
            this.t_cipher.Size = new System.Drawing.Size(227, 39);
            this.t_cipher.TabIndex = 13;
            // 
            // t_key
            // 
            this.t_key.Animated = true;
            this.t_key.AutoRoundedCorners = true;
            this.t_key.BackColor = System.Drawing.Color.Transparent;
            this.t_key.BorderColor = System.Drawing.Color.LightBlue;
            this.t_key.BorderRadius = 18;
            this.t_key.BorderThickness = 2;
            this.t_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_key.DefaultText = "";
            this.t_key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_key.FillColor = System.Drawing.Color.Green;
            this.t_key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.t_key.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_key.ForeColor = System.Drawing.Color.White;
            this.t_key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_key.Location = new System.Drawing.Point(133, 179);
            this.t_key.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_key.Name = "t_key";
            this.t_key.PasswordChar = '\0';
            this.t_key.PlaceholderForeColor = System.Drawing.Color.White;
            this.t_key.PlaceholderText = "";
            this.t_key.SelectedText = "";
            this.t_key.Size = new System.Drawing.Size(227, 39);
            this.t_key.TabIndex = 14;
            // 
            // b_Decrypt
            // 
            this.b_Decrypt.Animated = true;
            this.b_Decrypt.AnimationHoverSpeed = 0.07F;
            this.b_Decrypt.AnimationSpeed = 0.03F;
            this.b_Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.b_Decrypt.BaseColor = System.Drawing.Color.Green;
            this.b_Decrypt.BorderColor = System.Drawing.Color.LightBlue;
            this.b_Decrypt.BorderSize = 2;
            this.b_Decrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.b_Decrypt.FocusedColor = System.Drawing.Color.Empty;
            this.b_Decrypt.Font = new System.Drawing.Font("DecoType Naskh Variants", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_Decrypt.ForeColor = System.Drawing.Color.LightBlue;
            this.b_Decrypt.Image = null;
            this.b_Decrypt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_Decrypt.ImageSize = new System.Drawing.Size(20, 20);
            this.b_Decrypt.Location = new System.Drawing.Point(146, 332);
            this.b_Decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.b_Decrypt.Name = "b_Decrypt";
            this.b_Decrypt.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.b_Decrypt.OnHoverBorderColor = System.Drawing.Color.Yellow;
            this.b_Decrypt.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_Decrypt.OnHoverImage = null;
            this.b_Decrypt.OnPressedColor = System.Drawing.Color.Gold;
            this.b_Decrypt.Radius = 15;
            this.b_Decrypt.Size = new System.Drawing.Size(103, 44);
            this.b_Decrypt.TabIndex = 15;
            this.b_Decrypt.Text = " فك تشفير";
            this.b_Decrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_Decrypt.Click += new System.EventHandler(this.b_Decrypt_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(13, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Plain/Cipher";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.GreenYellow;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.LightGreen;
            this.guna2ControlBox1.Location = new System.Drawing.Point(356, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(413, 405);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_Decrypt);
            this.Controls.Add(this.t_key);
            this.Controls.Add(this.t_cipher);
            this.Controls.Add(this.t_plain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Encrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton b_Encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton b_del;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox t_plain;
        private Guna.UI2.WinForms.Guna2TextBox t_cipher;
        private Guna.UI2.WinForms.Guna2TextBox t_key;
        private Guna.UI.WinForms.GunaButton b_Decrypt;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

