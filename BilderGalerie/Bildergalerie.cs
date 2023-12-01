using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilderGalerie
{
    public partial class Bildergalerie : Form
    {
        public Bildergalerie()
        {
            InitializeComponent();
        }

        List <string> dateien = new List<string>();

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                dateien.Add(path);
                listBoxDateien.Items.Add(path); // TODO eventuell nur den Dateinamen anzeigen, nicht den kompletten Pfad
                
            }
        }

        private void listBoxDateien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDateien.SelectedIndex;
            if(index >= 0 && index < dateien.Count)
            {
                string path = dateien[index];
                pictureBoxBild.Image = Image.FromFile(path);
                // TODO Bild anzeigen
            }
            else
            {
                pictureBoxBild.Image = null;
                // TODO kein Bild anzeigen
            }
        }
    }
}
