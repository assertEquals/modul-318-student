namespace ÖVinder {
    partial class Popup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.labelReciver = new System.Windows.Forms.Label();
            this.textBoxReciver = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReciver
            // 
            this.labelReciver.AutoSize = true;
            this.labelReciver.Location = new System.Drawing.Point(13, 13);
            this.labelReciver.Name = "labelReciver";
            this.labelReciver.Size = new System.Drawing.Size(61, 13);
            this.labelReciver.TabIndex = 0;
            this.labelReciver.Text = "Empfänger:";
            // 
            // textBoxReciver
            // 
            this.textBoxReciver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReciver.Location = new System.Drawing.Point(80, 10);
            this.textBoxReciver.Name = "textBoxReciver";
            this.textBoxReciver.Size = new System.Drawing.Size(200, 20);
            this.textBoxReciver.TabIndex = 1;
            this.textBoxReciver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReciver_KeyDown);
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(12, 39);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(31, 13);
            this.labelBody.TabIndex = 2;
            this.labelBody.Text = "Text:";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBody.Location = new System.Drawing.Point(12, 55);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(268, 97);
            this.textBoxBody.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 158);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(128, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Senden";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(146, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 189);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.textBoxReciver);
            this.Controls.Add(this.labelReciver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.Text = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReciver;
        private System.Windows.Forms.TextBox textBoxReciver;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCancel;
    }
}