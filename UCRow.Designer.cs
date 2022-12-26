namespace BaggageApp
{
	partial class UCRow
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.LblFlightTo = new MetroSet_UI.Controls.MetroSetLabel();
			this.LblSTD = new MetroSet_UI.Controls.MetroSetLabel();
			this.LblETA = new MetroSet_UI.Controls.MetroSetLabel();
			this.LblFlightNo = new MetroSet_UI.Controls.MetroSetLabel();
			this.PbAirlines = new System.Windows.Forms.PictureBox();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.LblStatus = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbAirlines)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
			this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.LblFlightTo, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblSTD, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblETA, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblFlightNo, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.PbAirlines, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.BtnUpdate, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblStatus, 5, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 87);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// LblFlightTo
			// 
			this.LblFlightTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblFlightTo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblFlightTo.IsDerivedStyle = true;
			this.LblFlightTo.Location = new System.Drawing.Point(603, 0);
			this.LblFlightTo.Name = "LblFlightTo";
			this.LblFlightTo.Size = new System.Drawing.Size(144, 67);
			this.LblFlightTo.Style = MetroSet_UI.Enums.Style.Light;
			this.LblFlightTo.StyleManager = null;
			this.LblFlightTo.TabIndex = 16;
			this.LblFlightTo.Text = "From/To";
			this.LblFlightTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblFlightTo.ThemeAuthor = "Narwin";
			this.LblFlightTo.ThemeName = "MetroLite";
			// 
			// LblSTD
			// 
			this.LblSTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblSTD.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblSTD.IsDerivedStyle = true;
			this.LblSTD.Location = new System.Drawing.Point(153, 0);
			this.LblSTD.Name = "LblSTD";
			this.LblSTD.Size = new System.Drawing.Size(144, 67);
			this.LblSTD.Style = MetroSet_UI.Enums.Style.Light;
			this.LblSTD.StyleManager = null;
			this.LblSTD.TabIndex = 8;
			this.LblSTD.Text = "Schedule";
			this.LblSTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblSTD.ThemeAuthor = "Narwin";
			this.LblSTD.ThemeName = "MetroLite";
			// 
			// LblETA
			// 
			this.LblETA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblETA.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblETA.IsDerivedStyle = true;
			this.LblETA.Location = new System.Drawing.Point(3, 0);
			this.LblETA.Name = "LblETA";
			this.LblETA.Size = new System.Drawing.Size(144, 67);
			this.LblETA.Style = MetroSet_UI.Enums.Style.Light;
			this.LblETA.StyleManager = null;
			this.LblETA.TabIndex = 7;
			this.LblETA.Text = "Estimate";
			this.LblETA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblETA.ThemeAuthor = "Narwin";
			this.LblETA.ThemeName = "MetroLite";
			// 
			// LblFlightNo
			// 
			this.LblFlightNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblFlightNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblFlightNo.IsDerivedStyle = true;
			this.LblFlightNo.Location = new System.Drawing.Point(453, 0);
			this.LblFlightNo.Name = "LblFlightNo";
			this.LblFlightNo.Size = new System.Drawing.Size(144, 67);
			this.LblFlightNo.Style = MetroSet_UI.Enums.Style.Light;
			this.LblFlightNo.StyleManager = null;
			this.LblFlightNo.TabIndex = 9;
			this.LblFlightNo.Text = "Flight";
			this.LblFlightNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblFlightNo.ThemeAuthor = "Narwin";
			this.LblFlightNo.ThemeName = "MetroLite";
			// 
			// PbAirlines
			// 
			this.PbAirlines.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PbAirlines.Location = new System.Drawing.Point(303, 3);
			this.PbAirlines.Name = "PbAirlines";
			this.PbAirlines.Size = new System.Drawing.Size(144, 61);
			this.PbAirlines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PbAirlines.TabIndex = 17;
			this.PbAirlines.TabStop = false;
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnUpdate.AutoSize = true;
			this.BtnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BtnUpdate.ForeColor = System.Drawing.Color.Black;
			this.BtnUpdate.Location = new System.Drawing.Point(788, 19);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(76, 28);
			this.BtnUpdate.TabIndex = 18;
			this.BtnUpdate.Text = "Cập nhật";
			this.BtnUpdate.UseVisualStyleBackColor = false;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// LblStatus
			// 
			this.LblStatus.AutoSize = true;
			this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblStatus.ForeColor = System.Drawing.Color.Black;
			this.LblStatus.Location = new System.Drawing.Point(753, 67);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(146, 20);
			this.LblStatus.TabIndex = 19;
			// 
			// UCRow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UCRow";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Size = new System.Drawing.Size(904, 89);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbAirlines)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private MetroSet_UI.Controls.MetroSetLabel LblFlightTo;
		private MetroSet_UI.Controls.MetroSetLabel LblFlightNo;
		private MetroSet_UI.Controls.MetroSetLabel LblSTD;
		private MetroSet_UI.Controls.MetroSetLabel LblETA;
		private PictureBox PbAirlines;
		private Button BtnUpdate;
		private Label LblStatus;
	}
}
