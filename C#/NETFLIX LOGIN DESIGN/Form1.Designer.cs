using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NETFLIX_LOGIN_DESIGN
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            LinkLabel1 = new LinkLabel();
            Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            Guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            LinkLabel2 = new LinkLabel();
            Label1 = new Label();
            LinkLabel3 = new LinkLabel();
            Guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2ControlBox1.Click += new EventHandler(Guna2ControlBox1_Click);
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.TargetControl = this;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.DragStartTransparencyValue = 0.8d;
            Guna2DragControl1.TargetControl = this;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.BackgroundImage = My.Resources.Resources.Logos_Readability_Netflix_logo;
            Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Guna2PictureBox1.ErrorImage = null;
            Guna2PictureBox1.FillColor = Color.Transparent;
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.InitialImage = null;
            Guna2PictureBox1.Location = new Point(124, 23);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.Size = new Size(206, 97);
            Guna2PictureBox1.TabIndex = 0;
            Guna2PictureBox1.TabStop = false;
            // 
            // Guna2TextBox1
            // 
            Guna2TextBox1.Animated = true;
            Guna2TextBox1.BackColor = Color.Transparent;
            Guna2TextBox1.BorderColor = Color.FromArgb(95, 95, 95);
            Guna2TextBox1.BorderRadius = 5;
            Guna2TextBox1.Cursor = Cursors.IBeam;
            Guna2TextBox1.DefaultText = "";
            Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.FillColor = Color.FromArgb(17, 18, 18);
            Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Font = new Font("Segoe UI", 9.0f);
            Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Location = new Point(551, 151);
            Guna2TextBox1.Name = "Guna2TextBox1";
            Guna2TextBox1.PasswordChar = '\0';
            Guna2TextBox1.PlaceholderText = "Email or phone number";
            Guna2TextBox1.SelectedText = "";
            Guna2TextBox1.Size = new Size(279, 36);
            Guna2TextBox1.TabIndex = 1;
            // 
            // Guna2TextBox2
            // 
            Guna2TextBox2.Animated = true;
            Guna2TextBox2.BackColor = Color.Transparent;
            Guna2TextBox2.BorderColor = Color.FromArgb(95, 95, 95);
            Guna2TextBox2.BorderRadius = 5;
            Guna2TextBox2.Cursor = Cursors.IBeam;
            Guna2TextBox2.DefaultText = "";
            Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.FillColor = Color.FromArgb(17, 18, 18);
            Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Font = new Font("Segoe UI", 9.0f);
            Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Location = new Point(552, 222);
            Guna2TextBox2.Name = "Guna2TextBox2";
            Guna2TextBox2.PasswordChar = '\0';
            Guna2TextBox2.PlaceholderText = "Password";
            Guna2TextBox2.SelectedText = "";
            Guna2TextBox2.Size = new Size(279, 36);
            Guna2TextBox2.TabIndex = 2;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.ForeColor = Color.FromArgb(176, 12, 6);
            Guna2HtmlLabel1.Location = new Point(549, 264);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(293, 15);
            Guna2HtmlLabel1.TabIndex = 3;
            Guna2HtmlLabel1.Text = "✘ Your password must contain between 4 and 60 characters.";
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.ForeColor = Color.FromArgb(176, 12, 6);
            Guna2HtmlLabel2.Location = new Point(552, 198);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(221, 15);
            Guna2HtmlLabel2.TabIndex = 4;
            Guna2HtmlLabel2.Text = "✘ Please enter a valid email or phone number.";
            // 
            // Guna2Button1
            // 
            Guna2Button1.Animated = true;
            Guna2Button1.BackColor = Color.Transparent;
            Guna2Button1.BorderRadius = 5;
            Guna2Button1.Cursor = Cursors.Hand;
            Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button1.FillColor = Color.FromArgb(229, 9, 20);
            Guna2Button1.Font = new Font("Microsoft YaHei UI", 9.75f, FontStyle.Bold);
            Guna2Button1.ForeColor = Color.White;
            Guna2Button1.Location = new Point(552, 300);
            Guna2Button1.Name = "Guna2Button1";
            Guna2Button1.Size = new Size(278, 45);
            Guna2Button1.TabIndex = 5;
            Guna2Button1.Text = "Sign In";
            // 
            // Guna2HtmlLabel3
            // 
            Guna2HtmlLabel3.BackColor = Color.Transparent;
            Guna2HtmlLabel3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel3.ForeColor = Color.Gray;
            Guna2HtmlLabel3.Location = new Point(677, 355);
            Guna2HtmlLabel3.Name = "Guna2HtmlLabel3";
            Guna2HtmlLabel3.Size = new Size(26, 20);
            Guna2HtmlLabel3.TabIndex = 6;
            Guna2HtmlLabel3.Text = "OR";
            // 
            // Guna2Button2
            // 
            Guna2Button2.Animated = true;
            Guna2Button2.BackColor = Color.Transparent;
            Guna2Button2.BorderRadius = 5;
            Guna2Button2.Cursor = Cursors.Hand;
            Guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button2.FillColor = Color.FromArgb(52, 51, 51);
            Guna2Button2.Font = new Font("Microsoft YaHei UI", 9.75f, FontStyle.Bold);
            Guna2Button2.ForeColor = Color.White;
            Guna2Button2.Location = new Point(553, 387);
            Guna2Button2.Name = "Guna2Button2";
            Guna2Button2.Size = new Size(278, 45);
            Guna2Button2.TabIndex = 7;
            Guna2Button2.Text = "Use a Sign-In Code";
            // 
            // LinkLabel1
            // 
            LinkLabel1.ActiveLinkColor = Color.Gray;
            LinkLabel1.AutoSize = true;
            LinkLabel1.BackColor = Color.Transparent;
            LinkLabel1.Cursor = Cursors.Hand;
            LinkLabel1.LinkColor = Color.White;
            LinkLabel1.Location = new Point(649, 453);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(91, 13);
            LinkLabel1.TabIndex = 8;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Forgot password?";
            // 
            // Guna2CheckBox1
            // 
            Guna2CheckBox1.AutoSize = true;
            Guna2CheckBox1.BackColor = Color.Transparent;
            Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(52, 51, 51);
            Guna2CheckBox1.CheckedState.BorderRadius = 1;
            Guna2CheckBox1.CheckedState.BorderThickness = 1;
            Guna2CheckBox1.CheckedState.FillColor = Color.White;
            Guna2CheckBox1.CheckMarkColor = Color.Black;
            Guna2CheckBox1.Cursor = Cursors.Hand;
            Guna2CheckBox1.Font = new Font("Microsoft Sans Serif", 8.25f);
            Guna2CheckBox1.ForeColor = Color.White;
            Guna2CheckBox1.Location = new Point(553, 481);
            Guna2CheckBox1.Name = "Guna2CheckBox1";
            Guna2CheckBox1.Size = new Size(94, 17);
            Guna2CheckBox1.TabIndex = 9;
            Guna2CheckBox1.Text = "Remember me";
            Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(52, 51, 51);
            Guna2CheckBox1.UncheckedState.BorderRadius = 2;
            Guna2CheckBox1.UncheckedState.BorderThickness = 0;
            Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(17, 18, 18);
            Guna2CheckBox1.UseVisualStyleBackColor = false;
            // 
            // Guna2HtmlLabel4
            // 
            Guna2HtmlLabel4.BackColor = Color.Transparent;
            Guna2HtmlLabel4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guna2HtmlLabel4.ForeColor = Color.Gray;
            Guna2HtmlLabel4.Location = new Point(553, 510);
            Guna2HtmlLabel4.Name = "Guna2HtmlLabel4";
            Guna2HtmlLabel4.Size = new Size(90, 18);
            Guna2HtmlLabel4.TabIndex = 10;
            Guna2HtmlLabel4.Text = "New to Netflix?";
            // 
            // LinkLabel2
            // 
            LinkLabel2.ActiveLinkColor = Color.Gray;
            LinkLabel2.AutoSize = true;
            LinkLabel2.BackColor = Color.Transparent;
            LinkLabel2.Font = new Font("Microsoft Sans Serif", 9.75f);
            LinkLabel2.LinkColor = Color.White;
            LinkLabel2.Location = new Point(646, 510);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(83, 16);
            LinkLabel2.TabIndex = 11;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Sign up now.";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.ForeColor = Color.Gray;
            Label1.Location = new Point(550, 552);
            Label1.Name = "Label1";
            Label1.Size = new Size(237, 26);
            Label1.TabIndex = 12;
            Label1.Text = "This page is protected by Google reCAPTCHA to" + '\r' + '\n' + "ensure you're not a bot.";
            // 
            // LinkLabel3
            // 
            LinkLabel3.ActiveLinkColor = Color.FromArgb(7, 107, 247);
            LinkLabel3.AutoSize = true;
            LinkLabel3.BackColor = Color.Transparent;
            LinkLabel3.Cursor = Cursors.Hand;
            LinkLabel3.LinkColor = Color.FromArgb(7, 97, 221);
            LinkLabel3.Location = new Point(665, 565);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(63, 13);
            LinkLabel3.TabIndex = 13;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Learn more.";
            // 
            // Guna2DragControl2
            // 
            Guna2DragControl2.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl2.TargetControl = Guna2PictureBox1;
            Guna2DragControl2.UseTransparentDrag = true;
            // 
            // Guna2ControlBox1
            // 
            Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox1.BackColor = Color.Transparent;
            Guna2ControlBox1.BorderRadius = 3;
            Guna2ControlBox1.Cursor = Cursors.Hand;
            Guna2ControlBox1.FillColor = Color.Transparent;
            Guna2ControlBox1.IconColor = Color.White;
            Guna2ControlBox1.Location = new Point(1347, -1);
            Guna2ControlBox1.Name = "Guna2ControlBox1";
            Guna2ControlBox1.Size = new Size(41, 27);
            Guna2ControlBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = My.Resources.Resources.NETfLIX2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1388, 761);
            Controls.Add(Guna2ControlBox1);
            Controls.Add(LinkLabel3);
            Controls.Add(Label1);
            Controls.Add(LinkLabel2);
            Controls.Add(Guna2HtmlLabel4);
            Controls.Add(Guna2CheckBox1);
            Controls.Add(LinkLabel1);
            Controls.Add(Guna2Button2);
            Controls.Add(Guna2HtmlLabel3);
            Controls.Add(Guna2Button1);
            Controls.Add(Guna2HtmlLabel2);
            Controls.Add(Guna2HtmlLabel1);
            Controls.Add(Guna2TextBox2);
            Controls.Add(Guna2TextBox1);
            Controls.Add(Guna2PictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel3;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2CheckBox Guna2CheckBox1;
        internal LinkLabel LinkLabel1;
        internal LinkLabel LinkLabel3;
        internal Label Label1;
        internal LinkLabel LinkLabel2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel4;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl2;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
    }
}