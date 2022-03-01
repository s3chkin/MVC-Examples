using System;
using System.Collections.Generic;
using System.Text;
using TransportPrice;
using TransportMVC.Views;


namespace TransportMVC.Controllers
{
    public class TransportCalculatePrice
    {
        public PriceTransport priceTransport;
        public Display display;
        public TransportCalculatePrice()
        {
            display = new Display();
            priceTransport = new PriceTransport(display.Distance, display.Time);
            display.PriceTransport = priceTransport.CalculatePriceTransport();
            display.Result();
            
        }
    }
}
