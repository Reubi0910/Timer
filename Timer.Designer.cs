
namespace Timer
{
    partial class Timer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_timer = new System.Windows.Forms.Label();
            this.Cbo_PortList = new System.Windows.Forms.ComboBox();
            this.Lbl_Port = new System.Windows.Forms.Label();
            this.Img_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_ResetTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_timer
            // 
            this.Lbl_timer.AutoSize = true;
            this.Lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_timer.Location = new System.Drawing.Point(320, 156);
            this.Lbl_timer.Name = "Lbl_timer";
            this.Lbl_timer.Size = new System.Drawing.Size(184, 69);
            this.Lbl_timer.TabIndex = 0;
            this.Lbl_timer.Text = "Timer";
            // 
            // Cbo_PortList
            // 
            this.Cbo_PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PortList.FormattingEnabled = true;
            this.Cbo_PortList.Location = new System.Drawing.Point(12, 414);
            this.Cbo_PortList.Name = "Cbo_PortList";
            this.Cbo_PortList.Size = new System.Drawing.Size(163, 24);
            this.Cbo_PortList.TabIndex = 1;
            this.Cbo_PortList.SelectionChangeCommitted += new System.EventHandler(this.Cbo_PortList_SelectedItemChange);
            // 
            // Lbl_Port
            // 
            this.Lbl_Port.AutoSize = true;
            this.Lbl_Port.Location = new System.Drawing.Point(9, 394);
            this.Lbl_Port.Name = "Lbl_Port";
            this.Lbl_Port.Size = new System.Drawing.Size(42, 17);
            this.Lbl_Port.TabIndex = 2;
            this.Lbl_Port.Text = "Port :";
            // 
            // Img_Logo
            // 
            this.Img_Logo.Image = global::Timer.Properties.Resources.MicrosoftTeams_image__8_;
            this.Img_Logo.InitialImage = global::Timer.Properties.Resources.MicrosoftTeams_image__8_;
            this.Img_Logo.Location = new System.Drawing.Point(660, 12);
            this.Img_Logo.Name = "Img_Logo";
            this.Img_Logo.Size = new System.Drawing.Size(128, 128);
            this.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Logo.TabIndex = 3;
            this.Img_Logo.TabStop = false;
            // 
            // Btn_ResetTimer
            // 
            this.Btn_ResetTimer.Location = new System.Drawing.Point(693, 411);
            this.Btn_ResetTimer.Name = "Btn_ResetTimer";
            this.Btn_ResetTimer.Size = new System.Drawing.Size(95, 27);
            this.Btn_ResetTimer.TabIndex = 4;
            this.Btn_ResetTimer.Text = "Reset";
            this.Btn_ResetTimer.UseVisualStyleBackColor = true;
            this.Btn_ResetTimer.Click += new System.EventHandler(this.Btn_ResetTimer_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ResetTimer);
            this.Controls.Add(this.Img_Logo);
            this.Controls.Add(this.Lbl_Port);
            this.Controls.Add(this.Cbo_PortList);
            this.Controls.Add(this.Lbl_timer);
            this.Name = "Timer";
            this.Text = "JO Divtec 2023";
            this.AutoSizeChanged += new System.EventHandler(this.Timer_Resize);
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResizeEnd += new System.EventHandler(this.Timer_Resize);
            this.SizeChanged += new System.EventHandler(this.Timer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_timer;
        private System.Windows.Forms.Label Lbl_Port;
        private System.Windows.Forms.ComboBox Cbo_PortList;
        private System.Windows.Forms.PictureBox Img_Logo;
        private System.Windows.Forms.Button Btn_ResetTimer;
    }
}

