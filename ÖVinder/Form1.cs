﻿using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖVinder {
    public partial class ouvinder : Form {
        private ITransport transport = new Transport();
        private DateConverter dateConverter = new DateConverter();
        public ouvinder() {
            InitializeComponent();
            printHeader();
        }

        private void ouvinder_Load(object sender, EventArgs e) {
            textBoxVon.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxVon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxNach.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxNach.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxAbfahrtsplan.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxAbfahrtsplan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void printHeader() {
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None});
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Ankunft", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Fahrtdauer", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelAbfahrtsplan.Controls.Add(new Label() { Text = "Abfahrt", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelAbfahrtsplan.Controls.Add(new Label() { Text = "Ankunft", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelAbfahrtsplan.Controls.Add(new Label() { Text = "Fahrtdauer", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
            tableLayoutPanelAbfahrtsplan.Controls.Add(new Label() { Text = "Gleis", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None });
        }

        private void label1_Click(object sender, EventArgs e) {
            if (panelVerbindungen.Visible) {
                labelVerbindungen.Text = "Verbindungen <";
                panelVerbindungen.Visible = false;
            }
            else {
                labelVerbindungen.Text = "Verbindungen v";
                panelVerbindungen.Visible = true;
            }
        }

        private void labelAbfahrtsplan_Click(object sender, EventArgs e) {
            if (tableLayoutPanelAbfahrtsplan.Visible) {
                labelAbfahrtsplan.Text = "Verbindungen <";
                tableLayoutPanelAbfahrtsplan.Visible = false;
            }
            else {
                labelAbfahrtsplan.Text = "Verbindungen v";
                tableLayoutPanelAbfahrtsplan.Visible = true;
            }
        }

        private void buttonSuchen_Click(object sender, EventArgs e) {
            searchConnections();
        }

    private void searchConnections() {
        //clear table and insert headers
        tableLayoutPanelVerbindungen.Controls.Clear();
        printHeader();

        Connections connection = transport.GetConnections(textBoxVon.Text, textBoxNach.Text);


        //Fill list with connections
        int rowcount = 1;
        foreach (Connection targetConnection in connection.ConnectionList) {

            //create datetime from string
            DateTime departure = Convert.ToDateTime(targetConnection.From.Departure.ToString());
            DateTime arrival = Convert.ToDateTime(targetConnection.To.Arrival.ToString());

            //Convert strings to insert
            String departTime = dateConverter.convertIntToTimeString(departure.Hour) + ":" + dateConverter.convertIntToTimeString(departure.Minute);
            String arrivalTime = dateConverter.convertIntToTimeString(arrival.Hour) + ":" + dateConverter.convertIntToTimeString(arrival.Minute);
            String duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);
            String platform = targetConnection.From.Platform.ToString();

            int colcount = 0;

            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = departTime,AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None }, colcount, rowcount);
            colcount++;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = arrivalTime, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None }, colcount, rowcount);
            colcount++;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = duration, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None }, colcount, rowcount);
            colcount++;
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = platform, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None }, colcount, rowcount);
            rowcount++;
        }

     }

        private void onEnterPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (char)13) {
                searchConnections();
            }
        }

        private void autoCompleteStations(TextBox textBox) {
            if(textBox.Text.Length >= 3) {
                List<String> suggestetStations = new List<string>();
                List<Station> stations = transport.GetStations(textBox.Text).StationList;
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                foreach (Station station in stations) {
                    source.Add(station.Name);
                }
                textBox.AutoCompleteCustomSource = source;
            }
        }

        private void textBoxVon_TextChanged(object sender, EventArgs e) {
            StationBoardRoot sb = transport.GetStationBoard("Sursee");
            foreach(StationBoard board in sb.Entries) {
                board.Name;
            }
            autoCompleteStations(textBoxVon);
        }

        private void textBoxNach_TextChanged(object sender, EventArgs e) {
            autoCompleteStations(textBoxNach);
        }

        private void textBoxAbfahrtsplan_TextChanged(object sender, EventArgs e) {
            autoCompleteStations(textBoxAbfahrtsplan);
        }
    }
}
