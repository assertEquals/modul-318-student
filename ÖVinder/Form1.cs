using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖVinder
{
    public partial class ouvinder : Form
    {
        private ITransport transport;
        private DateConverter dateConverter = new DateConverter();
        public ouvinder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (panelVerbindungen.Visible)
            {
            panelVerbindungen.Visible = false;
            labelVerbindungen.Text = "Verbindungen <";
            }
            else
            {
                panelVerbindungen.Visible = true;
                labelVerbindungen.Text = "Verbindungen v";
            }
        }

        private void buttonSuchen_Click(object sender, EventArgs e) { 
            transport = new Transport();
            Connections connection = transport.GetConnections(textBoxVon.Text, textBoxNach.Text);
            DateTime dateTime = new DateTime();
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Abfahrt" } );
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Fahrtdauer" });
            tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = "Gleis" });
            int rowcount = 0;
            foreach(Connection targetConnection in connection.ConnectionList){
                int colcount = 0;
                string duration = targetConnection.Duration.ToString().Substring(targetConnection.Duration.ToString().Length - 7);
                dateTime = Convert.ToDateTime(targetConnection.From.Departure.ToString());
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() }, colcount, rowcount);
                colcount++;
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = duration });
                colcount++;
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.Platform });
                rowcount += 2;
            }

        }
    }
}
