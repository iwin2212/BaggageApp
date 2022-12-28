namespace BaggageApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.DgvTitle = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.LblServerTime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.LblBelt = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flightTo = new MetroSet_UI.Controls.MetroSetLabel();
			this.flight = new MetroSet_UI.Controls.MetroSetLabel();
			this.update = new MetroSet_UI.Controls.MetroSetLabel();
			this.Airline = new MetroSet_UI.Controls.MetroSetLabel();
			this.STD = new MetroSet_UI.Controls.MetroSetLabel();
			this.ETA = new MetroSet_UI.Controls.MetroSetLabel();
			this.PnlRow = new System.Windows.Forms.Panel();
			this.FLPRow = new System.Windows.Forms.FlowLayoutPanel();
			this.DgvTitle.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PnlRow.SuspendLayout();
			this.SuspendLayout();
			// 
			// DgvTitle
			// 
			this.DgvTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.DgvTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DgvTitle.Controls.Add(this.tableLayoutPanel2);
			this.DgvTitle.Controls.Add(this.tableLayoutPanel1);
			this.DgvTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.DgvTitle.Location = new System.Drawing.Point(14, 60);
			this.DgvTitle.Name = "DgvTitle";
			this.DgvTitle.Size = new System.Drawing.Size(904, 90);
			this.DgvTitle.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.LblServerTime, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.LblBelt, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 42);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// LblServerTime
			// 
			this.LblServerTime.BackColor = System.Drawing.Color.Black;
			this.LblServerTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblServerTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LblServerTime.ForeColor = System.Drawing.Color.Gold;
			this.LblServerTime.Location = new System.Drawing.Point(286, 0);
			this.LblServerTime.Margin = new System.Windows.Forms.Padding(0);
			this.LblServerTime.Name = "LblServerTime";
			this.LblServerTime.Size = new System.Drawing.Size(616, 42);
			this.LblServerTime.TabIndex = 4;
			this.LblServerTime.Text = "Time";
			this.LblServerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Băng tải / Bag belt";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblBelt
			// 
			this.LblBelt.BackColor = System.Drawing.Color.Gainsboro;
			this.LblBelt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBelt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LblBelt.ForeColor = System.Drawing.Color.Black;
			this.LblBelt.Location = new System.Drawing.Point(243, 0);
			this.LblBelt.Name = "LblBelt";
			this.LblBelt.Size = new System.Drawing.Size(40, 42);
			this.LblBelt.TabIndex = 3;
			this.LblBelt.Text = "1";
			this.LblBelt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblBelt.Click += new System.EventHandler(this.label2_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.flightTo, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.flight, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.update, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.Airline, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.STD, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ETA, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 46);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// flightTo
			// 
			this.flightTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flightTo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.flightTo.IsDerivedStyle = true;
			this.flightTo.Location = new System.Drawing.Point(543, 0);
			this.flightTo.Name = "flightTo";
			this.flightTo.Size = new System.Drawing.Size(174, 46);
			this.flightTo.Style = MetroSet_UI.Enums.Style.Light;
			this.flightTo.StyleManager = null;
			this.flightTo.TabIndex = 18;
			this.flightTo.Text = "Chuyến bay";
			this.flightTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.flightTo.ThemeAuthor = "Narwin";
			this.flightTo.ThemeName = "MetroLite";
			// 
			// flight
			// 
			this.flight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.flight.IsDerivedStyle = true;
			this.flight.Location = new System.Drawing.Point(399, 0);
			this.flight.Name = "flight";
			this.flight.Size = new System.Drawing.Size(138, 46);
			this.flight.Style = MetroSet_UI.Enums.Style.Light;
			this.flight.StyleManager = null;
			this.flight.TabIndex = 17;
			this.flight.Text = "Chuyến bay";
			this.flight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.flight.ThemeAuthor = "Narwin";
			this.flight.ThemeName = "MetroLite";
			// 
			// update
			// 
			this.update.Dock = System.Windows.Forms.DockStyle.Fill;
			this.update.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.update.IsDerivedStyle = true;
			this.update.Location = new System.Drawing.Point(720, 0);
			this.update.Margin = new System.Windows.Forms.Padding(0);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(182, 46);
			this.update.Style = MetroSet_UI.Enums.Style.Light;
			this.update.StyleManager = null;
			this.update.TabIndex = 13;
			this.update.Text = "Cập nhật";
			this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.update.ThemeAuthor = "Narwin";
			this.update.ThemeName = "MetroLite";
			// 
			// Airline
			// 
			this.Airline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Airline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Airline.IsDerivedStyle = true;
			this.Airline.Location = new System.Drawing.Point(255, 0);
			this.Airline.Name = "Airline";
			this.Airline.Size = new System.Drawing.Size(138, 46);
			this.Airline.Style = MetroSet_UI.Enums.Style.Light;
			this.Airline.StyleManager = null;
			this.Airline.TabIndex = 2;
			this.Airline.Text = "Hãng";
			this.Airline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Airline.ThemeAuthor = "Narwin";
			this.Airline.ThemeName = "MetroLite";
			this.Airline.Click += new System.EventHandler(this.metroSetLabel2_Click);
			// 
			// STD
			// 
			this.STD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.STD.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.STD.IsDerivedStyle = true;
			this.STD.Location = new System.Drawing.Point(3, 0);
			this.STD.Name = "STD";
			this.STD.Size = new System.Drawing.Size(120, 46);
			this.STD.Style = MetroSet_UI.Enums.Style.Light;
			this.STD.StyleManager = null;
			this.STD.TabIndex = 1;
			this.STD.Text = "Lịch bay";
			this.STD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.STD.ThemeAuthor = "Narwin";
			this.STD.ThemeName = "MetroLite";
			this.STD.Click += new System.EventHandler(this.metroSetLabel1_Click);
			// 
			// ETA
			// 
			this.ETA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ETA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ETA.IsDerivedStyle = true;
			this.ETA.Location = new System.Drawing.Point(129, 0);
			this.ETA.Name = "ETA";
			this.ETA.Size = new System.Drawing.Size(120, 46);
			this.ETA.Style = MetroSet_UI.Enums.Style.Light;
			this.ETA.StyleManager = null;
			this.ETA.TabIndex = 0;
			this.ETA.Text = "Dự kiến";
			this.ETA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ETA.ThemeAuthor = "Narwin";
			this.ETA.ThemeName = "MetroLite";
			this.ETA.Click += new System.EventHandler(this.ETA_Click);
			// 
			// PnlRow
			// 
			this.PnlRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.PnlRow.Controls.Add(this.FLPRow);
			this.PnlRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlRow.ForeColor = System.Drawing.Color.DimGray;
			this.PnlRow.Location = new System.Drawing.Point(14, 150);
			this.PnlRow.Margin = new System.Windows.Forms.Padding(0);
			this.PnlRow.Name = "PnlRow";
			this.PnlRow.Size = new System.Drawing.Size(904, 261);
			this.PnlRow.TabIndex = 1;
			this.PnlRow.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRow_Paint);
			// 
			// FLPRow
			// 
			this.FLPRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FLPRow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FLPRow.Location = new System.Drawing.Point(0, 0);
			this.FLPRow.Margin = new System.Windows.Forms.Padding(0);
			this.FLPRow.Name = "FLPRow";
			this.FLPRow.Size = new System.Drawing.Size(904, 261);
			this.FLPRow.TabIndex = 0;
			// 
			// Form1
			// 
			this.AllowResize = false;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(932, 426);
			this.ControlBox = false;
			this.Controls.Add(this.PnlRow);
			this.Controls.Add(this.DgvTitle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Moveable = false;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 15);
			this.SmallLineColor1 = System.Drawing.Color.White;
			this.SmallLineColor2 = System.Drawing.Color.White;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DgvTitle.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.PnlRow.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel DgvTitle;
		private TableLayoutPanel tableLayoutPanel1;
		private MetroSet_UI.Controls.MetroSetLabel Airline;
		private MetroSet_UI.Controls.MetroSetLabel STD;
		private MetroSet_UI.Controls.MetroSetLabel ETA;
		private Panel PnlRow;
		private FlowLayoutPanel FLPRow;
		private MetroSet_UI.Controls.MetroSetLabel flightTo;
		private MetroSet_UI.Controls.MetroSetLabel flight;
		private MetroSet_UI.Controls.MetroSetLabel update;
		private Label label1;
		private Label LblBelt;
		private Label LblServerTime;
		private TableLayoutPanel tableLayoutPanel2;
	}
}