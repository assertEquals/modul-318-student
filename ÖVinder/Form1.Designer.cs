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
            this.textBoxNach = new System.Windows.Forms.TextBox();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.labelNach = new System.Windows.Forms.Label();
            this.labelVon = new System.Windows.Forms.Label();
            this.tabPageAbfahrtsplan = new System.Windows.Forms.TabPage();
            this.labelAbfahrtsplan = new System.Windows.Forms.Label();
            this.buttonAbfahrtsplanSuchen = new System.Windows.Forms.Button();
            this.textBoxAbfahrtsplan = new System.Windows.Forms.TextBox();
            this.labelStation = new System.Windows.Forms.Label();
            this.tableLayoutPanelAbfahrtsplan = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.panelVerbindungen.SuspendLayout();
            this.tabPageAbfahrtsplan.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(448, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.buttonSuchen);
            this.tabPageVerbindungen.Controls.Add(this.panelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.labelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.textBoxNach);
            this.tabPageVerbindungen.Controls.Add(this.textBoxVon);
            this.tabPageVerbindungen.Controls.Add(this.labelNach);
            this.tabPageVerbindungen.Controls.Add(this.labelVon);
            this.tabPageVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerbindungen.Name = "tabPageVerbindungen";
            this.tabPageVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungen.Size = new System.Drawing.Size(440, 390);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen.Location = new System.Drawing.Point(289, 80);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(143, 23);
            this.buttonSuchen.TabIndex = 10;
            this.buttonSuchen.Text = "Verbindungen suchen";
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
            this.panelVerbindungen.Size = new System.Drawing.Size(434, 263);
            this.panelVerbindungen.TabIndex = 9;
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.AutoScroll = true;
            this.tableLayoutPanelVerbindungen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelVerbindungen.ColumnCount = 4;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVerbindungen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 2;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(434, 263);
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
            // textBoxNach
            // 
            this.textBoxNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNach.Location = new System.Drawing.Point(55, 54);
            this.textBoxNach.Name = "textBoxNach";
            this.textBoxNach.Size = new System.Drawing.Size(377, 20);
            this.textBoxNach.TabIndex = 3;
            this.textBoxNach.TextChanged += new System.EventHandler(this.textBoxNach_TextChanged);
            this.textBoxNach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEnterPress);
            // 
            // textBoxVon
            // 
            this.textBoxVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVon.Location = new System.Drawing.Point(55, 25);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(377, 20);
            this.textBoxVon.TabIndex = 2;
            this.textBoxVon.TextChanged += new System.EventHandler(this.textBoxVon_TextChanged);
            this.textBoxVon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onEnterPress);
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
            this.tabPageAbfahrtsplan.Controls.Add(this.labelAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.tableLayoutPanelAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.buttonAbfahrtsplanSuchen);
            this.tabPageAbfahrtsplan.Controls.Add(this.textBoxAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.labelStation);
            this.tabPageAbfahrtsplan.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbfahrtsplan.Name = "tabPageAbfahrtsplan";
            this.tabPageAbfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrtsplan.Size = new System.Drawing.Size(440, 390);
            this.tabPageAbfahrtsplan.TabIndex = 1;
            this.tabPageAbfahrtsplan.Text = "Abfahrtsplan";
            this.tabPageAbfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // labelAbfahrtsplan
            // 
            this.labelAbfahrtsplan.AutoSize = true;
            this.labelAbfahrtsplan.Location = new System.Drawing.Point(8, 111);
            this.labelAbfahrtsplan.Name = "labelAbfahrtsplan";
            this.labelAbfahrtsplan.Size = new System.Drawing.Size(82, 13);
            this.labelAbfahrtsplan.TabIndex = 9;
            this.labelAbfahrtsplan.Text = "Verbindungen v";
            this.labelAbfahrtsplan.Click += new System.EventHandler(this.labelAbfahrtsplan_Click);
            // 
            // buttonAbfahrtsplanSuchen
            // 
            this.buttonAbfahrtsplanSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbfahrtsplanSuchen.Location = new System.Drawing.Point(289, 80);
            this.buttonAbfahrtsplanSuchen.Name = "buttonAbfahrtsplanSuchen";
            this.buttonAbfahrtsplanSuchen.Size = new System.Drawing.Size(143, 23);
            this.buttonAbfahrtsplanSuchen.TabIndex = 2;
            this.buttonAbfahrtsplanSuchen.Text = "Verbindungen suchen";
            this.buttonAbfahrtsplanSuchen.UseVisualStyleBackColor = true;
            this.buttonAbfahrtsplanSuchen.Click += new System.EventHandler(this.buttonAbfahrtsplanSuchen_Click);
            // 
            // textBoxAbfahrtsplan
            // 
            this.textBoxAbfahrtsplan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAbfahrtsplan.Location = new System.Drawing.Point(55, 25);
            this.textBoxAbfahrtsplan.Name = "textBoxAbfahrtsplan";
            this.textBoxAbfahrtsplan.Size = new System.Drawing.Size(377, 20);
            this.textBoxAbfahrtsplan.TabIndex = 1;
            this.textBoxAbfahrtsplan.TextChanged += new System.EventHandler(this.textBoxAbfahrtsplan_TextChanged);
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(6, 28);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(43, 13);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Station:";
            // 
            // tableLayoutPanelAbfahrtsplan
            // 
            this.tableLayoutPanelAbfahrtsplan.AutoScroll = true;
            this.tableLayoutPanelAbfahrtsplan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAbfahrtsplan.ColumnCount = 3;
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAbfahrtsplan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelAbfahrtsplan.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanelAbfahrtsplan.Name = "tableLayoutPanelAbfahrtsplan";
            this.tableLayoutPanelAbfahrtsplan.RowCount = 2;
            this.tableLayoutPanelAbfahrtsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrtsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrtsplan.Size = new System.Drawing.Size(434, 260);
            this.tableLayoutPanelAbfahrtsplan.TabIndex = 3;
            // 
            // ouvinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 416);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(456, 443);
            this.Name = "ouvinder";
            this.Text = "ÖVinder";
            this.Load += new System.EventHandler(this.ouvinder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.panelVerbindungen.ResumeLayout(false);
            this.tabPageAbfahrtsplan.ResumeLayout(false);
            this.tabPageAbfahrtsplan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVerbindungen;
        private System.Windows.Forms.TabPage tabPageAbfahrtsplan;
        private System.Windows.Forms.Label labelNach;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.TextBox textBoxNach;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.Panel panelVerbindungen;
        private System.Windows.Forms.Label labelVerbindungen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVerbindungen;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.TextBox textBoxAbfahrtsplan;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.Label labelAbfahrtsplan;
        private System.Windows.Forms.Button buttonAbfahrtsplanSuchen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbfahrtsplan;
    }
}

