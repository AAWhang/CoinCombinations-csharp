using System;

namespace CoinCombination.Models
{
    public class changeCalc
    {
        public string CoinCalculator(int change)
        {
            int quarter, dime, nickel, penny;
            string output;
            quarter = change/25;
            change = change%25;
            dime = change/10;
            change = change%10;
            nickel = change/5;
            change = change%5;
            penny = change;

            output = "Quarter: " + quarter + " Dime: " + dime + " Nickel: " + nickel + " Penny: " + penny;
            return output;
            

        }
    }
}