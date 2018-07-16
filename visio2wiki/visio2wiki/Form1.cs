using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visio2wiki
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Sind Sie sicher, dass Sie die Anwendung beenden möchten?", "Anwendung beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void benutzeranleitungToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dieses kleine Programm konvertiert Visio-Prozesse in \"klickbare\" SVG-Grafiken und lädt sie in ein gegebenes Dokuwiki hoch.\nTest\nTest\nTest");
			MessageBox.Show(openFileDialog1.FileName);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tbxProjectName.Text = openFileDialog1.FileName;
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbxTargetFolder.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
