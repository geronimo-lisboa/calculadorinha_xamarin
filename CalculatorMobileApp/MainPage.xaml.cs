using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorMobileApp
{
    public partial class MainPage : ContentPage
    {
		private CalculatorController controller = new CalculatorController();

		void ClearClicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException("xxx");
		}

		void DivClicked(object sender, System.EventArgs e){
			controller.AccumulateData("/");
            LabelResultado.Text = controller.Data;
		}

		void MulClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("*");
            LabelResultado.Text = controller.Data;
        }

		void AddClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("+");
            LabelResultado.Text = controller.Data;                
        }

		void SubClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("-");
            LabelResultado.Text = controller.Data;
        }

		void OneClicked(object sender, System.EventArgs e)
		{
			controller.AccumulateData("1");
			LabelResultado.Text = controller.Data;
        }

		void TwoClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("2");
			LabelResultado.Text = controller.Data;
        }

		void ThreeClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("3");
			LabelResultado.Text = controller.Data;
        }

		void FourClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("4");
			LabelResultado.Text = controller.Data;         
        }

		void FiveClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("5");
			LabelResultado.Text = controller.Data;
        }

		void SixClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("6");
			LabelResultado.Text = controller.Data;
        }

		void SevenClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("7");
			LabelResultado.Text = controller.Data;
        }

		void EightClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("8");
			LabelResultado.Text = controller.Data;
        }

		void NineClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("9");
			LabelResultado.Text = controller.Data;
        }

		void ZeroClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("9");
			LabelResultado.Text = controller.Data;
        }

		void PointClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData(".");
			LabelResultado.Text = controller.Data;
            
        }

		void EnterClicked(object sender, System.EventArgs e)
        {
			controller.AccumulateData("=");
            LabelResultado.Text = controller.Data;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
