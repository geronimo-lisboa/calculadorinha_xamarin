using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMobileApp.controller;
using Xamarin.Forms;

namespace CalculatorMobileApp
{
    public partial class MainPage : ContentPage
    {
		private CalculatorController controller = new CalculatorController();
       
		private String BuildLabelText(){
			return controller.Operand1 + controller.Operation + controller.Operand2;	
		}

		void ClearClicked(object sender, System.EventArgs e)
		{
			controller.PushCharacter("C");
			LabelResultado.Text = BuildLabelText();
		}

		void DivClicked(object sender, System.EventArgs e){
			controller.PushCharacter("/");
			LabelResultado.Text = BuildLabelText();
		}

		void MulClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("*");
            LabelResultado.Text = BuildLabelText();
        }

		void AddClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("+");
            LabelResultado.Text = BuildLabelText();                
        }

		void SubClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("-");
            LabelResultado.Text = BuildLabelText();
        }

		void OneClicked(object sender, System.EventArgs e)
		{
			controller.PushCharacter("1");
			LabelResultado.Text = BuildLabelText();
        }

		void TwoClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("2");
			LabelResultado.Text = BuildLabelText();
        }

		void ThreeClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("3");
			LabelResultado.Text = BuildLabelText();
        }

		void FourClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("4");
			LabelResultado.Text = BuildLabelText();         
        }

		void FiveClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("5");
			LabelResultado.Text = BuildLabelText();
        }

		void SixClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("6");
			LabelResultado.Text = BuildLabelText();
        }

		void SevenClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("7");
			LabelResultado.Text = BuildLabelText();
        }

		void EightClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("8");
			LabelResultado.Text = BuildLabelText();
        }

		void NineClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("9");
			LabelResultado.Text = BuildLabelText();
        }

		void ZeroClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("0");
			LabelResultado.Text = BuildLabelText();
        }

		void PointClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter(".");
			LabelResultado.Text = BuildLabelText();
            
        }

		void EnterClicked(object sender, System.EventArgs e)
        {
			controller.PushCharacter("=");
            LabelResultado.Text = BuildLabelText();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
