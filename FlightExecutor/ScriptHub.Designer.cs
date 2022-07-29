namespace FlightExecutor
{
    partial class ScriptHub
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
            ePOSOne.btnProduct.Button_WOC SaveFile;
            this.label1 = new System.Windows.Forms.Label();
            SaveFile = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // SaveFile
            // 
            SaveFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            SaveFile.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            SaveFile.FlatAppearance.BorderSize = 0;
            SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SaveFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SaveFile.Location = new System.Drawing.Point(12, 51);
            SaveFile.Name = "SaveFile";
            SaveFile.OnHoverBorderColor = System.Drawing.Color.Transparent;
            SaveFile.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            SaveFile.OnHoverTextColor = System.Drawing.Color.White;
            SaveFile.Size = new System.Drawing.Size(114, 40);
            SaveFile.TabIndex = 5;
            SaveFile.Text = "Execute";
            SaveFile.TextColor = System.Drawing.Color.White;
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "FlightWare";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(SaveFile);
            this.Name = "ScriptHub";
            this.Text = "ScriptHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}