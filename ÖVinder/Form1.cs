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

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            transport = new Transport();
            Connections connection = transport.GetConnections("Luzern", "Sursee");
            int rowcount = 0;
            foreach(Connection targetConnection in connection.ConnectionList){
                tableLayoutPanelVerbindungen.Controls.Add(new Label() { Text = targetConnection.From.DepartureTimestamp }, 0, rowcount);
                rowcount++;
            }

        }
    }
}
