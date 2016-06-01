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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ouvinder));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVerbindungen = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelVerbindungen = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.textBoxNach = new System.Windows.Forms.TextBox();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.labelNach = new System.Windows.Forms.Label();
            this.labelVon = new System.Windows.Forms.Label();
            this.tabPageAbfahrtsplan = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAbfahrtsplan = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAbfahrtsplanSuchen = new System.Windows.Forms.Button();
            this.textBoxAbfahrtsplan = new System.Windows.Forms.TextBox();
            this.labelStation = new System.Windows.Forms.Label();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.gMapControlMap = new GMap.NET.WindowsForms.GMapControl();
            this.buttonsearchStationOnMap = new System.Windows.Forms.Button();
            this.textBoxStationForMap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShare = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageVerbindungen.SuspendLayout();
            this.tabPageAbfahrtsplan.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVerbindungen);
            this.tabControl1.Controls.Add(this.tabPageAbfahrtsplan);
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageVerbindungen
            // 
            this.tabPageVerbindungen.Controls.Add(this.labelShare);
            this.tabPageVerbindungen.Controls.Add(this.label2);
            this.tabPageVerbindungen.Controls.Add(this.tableLayoutPanelVerbindungen);
            this.tabPageVerbindungen.Controls.Add(this.dateTimePickerTime);
            this.tabPageVerbindungen.Controls.Add(this.labelTime);
            this.tabPageVerbindungen.Controls.Add(this.labelDatum);
            this.tabPageVerbindungen.Controls.Add(this.dateTimePickerDate);
            this.tabPageVerbindungen.Controls.Add(this.buttonSuchen);
            this.tabPageVerbindungen.Controls.Add(this.textBoxNach);
            this.tabPageVerbindungen.Controls.Add(this.textBoxVon);
            this.tabPageVerbindungen.Controls.Add(this.labelNach);
            this.tabPageVerbindungen.Controls.Add(this.labelVon);
            this.tabPageVerbindungen.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerbindungen.Name = "tabPageVerbindungen";
            this.tabPageVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungen.Size = new System.Drawing.Size(440, 421);
            this.tabPageVerbindungen.TabIndex = 0;
            this.tabPageVerbindungen.Text = "Verbindungen";
            this.tabPageVerbindungen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "       ";
            // 
            // tableLayoutPanelVerbindungen
            // 
            this.tableLayoutPanelVerbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelVerbindungen.AutoScroll = true;
            this.tableLayoutPanelVerbindungen.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelVerbindungen.ColumnCount = 4;
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelVerbindungen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelVerbindungen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanelVerbindungen.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanelVerbindungen.Name = "tableLayoutPanelVerbindungen";
            this.tableLayoutPanelVerbindungen.RowCount = 2;
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVerbindungen.Size = new System.Drawing.Size(434, 280);
            this.tableLayoutPanelVerbindungen.TabIndex = 16;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(300, 83);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerTime.TabIndex = 15;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(261, 86);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Time:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(3, 86);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(41, 13);
            this.labelDatum.TabIndex = 13;
            this.labelDatum.Text = "Datum:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(55, 83);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 11;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen.Location = new System.Drawing.Point(289, 109);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(143, 23);
            this.buttonSuchen.TabIndex = 10;
            this.buttonSuchen.Text = "Verbindungen suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
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
            this.tabPageAbfahrtsplan.Controls.Add(this.tableLayoutPanelAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.buttonAbfahrtsplanSuchen);
            this.tabPageAbfahrtsplan.Controls.Add(this.textBoxAbfahrtsplan);
            this.tabPageAbfahrtsplan.Controls.Add(this.labelStation);
            this.tabPageAbfahrtsplan.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbfahrtsplan.Name = "tabPageAbfahrtsplan";
            this.tabPageAbfahrtsplan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrtsplan.Size = new System.Drawing.Size(440, 421);
            this.tabPageAbfahrtsplan.TabIndex = 1;
            this.tabPageAbfahrtsplan.Text = "Abfahrtsplan";
            this.tabPageAbfahrtsplan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAbfahrtsplan
            // 
            this.tableLayoutPanelAbfahrtsplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAbfahrtsplan.AutoScroll = true;
            this.tableLayoutPanelAbfahrtsplan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAbfahrtsplan.ColumnCount = 3;
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAbfahrtsplan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAbfahrtsplan.Location = new System.Drawing.Point(3, 158);
            this.tableLayoutPanelAbfahrtsplan.Name = "tableLayoutPanelAbfahrtsplan";
            this.tableLayoutPanelAbfahrtsplan.RowCount = 2;
            this.tableLayoutPanelAbfahrtsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrtsplan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAbfahrtsplan.Size = new System.Drawing.Size(434, 263);
            this.tableLayoutPanelAbfahrtsplan.TabIndex = 3;
            // 
            // buttonAbfahrtsplanSuchen
            // 
            this.buttonAbfahrtsplanSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbfahrtsplanSuchen.Location = new System.Drawing.Point(289, 109);
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
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.gMapControlMap);
            this.tabPageMap.Controls.Add(this.buttonsearchStationOnMap);
            this.tabPageMap.Controls.Add(this.textBoxStationForMap);
            this.tabPageMap.Controls.Add(this.label1);
            this.tabPageMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(440, 421);
            this.tabPageMap.TabIndex = 2;
            this.tabPageMap.Text = "Karte";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // gMapControlMap
            // 
            this.gMapControlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlMap.Bearing = 0F;
            this.gMapControlMap.CanDragMap = true;
            this.gMapControlMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlMap.GrayScaleMode = false;
            this.gMapControlMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlMap.LevelsKeepInMemmory = 5;
            this.gMapControlMap.Location = new System.Drawing.Point(3, 138);
            this.gMapControlMap.MarkersEnabled = true;
            this.gMapControlMap.MaxZoom = 20;
            this.gMapControlMap.MinZoom = 7;
            this.gMapControlMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlMap.Name = "gMapControlMap";
            this.gMapControlMap.NegativeMode = false;
            this.gMapControlMap.PolygonsEnabled = true;
            this.gMapControlMap.RetryLoadTile = 0;
            this.gMapControlMap.RoutesEnabled = true;
            this.gMapControlMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlMap.ShowTileGridLines = false;
            this.gMapControlMap.Size = new System.Drawing.Size(434, 280);
            this.gMapControlMap.TabIndex = 5;
            this.gMapControlMap.Zoom = 7D;
            // 
            // buttonsearchStationOnMap
            // 
            this.buttonsearchStationOnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsearchStationOnMap.Location = new System.Drawing.Point(289, 109);
            this.buttonsearchStationOnMap.Name = "buttonsearchStationOnMap";
            this.buttonsearchStationOnMap.Size = new System.Drawing.Size(143, 23);
            this.buttonsearchStationOnMap.TabIndex = 2;
            this.buttonsearchStationOnMap.Text = "Station suchen";
            this.buttonsearchStationOnMap.UseVisualStyleBackColor = true;
            this.buttonsearchStationOnMap.Click += new System.EventHandler(this.buttonsearchStationOnMap_Click);
            // 
            // textBoxStationForMap
            // 
            this.textBoxStationForMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStationForMap.Location = new System.Drawing.Point(55, 25);
            this.textBoxStationForMap.Name = "textBoxStationForMap";
            this.textBoxStationForMap.Size = new System.Drawing.Size(377, 20);
            this.textBoxStationForMap.TabIndex = 1;
            this.textBoxStationForMap.TextChanged += new System.EventHandler(this.textBoxStationForMap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station:";
            // 
            // labelShare
            // 
            this.labelShare.Image = ((System.Drawing.Image)(resources.GetObject("labelShare.Image")));
            this.labelShare.Location = new System.Drawing.Point(3, 109);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(35, 26);
            this.labelShare.TabIndex = 18;
            this.labelShare.Click += new System.EventHandler(this.labelShare_Click);
            // 
            // ouvinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 447);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(456, 474);
            this.Name = "ouvinder";
            this.Text = "ÖVinder";
            this.Load += new System.EventHandler(this.ouvinder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageVerbindungen.ResumeLayout(false);
            this.tabPageVerbindungen.PerformLayout();
            this.tabPageAbfahrtsplan.ResumeLayout(false);
            this.tabPageAbfahrtsplan.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tabPageMap.PerformLayout();
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
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.TextBox textBoxAbfahrtsplan;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.Button buttonAbfahrtsplanSuchen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbfahrtsplan;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.Button buttonsearchStationOnMap;
        private System.Windows.Forms.TextBox textBoxStationForMap;
        private System.Windows.Forms.Label label1;
        private GMap.NET.WindowsForms.GMapControl gMapControlMap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVerbindungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelShare;
    }
}

