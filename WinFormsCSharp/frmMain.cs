using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCSharp
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnHello_Click(object sender, EventArgs e)
		{
			lblHello.Text = "Hello World";
			txtHello.Text = "Hello World";

			MessageBox.Show("Hello World");
		}
	}
}
