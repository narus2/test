namespace WindowsFormsApp2
{
    partial class Form2
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
            this.te_Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.te_Base = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // te_Server
            // 
            this.te_Server.Location = new System.Drawing.Point(94, 17);
            this.te_Server.Name = "te_Server";
            this.te_Server.Size = new System.Drawing.Size(176, 22);
            this.te_Server.TabIndex = 0;
            this.te_Server.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server name";
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(12, 82);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server base";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // te_Base
            // 
            this.te_Base.Location = new System.Drawing.Point(94, 45);
            this.te_Base.Name = "te_Base";
            this.te_Base.Size = new System.Drawing.Size(176, 22);
            this.te_Base.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.te_Base);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.te_Server);
            this.Name = "Form2";
            this.Text = "Save/Load settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox te_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox te_Base;
    }
}