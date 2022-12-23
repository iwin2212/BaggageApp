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
			dt.Columns.Add("STD");
			dt.Columns.Add("ETA");
			dt.Columns.Add("Airlines");
			dt.Columns.Add("FlightNum");
			dt.Columns.Add("FlightTo");

			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL6822", "BKK-HAN" });
			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL7000", "BKK-HAN" });
			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL8002", "BKK-HAN" });
			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL9022", "BKK-HAN" });
			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL1022", "BKK-HAN" });
			dt.Rows.Add(new object[] { "1030", "1855", "Vn", "BL3322", "BKK-HAN" });

			for (var i = 0; i < 6; i++)
			{
				var uCRow = new UCRow()
				{
					STD = dt.Rows[i]["STD"].ToString(),
					ETA = dt.Rows[i]["ETA"].ToString(),
					Airlines = dt.Rows[i]["Airlines"].ToString(),
					FlightNum = dt.Rows[i]["FlightNum"].ToString(),
					FlightTo = dt.Rows[i]["FlightTo"].ToString(),
				};
				uCRow.Width = FLPRow.Width;
				uCRow.Height = FLPRow.Height / 6;

				FLPRow.Controls.Add(uCRow);
			}
		}

		private void PnlRow_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ETA_Click(object sender, EventArgs e)
		{

		}

		private void metroSetLabel4_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void metroSetLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}