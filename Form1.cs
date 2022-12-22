using System.Data;
using MetroSet_UI.Forms;

namespace BaggageApp
{
	public partial class Form1 : MetroSetForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void metroSetLabel2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var dt = new DataTable();
			//dt.Columns.Add("Id");
			//dt.Columns.Add("Id");
			//dt.Columns.Add("Id");
			//dt.Columns.Add("Id");
			//dt.Columns.Add("Id");
			//dt.Columns.Add("Id");
			for (var i = 0; i < 6; i++)
			{
				var uCRow = new UCRow();
				uCRow.Width = FLPRow.Width;
				uCRow.Height = FLPRow.Height/6;
				FLPRow.Controls.Add(uCRow);
			}
		}

		private void PnlRow_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}