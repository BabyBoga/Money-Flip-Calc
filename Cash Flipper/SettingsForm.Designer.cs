namespace Cash_Flipper
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.oofCheckBox = new System.Windows.Forms.CheckBox();
            this.moneyRainPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.moneyRainCheck = new System.Windows.Forms.CheckBox();
            this.colorCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.moneyRainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // oofCheckBox
            // 
            this.oofCheckBox.AutoSize = true;
            this.oofCheckBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oofCheckBox.Location = new System.Drawing.Point(3, 52);
            this.oofCheckBox.Name = "oofCheckBox";
            this.oofCheckBox.Size = new System.Drawing.Size(189, 24);
            this.oofCheckBox.TabIndex = 4;
            this.oofCheckBox.Text = "Random chance to fail";
            this.oofCheckBox.UseVisualStyleBackColor = true;
            this.oofCheckBox.CheckedChanged += new System.EventHandler(this.oofCheckBox_CheckedChanged);
            // 
            // moneyRainPicture
            // 
            this.moneyRainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyRainPicture.Image = global::Cash_Flipper.Properties.Resources.muneh;
            this.moneyRainPicture.Location = new System.Drawing.Point(0, 0);
            this.moneyRainPicture.Name = "moneyRainPicture";
            this.moneyRainPicture.Size = new System.Drawing.Size(442, 267);
            this.moneyRainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moneyRainPicture.TabIndex = 3;
            this.moneyRainPicture.TabStop = false;
            this.moneyRainPicture.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "MONEY FLIP CALCULATOR";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // moneyRainCheck
            // 
            this.moneyRainCheck.AutoSize = true;
            this.moneyRainCheck.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyRainCheck.Location = new System.Drawing.Point(324, 244);
            this.moneyRainCheck.Name = "moneyRainCheck";
            this.moneyRainCheck.Size = new System.Drawing.Size(113, 24);
            this.moneyRainCheck.TabIndex = 6;
            this.moneyRainCheck.Text = "Money Rain";
            this.moneyRainCheck.UseVisualStyleBackColor = true;
            // 
            // colorCheck
            // 
            this.colorCheck.AutoSize = true;
            this.colorCheck.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCheck.Location = new System.Drawing.Point(3, 82);
            this.colorCheck.Name = "colorCheck";
            this.colorCheck.Size = new System.Drawing.Size(125, 24);
            this.colorCheck.TabIndex = 7;
            this.colorCheck.Text = "Flashy Colors";
            this.colorCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.colorCheck);
            this.Controls.Add(this.moneyRainCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oofCheckBox);
            this.Controls.Add(this.moneyRainPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings DLC";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moneyRainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox oofCheckBox;
        private System.Windows.Forms.PictureBox moneyRainPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox moneyRainCheck;
        private System.Windows.Forms.CheckBox colorCheck;
    }
}