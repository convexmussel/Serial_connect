namespace serial
{
    partial class options_panel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.bCommand = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.confirmButton);
            this.groupBox1.Controls.Add(this.bCommand);
            this.groupBox1.Controls.Add(this.command);
            this.groupBox1.Controls.Add(this.bName);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "user control";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(165, 109);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(246, 109);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // bCommand
            // 
            this.bCommand.Location = new System.Drawing.Point(105, 81);
            this.bCommand.Name = "bCommand";
            this.bCommand.Size = new System.Drawing.Size(216, 22);
            this.bCommand.TabIndex = 4;
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(8, 84);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(91, 17);
            this.command.TabIndex = 3;
            this.command.Text = "button name:";
            // 
            // bName
            // 
            this.bName.Location = new System.Drawing.Point(105, 53);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(216, 22);
            this.bName.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(8, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(91, 17);
            this.name.TabIndex = 1;
            this.name.Text = "button name:";
            // 
            // options_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 162);
            this.Controls.Add(this.groupBox1);
            this.Name = "options_panel";
            this.Text = "options_form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox bCommand;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.TextBox bName;
        private System.Windows.Forms.Label name;
    }
}