using System;

namespace CarTask
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EngineVolume { get; set; }
        public int YearProduction { get; set; }

       
        public Car()
        {
            Brand = "Unknown";
            Model = "Unknown";
            EngineVolume = 0;
            YearProduction = 0;
        }

        public Car(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model, int engineVol, int yearProd) : this(brand, model)
        {
            EngineVolume = engineVol;
            YearProduction = yearProd;
        }

        public void CalculateAnnualTax()
        {
            int annualTax = 0;

            if (YearProduction > 2010)
            {
                annualTax = 50;
            }
            else if (YearProduction >= 2001 && YearProduction <= 2010)
            {
                annualTax = 60;
            }
            else
            {
                annualTax = 70;
            }

            annualTax += (20 * EngineVolume / 100);

            Console.WriteLine($"Автомобил {Brand}, {Model}, с обем на двигателя {EngineVolume}, произведен през {YearProduction} дължи данък {annualTax}");
        }
    }
}