namespace Atonix_Installer
{
    partial class FinishWindow
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
            this.FinishPnl = new System.Windows.Forms.Panel();
            this.JoinDiscordCb = new Guna.UI2.WinForms.Guna2CheckBox();
            this.StartAfterFinishedCb = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FinishPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinishPnl
            // 
            this.FinishPnl.Controls.Add(this.JoinDiscordCb);
            this.FinishPnl.Controls.Add(this.StartAfterFinishedCb);
            this.FinishPnl.Controls.Add(this.guna2HtmlLabel5);
            this.FinishPnl.Controls.Add(this.guna2HtmlLabel6);
            this.FinishPnl.Location = new System.Drawing.Point(0, 0);
            this.FinishPnl.Name = "FinishPnl";
            this.FinishPnl.Size = new System.Drawing.Size(497, 304);
            this.FinishPnl.TabIndex = 39;
            // 
            // JoinDiscordCb
            // 
            this.JoinDiscordCb.Animated = true;
            this.JoinDiscordCb.AutoSize = true;
            this.JoinDiscordCb.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.JoinDiscordCb.CheckedState.BorderRadius = 2;
            this.JoinDiscordCb.CheckedState.BorderThickness = 0;
            this.JoinDiscordCb.CheckedState.FillColor = System.Drawing.Color.Red;
            this.JoinDiscordCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDiscordCb.ForeColor = System.Drawing.Color.White;
            this.JoinDiscordCb.Location = new System.Drawing.Point(179, 123);
            this.JoinDiscordCb.Name = "JoinDiscordCb";
            this.JoinDiscordCb.Size = new System.Drawing.Size(99, 21);
            this.JoinDiscordCb.TabIndex = 168;
            this.JoinDiscordCb.Text = "Join Discord";
            this.JoinDiscordCb.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.JoinDiscordCb.UncheckedState.BorderRadius = 2;
            this.JoinDiscordCb.UncheckedState.BorderThickness = 0;
            this.JoinDiscordCb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.JoinDiscordCb.CheckedChanged += new System.EventHandler(this.JoinDiscordCb_CheckedChanged);
            // 
            // StartAfterFinishedCb
            // 
            this.StartAfterFinishedCb.Animated = true;
            this.StartAfterFinishedCb.AutoSize = true;
            this.StartAfterFinishedCb.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.StartAfterFinishedCb.CheckedState.BorderRadius = 2;
            this.StartAfterFinishedCb.CheckedState.BorderThickness = 0;
            this.StartAfterFinishedCb.CheckedState.FillColor = System.Drawing.Color.Red;
            this.StartAfterFinishedCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAfterFinishedCb.ForeColor = System.Drawing.Color.White;
            this.StartAfterFinishedCb.Location = new System.Drawing.Point(179, 99);
            this.StartAfterFinishedCb.Name = "StartAfterFinishedCb";
            this.StartAfterFinishedCb.Size = new System.Drawing.Size(137, 21);
            this.StartAfterFinishedCb.TabIndex = 167;
            this.StartAfterFinishedCb.Text = "Start After Finished";
            this.StartAfterFinishedCb.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.StartAfterFinishedCb.UncheckedState.BorderRadius = 2;
            this.StartAfterFinishedCb.UncheckedState.BorderThickness = 0;
            this.StartAfterFinishedCb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StartAfterFinishedCb.CheckedChanged += new System.EventHandler(this.StartAfterFinishedCb_CheckedChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(0, 22);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(494, 39);
            this.guna2HtmlLabel5.TabIndex = 164;
            this.guna2HtmlLabel5.Text = "Successfully Downloaded Atonix";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel6.IsSelectionEnabled = false;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(0, 64);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(497, 29);
            this.guna2HtmlLabel6.TabIndex = 165;
            this.guna2HtmlLabel6.Text = "Get ready to use Atonix";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinishWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(497, 305);
            this.Controls.Add(this.FinishPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishWindow";
            this.Text = "FInishWindow";
            this.FinishPnl.ResumeLayout(false);
            this.FinishPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FinishPnl;
        private Guna.UI2.WinForms.Guna2CheckBox JoinDiscordCb;
        private Guna.UI2.WinForms.Guna2CheckBox StartAfterFinishedCb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}