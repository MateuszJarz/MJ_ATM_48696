namespace MJ_ATM_48696
{
	partial class ATM
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mj_lbl_ATM = new System.Windows.Forms.Label();
			this.mj_cb_value = new System.Windows.Forms.ComboBox();
			this.mj_dgv_window = new System.Windows.Forms.DataGridView();
			this.LiczbaNominałów = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WartośćNominałów = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rodzajnominału = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RodzajWaluty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mj_rdB_defaultCardinality = new System.Windows.Forms.RadioButton();
			this.mj_rdB_randomCardionality = new System.Windows.Forms.RadioButton();
			this.mj_txtb_amount = new System.Windows.Forms.TextBox();
			this.mj_btn_accept = new System.Windows.Forms.Button();
			this.mj_btn_Reset = new System.Windows.Forms.Button();
			this.mj_btn_Exit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.mj_lbl_KwotaDoWypłaty = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.mj_lbl_amountToPay = new System.Windows.Forms.Label();
			this.mj_txtDolnaGranica = new System.Windows.Forms.TextBox();
			this.mj_txtGórnaGranica = new System.Windows.Forms.TextBox();
			this.mj_lblDolnaGranica = new System.Windows.Forms.Label();
			this.mj_lblGórnaGranica = new System.Windows.Forms.Label();
			this.mj_btnAkceptacjaNominałów = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.mj_dgv_window)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// mj_lbl_ATM
			// 
			this.mj_lbl_ATM.AutoSize = true;
			this.mj_lbl_ATM.Font = new System.Drawing.Font("Shrikhand", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mj_lbl_ATM.Location = new System.Drawing.Point(452, 9);
			this.mj_lbl_ATM.Name = "mj_lbl_ATM";
			this.mj_lbl_ATM.Size = new System.Drawing.Size(111, 51);
			this.mj_lbl_ATM.TabIndex = 0;
			this.mj_lbl_ATM.Text = "ATM";
			// 
			// mj_cb_value
			// 
			this.mj_cb_value.FormattingEnabled = true;
			this.mj_cb_value.Items.AddRange(new object[] {
            "PLN",
            "USD",
            "EURO",
            "GBP"});
			this.mj_cb_value.Location = new System.Drawing.Point(15, 39);
			this.mj_cb_value.Name = "mj_cb_value";
			this.mj_cb_value.Size = new System.Drawing.Size(121, 21);
			this.mj_cb_value.TabIndex = 2;
			// 
			// mj_dgv_window
			// 
			this.mj_dgv_window.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mj_dgv_window.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiczbaNominałów,
            this.WartośćNominałów,
            this.Rodzajnominału,
            this.RodzajWaluty});
			this.mj_dgv_window.Location = new System.Drawing.Point(220, 367);
			this.mj_dgv_window.Name = "mj_dgv_window";
			this.mj_dgv_window.Size = new System.Drawing.Size(467, 239);
			this.mj_dgv_window.TabIndex = 3;
			// 
			// LiczbaNominałów
			// 
			this.LiczbaNominałów.HeaderText = "LiczbaNominałów";
			this.LiczbaNominałów.Name = "LiczbaNominałów";
			// 
			// WartośćNominałów
			// 
			this.WartośćNominałów.HeaderText = "WartośćNominałów";
			this.WartośćNominałów.Name = "WartośćNominałów";
			// 
			// Rodzajnominału
			// 
			this.Rodzajnominału.HeaderText = "Rodzaj nominału";
			this.Rodzajnominału.Name = "Rodzajnominału";
			// 
			// RodzajWaluty
			// 
			this.RodzajWaluty.HeaderText = "RodzajWaluty";
			this.RodzajWaluty.Name = "RodzajWaluty";
			// 
			// mj_rdB_defaultCardinality
			// 
			this.mj_rdB_defaultCardinality.AutoSize = true;
			this.mj_rdB_defaultCardinality.Location = new System.Drawing.Point(164, 63);
			this.mj_rdB_defaultCardinality.Name = "mj_rdB_defaultCardinality";
			this.mj_rdB_defaultCardinality.Size = new System.Drawing.Size(167, 17);
			this.mj_rdB_defaultCardinality.TabIndex = 4;
			this.mj_rdB_defaultCardinality.TabStop = true;
			this.mj_rdB_defaultCardinality.Text = "Liczność ustawiana domyślnie";
			this.mj_rdB_defaultCardinality.UseVisualStyleBackColor = true;
			this.mj_rdB_defaultCardinality.CheckedChanged += new System.EventHandler(this.mj_rdB_defaultCardinality_CheckedChanged);
			// 
			// mj_rdB_randomCardionality
			// 
			this.mj_rdB_randomCardionality.AutoSize = true;
			this.mj_rdB_randomCardionality.Location = new System.Drawing.Point(358, 63);
			this.mj_rdB_randomCardionality.Name = "mj_rdB_randomCardionality";
			this.mj_rdB_randomCardionality.Size = new System.Drawing.Size(217, 17);
			this.mj_rdB_randomCardionality.TabIndex = 5;
			this.mj_rdB_randomCardionality.TabStop = true;
			this.mj_rdB_randomCardionality.Text = "Liczność ustawiana losowo przez Klienta";
			this.mj_rdB_randomCardionality.UseVisualStyleBackColor = true;
			this.mj_rdB_randomCardionality.CheckedChanged += new System.EventHandler(this.mj_rdB_randomCardionality_CheckedChanged);
			// 
			// mj_txtb_amount
			// 
			this.mj_txtb_amount.Location = new System.Drawing.Point(90, 144);
			this.mj_txtb_amount.Name = "mj_txtb_amount";
			this.mj_txtb_amount.Size = new System.Drawing.Size(100, 20);
			this.mj_txtb_amount.TabIndex = 6;
			this.mj_txtb_amount.Visible = false;
			// 
			// mj_btn_accept
			// 
			this.mj_btn_accept.Location = new System.Drawing.Point(89, 175);
			this.mj_btn_accept.Name = "mj_btn_accept";
			this.mj_btn_accept.Size = new System.Drawing.Size(75, 23);
			this.mj_btn_accept.TabIndex = 7;
			this.mj_btn_accept.Text = "Akceptacja";
			this.mj_btn_accept.UseVisualStyleBackColor = true;
			this.mj_btn_accept.Visible = false;
			this.mj_btn_accept.Click += new System.EventHandler(this.mj_btn_accept_Click);
			// 
			// mj_btn_Reset
			// 
			this.mj_btn_Reset.Location = new System.Drawing.Point(693, 455);
			this.mj_btn_Reset.Name = "mj_btn_Reset";
			this.mj_btn_Reset.Size = new System.Drawing.Size(75, 23);
			this.mj_btn_Reset.TabIndex = 9;
			this.mj_btn_Reset.Text = "Resetuj";
			this.mj_btn_Reset.UseVisualStyleBackColor = true;
			this.mj_btn_Reset.Visible = false;
			this.mj_btn_Reset.Click += new System.EventHandler(this.mj_btn_Reset_Click);
			// 
			// mj_btn_Exit
			// 
			this.mj_btn_Exit.Location = new System.Drawing.Point(693, 484);
			this.mj_btn_Exit.Name = "mj_btn_Exit";
			this.mj_btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.mj_btn_Exit.TabIndex = 10;
			this.mj_btn_Exit.Text = "KONIEC";
			this.mj_btn_Exit.UseVisualStyleBackColor = true;
			this.mj_btn_Exit.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Wybierz rodzaj waluty";
			// 
			// mj_lbl_KwotaDoWypłaty
			// 
			this.mj_lbl_KwotaDoWypłaty.AutoSize = true;
			this.mj_lbl_KwotaDoWypłaty.Location = new System.Drawing.Point(96, 128);
			this.mj_lbl_KwotaDoWypłaty.Name = "mj_lbl_KwotaDoWypłaty";
			this.mj_lbl_KwotaDoWypłaty.Size = new System.Drawing.Size(91, 13);
			this.mj_lbl_KwotaDoWypłaty.TabIndex = 13;
			this.mj_lbl_KwotaDoWypłaty.Text = "KwotaDoWypłaty";
			this.mj_lbl_KwotaDoWypłaty.Visible = false;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// mj_lbl_amountToPay
			// 
			this.mj_lbl_amountToPay.AutoSize = true;
			this.mj_lbl_amountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.mj_lbl_amountToPay.ForeColor = System.Drawing.Color.DarkRed;
			this.mj_lbl_amountToPay.Location = new System.Drawing.Point(228, 323);
			this.mj_lbl_amountToPay.Name = "mj_lbl_amountToPay";
			this.mj_lbl_amountToPay.Size = new System.Drawing.Size(0, 24);
			this.mj_lbl_amountToPay.TabIndex = 14;
			// 
			// mj_txtDolnaGranica
			// 
			this.mj_txtDolnaGranica.Location = new System.Drawing.Point(310, 178);
			this.mj_txtDolnaGranica.Name = "mj_txtDolnaGranica";
			this.mj_txtDolnaGranica.Size = new System.Drawing.Size(100, 20);
			this.mj_txtDolnaGranica.TabIndex = 15;
			this.mj_txtDolnaGranica.Visible = false;
			// 
			// mj_txtGórnaGranica
			// 
			this.mj_txtGórnaGranica.Location = new System.Drawing.Point(484, 178);
			this.mj_txtGórnaGranica.Name = "mj_txtGórnaGranica";
			this.mj_txtGórnaGranica.Size = new System.Drawing.Size(100, 20);
			this.mj_txtGórnaGranica.TabIndex = 16;
			this.mj_txtGórnaGranica.Visible = false;
			// 
			// mj_lblDolnaGranica
			// 
			this.mj_lblDolnaGranica.AutoSize = true;
			this.mj_lblDolnaGranica.Location = new System.Drawing.Point(307, 161);
			this.mj_lblDolnaGranica.Name = "mj_lblDolnaGranica";
			this.mj_lblDolnaGranica.Size = new System.Drawing.Size(168, 13);
			this.mj_lblDolnaGranica.TabIndex = 17;
			this.mj_lblDolnaGranica.Text = "Dolna granica przedziału liczności";
			this.mj_lblDolnaGranica.Visible = false;
			// 
			// mj_lblGórnaGranica
			// 
			this.mj_lblGórnaGranica.AutoSize = true;
			this.mj_lblGórnaGranica.Location = new System.Drawing.Point(484, 161);
			this.mj_lblGórnaGranica.Name = "mj_lblGórnaGranica";
			this.mj_lblGórnaGranica.Size = new System.Drawing.Size(169, 13);
			this.mj_lblGórnaGranica.TabIndex = 18;
			this.mj_lblGórnaGranica.Text = "Górna granica przedziału liczności";
			this.mj_lblGórnaGranica.Visible = false;
			// 
			// mj_btnAkceptacjaNominałów
			// 
			this.mj_btnAkceptacjaNominałów.Location = new System.Drawing.Point(373, 220);
			this.mj_btnAkceptacjaNominałów.Name = "mj_btnAkceptacjaNominałów";
			this.mj_btnAkceptacjaNominałów.Size = new System.Drawing.Size(181, 34);
			this.mj_btnAkceptacjaNominałów.TabIndex = 19;
			this.mj_btnAkceptacjaNominałów.Text = "Akceptacja Nominałów";
			this.mj_btnAkceptacjaNominałów.UseVisualStyleBackColor = true;
			this.mj_btnAkceptacjaNominałów.Visible = false;
			this.mj_btnAkceptacjaNominałów.Click += new System.EventHandler(this.mj_btnAkceptacjaNominałów_Click);
			// 
			// ATM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(912, 657);
			this.Controls.Add(this.mj_btnAkceptacjaNominałów);
			this.Controls.Add(this.mj_lblGórnaGranica);
			this.Controls.Add(this.mj_lblDolnaGranica);
			this.Controls.Add(this.mj_txtGórnaGranica);
			this.Controls.Add(this.mj_txtDolnaGranica);
			this.Controls.Add(this.mj_lbl_amountToPay);
			this.Controls.Add(this.mj_lbl_KwotaDoWypłaty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mj_btn_Exit);
			this.Controls.Add(this.mj_btn_Reset);
			this.Controls.Add(this.mj_btn_accept);
			this.Controls.Add(this.mj_txtb_amount);
			this.Controls.Add(this.mj_rdB_randomCardionality);
			this.Controls.Add(this.mj_rdB_defaultCardinality);
			this.Controls.Add(this.mj_dgv_window);
			this.Controls.Add(this.mj_cb_value);
			this.Controls.Add(this.mj_lbl_ATM);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ATM";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "ATM";
			this.Load += new System.EventHandler(this.ATM_Load);
			((System.ComponentModel.ISupportInitialize)(this.mj_dgv_window)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label mj_lbl_ATM;
		private System.Windows.Forms.ComboBox mj_cb_value;
		private System.Windows.Forms.DataGridView mj_dgv_window;
		private System.Windows.Forms.RadioButton mj_rdB_defaultCardinality;
		private System.Windows.Forms.RadioButton mj_rdB_randomCardionality;
		private System.Windows.Forms.TextBox mj_txtb_amount;
		private System.Windows.Forms.Button mj_btn_accept;
		private System.Windows.Forms.Button mj_btn_Reset;
		private System.Windows.Forms.Button mj_btn_Exit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label mj_lbl_KwotaDoWypłaty;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Label mj_lbl_amountToPay;
		private System.Windows.Forms.DataGridViewTextBoxColumn LiczbaNominałów;
		private System.Windows.Forms.DataGridViewTextBoxColumn WartośćNominałów;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rodzajnominału;
		private System.Windows.Forms.DataGridViewTextBoxColumn RodzajWaluty;
		private System.Windows.Forms.Button mj_btnAkceptacjaNominałów;
		private System.Windows.Forms.Label mj_lblGórnaGranica;
		private System.Windows.Forms.Label mj_lblDolnaGranica;
		private System.Windows.Forms.TextBox mj_txtGórnaGranica;
		private System.Windows.Forms.TextBox mj_txtDolnaGranica;
	}
}

