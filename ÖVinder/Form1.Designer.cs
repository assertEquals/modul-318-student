namespace ÖVinder
{
    partial class ouvinder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVerbindungen = new System.Windows.Forms.TabPage();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.panelVerbindungen = new System.Windows.Forms.Panel();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.labelVerbindungen = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelZeit = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.textBoxNach = new System.Windows.Forms.TextBox();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.labelNach = new System.Windows.Forms.Label();
            this.labelVon = new System.Windows.Forms.Label();
            this.tabPageAbfahrtsplan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.panelVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVerbindungen);
            this.tabControl1.Controls.Add(this.tabPageAbfahrtsplan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.buttonSuchen);
            this.tabPageVerbindungen.Controls.Add(this.panelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.labelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.textBox3);
            this.tabPageVerbindungen.Controls.Add(this.labelZeit);
            this.tabPageVerbindungen.Controls.Add(this.dateTimePicker1);
            this.tabPageVerbindungen.Controls.Add(this.labelDatum);
            this.tabPageVerbindungen.Controls.Add(this.textBoxNach);
            this.tabPageVerbindungen.Controls.Add(this.textBoxVon);
            this.tabPageVerbindungen.Controls.Add(this.labelNach);
            this.tabPageVerbindungen.Controls.Add(this.labelVon);
            this.tabPageVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerbindungen.Name = "tabPageVerbindungen";
            this.tabPageVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungen.Size = new System.Drawing.Size(613, 390);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(462, 80);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(143, 23);
            this.buttonSuchen.TabIndex = 10;
            this.buttonSuchen.Text = "Verbindungen Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // panelVerbindungen
            // 
            this.panelVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVerbindungen.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.panelVerbindungen.Location = new System.Drawing.Point(3, 127);
            this.panelVerbindungen.Name = "panelVerbindungen";
            this.panelVerbindungen.Size = new System.Drawing.Size(607, 263);
            this.panelVerbindungen.TabIndex = 9;
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.ColumnCount = 3;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.74387F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.25613F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanelVerbindungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 2;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(607, 263);
            this.tableLayoutPanelVerbindungen.TabIndex = 0;
            // 
            // labelVerbindungen
            // 
            this.labelVerbindungen.AutoSize = true;
            this.labelVerbindungen.Location = new System.Drawing.Point(8, 111);
            this.labelVerbindungen.Name = "labelVerbindungen";
            this.labelVerbindungen.Size = new System.Drawing.Size(82, 13);
            this.labelVerbindungen.TabIndex = 8;
            this.labelVerbindungen.Text = "Verbindungen v";
            this.labelVerbindungen.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // labelZeit
            // 
            this.labelZeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZeit.AutoSize = true;
            this.labelZeit.Location = new System.Drawing.Point(378, 57);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(28, 13);
            this.labelZeit.TabIndex = 6;
            this.labelZeit.Text = "Zeit:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelDatum
            // 
            this.labelDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(378, 28);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(41, 13);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "Datum:";
            // 
            // textBoxNach
            // 
            this.textBoxNach.Location = new System.Drawing.Point(45, 54);
            this.textBoxNach.Name = "textBoxNach";
            this.textBoxNach.Size = new System.Drawing.Size(100, 20);
            this.textBoxNach.TabIndex = 3;
            // 
            // textBoxVon
            // 
            this.textBoxVon.Location = new System.Drawing.Point(45, 25);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(100, 20);
            this.textBoxVon.TabIndex = 2;
            // 
            // labelNach
            // 
            this.labelNach.AutoSize = true;
            this.labelNach.Location = new System.Drawing.Point(3, 57);
            this.labelNach.Name = "labelNach";
            this.labelNach.Size = new System.Drawing.Size(36, 13);
            this.labelNach.TabIndex = 1;
            this.labelNach.Text = "Nach:";
            // 
            // labelVon
            // 
            this.labelVon.AutoSize = true;
            this.labelVon.Location = new System.Drawing.Point(6, 28);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(29, 13);
            this.labelVon.TabIndex = 0;
            this.labelVon.Text = "Von:";
            // 
            // tabPageAbfahrtsplan
            // 
            this.tabPageAbfahrtsplan.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbfahrtsplan.Name = "tabPageAbfahrtsplan";
            this.tabPageAbfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrtsplan.Size = new System.Drawing.Size(613, 390);
            this.tabPageAbfahrtsplan.TabIndex = 1;
            this.tabPageAbfahrtsplan.Text = "Abfahrtsplan";
            this.tabPageAbfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // ouvinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 416);
            this.Controls.Add(this.tabControl1);
            this.Name = "ouvinder";
            this.Text = "ÖVinder";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.panelVerbindungen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVerbindungen;
        private System.Windows.Forms.TabPage tabPageAbfahrtsplan;
        private System.Windows.Forms.Label labelNach;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox textBoxNach;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.Panel panelVerbindungen;
        private System.Windows.Forms.Label labelVerbindungen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVerbindungen;
        private System.Windows.Forms.Button buttonSuchen;
    }
}

