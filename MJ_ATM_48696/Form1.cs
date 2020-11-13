using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJ_ATM_48696
{
	
	public partial class ATM : Form
	{
		const ushort MaxCardinalityOfValue = 100;
		const int TheLowwestValueBanknote = 10;



		/// ///////////////////////////////////////////
		//declaration of an array for the sotrage of value // Nominały
		float[] ValueOfMoney = { 200, 100, 50, 20, 10, 5, 2, 0.5F, 0.2F, 0, 1F };

		/*defiinicja nowego typu danych (rekord danych) na potrzeby przechowania 
		  par liczb w tablicy ContainerOfDenominations */

	

		

		/// ///////////////////////////////////////////

		struct Denominations{
			public int Cardinality; // liczność
			public float Value; // Wartość

		}

		Denominations[] ContainerOfDenominations; //Declaration reference variable for ContainerOfDenominations
		/// ///////////////////////////////////////////

		int Margines = 20;

		public ATM()
		{
			InitializeComponent();
			this.Left = Screen.PrimaryScreen.Bounds.Left + Margines;
			this.Top = Screen.PrimaryScreen.Bounds.Top + Margines;

			this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.40F);
			this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.60F);
			this.StartPosition = FormStartPosition.Manual;

			mj_cb_value.SelectedIndex = 0;

			

			/*new copy of an array ContainerOfDenomination with the same 
			 * cardinality like an array ValueOfMoney */
			ContainerOfDenominations = new Denominations[ValueOfMoney.Length];


			


		}


		static bool CanThePaymentCanBeMade (Denominations[] ContainerOfDenominations, float amountToPayout)
		{
			// local declaration

			float BankCapital = 0.0F;

			for (ushort i = 0; i < ContainerOfDenominations.Length; i++)
			{
				if (ContainerOfDenominations[i].Cardinality > 0)
				{
					// dodanie kolejnego składnika sumy iloczynów liczność razy wartość 

					BankCapital += ContainerOfDenominations[1].Cardinality * ContainerOfDenominations[i].Value;

					//sprawdzamy, czy amonuntToPayout może być wypłacona 

					

				}
				
			}
			return BankCapital > amountToPayout;
		}
		private void ATM_Load(object sender, EventArgs e)
		{
			/*BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\mdoml\\Desktop\\atmimage.png");
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			*/
		}

		private void mj_rdB_defaultCardinality_CheckedChanged(object sender, EventArgs e)
		{
			mj_cb_value.Enabled = false;
			const ushort CardinalityOfDenominations = 50;
			
			// fill an array ContainerOfDominations
			
			for(ushort i =0; i < ContainerOfDenominations.Length; i++)
			{

				ContainerOfDenominations[i].Cardinality = CardinalityOfDenominations;
				ContainerOfDenominations[i].Value = ValueOfMoney[i];

			}
			//activity controls 

			mj_rdB_defaultCardinality.Checked = true;
			mj_rdB_defaultCardinality.Enabled = false;

			mj_rdB_randomCardionality.Checked = false;
			mj_rdB_randomCardionality.Enabled = false;
			mj_rdB_randomCardionality.Visible = false;

			
			mj_lbl_KwotaDoWypłaty.Visible = true;
			mj_txtb_amount.Enabled = true;
			mj_txtb_amount.Visible = true;
			mj_btn_accept.Enabled = true;
			mj_btn_accept.Visible = true;
			//mj_txt_amoundPaid.Enabled = true;
			//mj_txt_amoundPaid.Visible = true;

			mj_btn_Reset.Visible = true;



		}

		private void mj_btn_accept_Click(object sender, EventArgs e)
		{
			float amountToPayout;

			// gets fo the amount

			while (!float.TryParse(mj_txtb_amount.Text, out amountToPayout))
			{
				//error in save the amount
				errorProvider.SetError(mj_txtb_amount, "ERROR: wystąpił niedozwolony znak w zapisie kwoty do wypłaty");

				return;

			}
			if(amountToPayout <= 0.0F)
			{

				errorProvider.SetError(mj_txtb_amount, "ERROR: wartość kowty nie może być <= 0");
				return;
			}
			// sprawdzanie, czy bankomat ma kasę dla zrealizowania wymaganej wypłaty 

			if (!CanThePaymentCanBeMade(ContainerOfDenominations, amountToPayout))
			{
				// lack of money
				errorProvider.SetError(mj_btn_accept, "PRZEPRASZAMY: ale nie bankomat nie może zrealizować" +
					"Twojej wypłaty - podaj mniejszą kowtę lub przyjdz później ");
				return;

			}
			else
			{
				// pięniądze są możemy wypłacać 

				float restToPayout = amountToPayout;
				ushort IndexContainerOfDenominations = 0;
				ushort NumberOfDenomination;
				ushort IndexDGV = 0;

				// wyzerowanie dgv

				mj_dgv_window.Rows.Clear();

				mj_lbl_amountToPay.Text = "Wypłacane nominały :";

				while((restToPayout > 0.0F )&&(IndexContainerOfDenominations < ContainerOfDenominations.Length))
				{
					//obliczenie liczby nominałów, które moga być użyte do wypłat restToPayout

					NumberOfDenomination = (ushort)(restToPayout / ContainerOfDenominations[IndexContainerOfDenominations].Value);

					//sprawdzenie czy pojemnik o indeksie IndexContainerOfDenominations ma odpowiedznią liczbę nominałów do wypłaty

					if(NumberOfDenomination > ContainerOfDenominations[IndexContainerOfDenominations].Cardinality)
					{
						//pobieramy wszytkie nominały z pojemnika na pozycji o indeksie IndexContainerOfDenomination

						NumberOfDenomination =(ushort)ContainerOfDenominations[IndexContainerOfDenominations].Cardinality;

						//wyzerowanie licznośći nominałów 

						ContainerOfDenominations[IndexContainerOfDenominations].Cardinality = 0;

					}
					else
					{
						// pobieramy tylko wymaganą częsc nominałów z pojemnika o indzeksie 

						ContainerOfDenominations[IndexContainerOfDenominations].Cardinality = (ushort)
						(ContainerOfDenominations[IndexContainerOfDenominations].Cardinality - NumberOfDenomination);


						if (NumberOfDenomination > 0)
						{
							mj_dgv_window.Rows.Add();
							mj_dgv_window.Rows[IndexDGV].Cells[0].Value = NumberOfDenomination;
							mj_dgv_window.Rows[IndexDGV].Cells[1].Value = ContainerOfDenominations[IndexContainerOfDenominations].Value;

							//sprawdzenie i wypisanie jaki jest rodzaj nominału: banknot lub moneta

							if (ContainerOfDenominations[IndexContainerOfDenominations].Value >= TheLowwestValueBanknote)
							{
								mj_dgv_window.Rows[IndexDGV].Cells[2].Value = "banknot";
							}


							else
							{
								mj_dgv_window.Rows[IndexDGV].Cells[2].Value = "moneta";
							}

							mj_dgv_window.Rows[IndexDGV].Cells[3].Value = mj_cb_value.SelectedItem;

							mj_dgv_window.Rows[IndexDGV].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							mj_dgv_window.Rows[IndexDGV].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							mj_dgv_window.Rows[IndexDGV].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							mj_dgv_window.Rows[IndexDGV].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
							IndexDGV++;
						}	
					}

					// akutalizacja wartości ResztyDoWypłaty 

					restToPayout = restToPayout - NumberOfDenomination * ContainerOfDenominations[IndexContainerOfDenominations].Value;
					
					IndexContainerOfDenominations++;

				} // WHILE

				if (restToPayout > 0F)
				{
					errorProvider.SetError(mj_btn_accept, "PRZEPRASZAMY ale nie mamy odpowiedniej liczby nominiłów");
					return;
				}
				

				

			}


		}

		private void mj_rdB_randomCardionality_CheckedChanged(object sender, EventArgs e)
		{
			mj_cb_value.Enabled = false;

			mj_lblDolnaGranica.Visible = true;
			mj_lblGórnaGranica.Visible = true;
			mj_txtDolnaGranica.Visible = true;
			mj_txtGórnaGranica.Visible = true;
			mj_btnAkceptacjaNominałów.Visible = true;

			mj_rdB_defaultCardinality.Enabled = false;
			mj_rdB_randomCardionality.Enabled = false;
			mj_btn_Reset.Visible = true;
			
			
		}

		private void mj_btnAkceptacjaNominałów_Click(object sender, EventArgs e)
		{
			ushort DolnaG, GornaG;
			Random RnD = new Random();

			// gets fo the amount

			while (!ushort.TryParse(mj_txtDolnaGranica.Text, out DolnaG))
			{
				//error in save the amount
				errorProvider.SetError(mj_txtDolnaGranica, "ERROR: wystąpił niedozwolony znak w zapisie dolnej granicy licznosci nominałów");

				return;

			}
			while (!ushort.TryParse(mj_txtGórnaGranica.Text, out GornaG))
			{
				//error in save the amount
				errorProvider.SetError(mj_txtGórnaGranica, "ERROR: wystąpił niedozwolony znak w zapisie gornej granicy licznosci nominałów");

				return;

			}
			if (DolnaG >= GornaG)
			{

				errorProvider.SetError(mj_txtGórnaGranica, "ERROR: wartość górna granica przedziału liczności nominałów musi być większa od granicy dolnej");
				return;
			}
			// sprawdzanie, czy bankomat ma kasę dla zrealizowania wymaganej wypłaty 

			
			for(int i = 0; i < ContainerOfDenominations.Length; i++)
			{
				ContainerOfDenominations[i].Cardinality = (ushort)RnD.Next(DolnaG, GornaG);
				ContainerOfDenominations[i].Value = ValueOfMoney[i];
			}
				

			// wyzerowanie dgv

			mj_dgv_window.Rows.Clear();


				for(int j = 0; j < ContainerOfDenominations.Length; j++)
				{
					mj_dgv_window.Rows.Add();
					mj_dgv_window.Rows[j].Cells[0].Value = ContainerOfDenominations[j].Cardinality;
					mj_dgv_window.Rows[j].Cells[1].Value = ContainerOfDenominations[j].Value;
					if (ContainerOfDenominations[j].Value >= TheLowwestValueBanknote)
					{
						mj_dgv_window.Rows[j].Cells[2].Value = "banknot";
					}
					else
					{
						mj_dgv_window.Rows[j].Cells[2].Value = "moneta";
					}

					mj_dgv_window.Rows[j].Cells[3].Value = mj_cb_value.SelectedItem;

					mj_dgv_window.Rows[j].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
					mj_dgv_window.Rows[j].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
					mj_dgv_window.Rows[j].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
					mj_dgv_window.Rows[j].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

				}

			
			mj_txtDolnaGranica.Enabled = false;
			mj_txtGórnaGranica.Enabled = false;
			mj_btnAkceptacjaNominałów.Enabled = false;

		
			mj_btn_Reset.Visible = true;

		}

		private void mj_btn_Reset_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
