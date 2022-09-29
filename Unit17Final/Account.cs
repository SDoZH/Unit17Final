using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit17Final.ChoseProfiles;


namespace Unit17Final
{
    public class Account : IUsually,ISalary
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // методы дляпрофилей
        void IUsually.CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
        void ISalary.CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
