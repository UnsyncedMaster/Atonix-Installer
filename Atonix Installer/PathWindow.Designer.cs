namespace Atonix_Installer
{
    partial class PathWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathWindow));
            this.PathPnl = new System.Windows.Forms.Panel();
            this.DefaultPathBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PathSelectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PathTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PathPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathPnl
            // 
            this.PathPnl.Controls.Add(this.DefaultPathBtn);
            this.PathPnl.Controls.Add(this.PathSelectBtn);
            this.PathPnl.Controls.Add(this.PathTb);
            this.PathPnl.Controls.Add(this.guna2HtmlLabel1);
            this.PathPnl.Controls.Add(this.guna2HtmlLabel3);
            this.PathPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPnl.Location = new System.Drawing.Point(0, 0);
            this.PathPnl.Name = "PathPnl";
            this.PathPnl.Size = new System.Drawing.Size(497, 305);
            this.PathPnl.TabIndex = 38;
            // 
            // DefaultPathBtn
            // 
            this.DefaultPathBtn.Animated = true;
            this.DefaultPathBtn.BorderRadius = 8;
            this.DefaultPathBtn.DisabledState.FillColor = System.Drawing.Color.DimGray;
            this.DefaultPathBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DefaultPathBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.DefaultPathBtn.ForeColor = System.Drawing.Color.White;
            this.DefaultPathBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.DefaultPathBtn.Location = new System.Drawing.Point(27, 135);
            this.DefaultPathBtn.Name = "DefaultPathBtn";
            this.DefaultPathBtn.Size = new System.Drawing.Size(439, 42);
            this.DefaultPathBtn.TabIndex = 37;
            this.DefaultPathBtn.Text = "Default Path";
            this.DefaultPathBtn.Click += new System.EventHandler(this.DefaultPathBtn_Click);
            // 
            // PathSelectBtn
            // 
            this.PathSelectBtn.Animated = true;
            this.PathSelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.PathSelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PathSelectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathSelectBtn.BorderRadius = 8;
            this.PathSelectBtn.BorderThickness = 2;
            this.PathSelectBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PathSelectBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PathSelectBtn.CustomBorderColor = System.Drawing.Color.White;
            this.PathSelectBtn.CustomizableEdges.BottomLeft = false;
            this.PathSelectBtn.CustomizableEdges.TopLeft = false;
            this.PathSelectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathSelectBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PathSelectBtn.ForeColor = System.Drawing.Color.White;
            this.PathSelectBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.PathSelectBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PathSelectBtn.Image = ((System.Drawing.Image)(resources.GetObject("PathSelectBtn.Image")));
            this.PathSelectBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.PathSelectBtn.Location = new System.Drawing.Point(425, 88);
            this.PathSelectBtn.Name = "PathSelectBtn";
            this.PathSelectBtn.PressedColor = System.Drawing.Color.White;
            this.PathSelectBtn.Size = new System.Drawing.Size(41, 41);
            this.PathSelectBtn.TabIndex = 163;
            this.PathSelectBtn.TextOffset = new System.Drawing.Point(1, -1);
            this.PathSelectBtn.UseTransparentBackground = true;
            this.PathSelectBtn.Click += new System.EventHandler(this.PathSelectBtn_Click);
            // 
            // PathTb
            // 
            this.PathTb.Animated = true;
            this.PathTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathTb.BorderRadius = 8;
            this.PathTb.BorderThickness = 2;
            this.PathTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PathTb.CustomizableEdges.BottomRight = false;
            this.PathTb.CustomizableEdges.TopRight = false;
            this.PathTb.DefaultText = "";
            this.PathTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PathTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PathTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PathTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PathTb.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.PathTb.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PathTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.PathTb.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PathTb.Location = new System.Drawing.Point(27, 88);
            this.PathTb.Name = "PathTb";
            this.PathTb.PasswordChar = '\0';
            this.PathTb.PlaceholderText = "";
            this.PathTb.ReadOnly = true;
            this.PathTb.SelectedText = "";
            this.PathTb.Size = new System.Drawing.Size(398, 41);
            this.PathTb.TabIndex = 162;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 14);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(473, 39);
            this.guna2HtmlLabel1.TabIndex = 160;
            this.guna2HtmlLabel1.Text = "Installation Path";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(25, 44);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(460, 38);
            this.guna2HtmlLabel3.TabIndex = 161;
            this.guna2HtmlLabel3.Text = "Choose where to install Atonix.\r\n";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PathWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(497, 305);
            this.Controls.Add(this.PathPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathWindow";
            this.Text = "Path";
            this.Load += new System.EventHandler(this.Path_Load);
            this.PathPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PathPnl;
        private Guna.UI2.WinForms.Guna2Button DefaultPathBtn;
        private Guna.UI2.WinForms.Guna2Button PathSelectBtn;
        private Guna.UI2.WinForms.Guna2TextBox PathTb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}