using System;
using System.Collections.Generic;
using System.Text;
using ConsoleMVC.Model;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controllers
{
    class TipCalculatorController
    {
        private Tip tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.ShowTipAndTotal();
        }
    }
}
