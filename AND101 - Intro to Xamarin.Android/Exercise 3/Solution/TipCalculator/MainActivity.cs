using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
	[Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
        private EditText inputBill;
        private Button calculateButton;
        private TextView outputTip;
        private TextView outputTotal;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

            // Gets the references to the views.
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            // Subscribes the calculateButton to the handler method.
            calculateButton.Click += OnCalculateClick;
		}

        /// <summary>
        /// Calculates the tip and total when the Calculate Button has
        /// been pressed.
        /// </summary>
        /// <param name="sender">The Calculate Button</param>
        /// <param name="e">The Click event.</param>
        private void OnCalculateClick(object sender, EventArgs e)
        {
            string billAmount = inputBill.Text;
            double billQuantity = double.Parse(billAmount);

            double tip = billQuantity * 0.15f;
            double total = tip + billQuantity;

            outputTip.Text = String.Format("{0:0.0#}", tip);
            outputTotal.Text = String.Format("{0:0.0#}", total);
        }
	}
}