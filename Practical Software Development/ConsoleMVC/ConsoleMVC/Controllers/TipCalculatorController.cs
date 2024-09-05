using ConsoleMVC.Model;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controllers
{
    public class TipCalculatorController
    {
        private Tip tip;

        private Display display;

        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip();
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
