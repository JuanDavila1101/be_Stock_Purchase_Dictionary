using System;
using System.Collections.Generic;
using System.Linq;

namespace be_Stock_Purchase_Dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GM", "General Motors");
      stocks.Add("CAT", "Caterpillar");
      stocks.Add("AMZN", "Amazon");
      stocks.Add("COST", "Costco");
      stocks.Add("WMT", "Walmart");
      stocks.Add("CMCSA", "Comcast ");
      stocks.Add("PG", "Procter & Gamble");
      stocks.Add("PFE", "Pfizer");
      // Add a few more of your favorite stocks

      Console.WriteLine($"\nStocks:\n{string.Join("\n, ", stocks)}\n");

      List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();



      //```csharp
      // General Motors
      purchases.Add((ticker: "GM", shares: 22, price: 54.22));
      purchases.Add((ticker: "GM", shares: 13, price: 26.48));
      purchases.Add((ticker: "GM", shares: 15, price: 37.40));
      purchases.Add((ticker: "GM", shares: 18, price: 34.52));
      purchases.Add((ticker: "GM", shares: 33, price: 36.68));

      // Caterpillar
      purchases.Add((ticker: "CAT", shares: 33, price: 185.96));
      purchases.Add((ticker: "CAT", shares: 17, price: 131.44));
      purchases.Add((ticker: "CAT", shares: 12, price: 117.90));
      purchases.Add((ticker: "CAT", shares: 11, price: 153.30));
      purchases.Add((ticker: "CAT", shares: 30, price: 95.81));

      // Amazon
      purchases.Add((ticker: "AMZN", shares: 2, price: 3127.89));
      purchases.Add((ticker: "AMZN", shares: 4, price: 1932.97));
      purchases.Add((ticker: "AMZN", shares: 4, price: 1638.88));
      purchases.Add((ticker: "AMZN", shares: 3, price: 1172.00));
      purchases.Add((ticker: "AMZN", shares: 3, price: 853.05));

      // Costco
      purchases.Add((ticker: "COST", shares: 11, price: 351.21));
      purchases.Add((ticker: "COST", shares: 10, price: 294.06));
      purchases.Add((ticker: "COST", shares: 13, price: 200.50));
      purchases.Add((ticker: "COST", shares: 15, price: 187.23));
      purchases.Add((ticker: "COST", shares: 18, price: 177.37));

      // Walmart
      purchases.Add((ticker: "WMT", shares: 5, price: 144.30));
      purchases.Add((ticker: "WMT", shares: 7, price: 118.86));
      purchases.Add((ticker: "WMT", shares: 3, price: 91.64));
      purchases.Add((ticker: "WMT", shares: 5, price: 88.00));
      purchases.Add((ticker: "WMT", shares: 5, price: 77.90));

      // Comcast
      purchases.Add((ticker: "CMCSA", shares: 12, price: 52.28));
      purchases.Add((ticker: "CMCSA", shares: 10, price: 43.56));
      purchases.Add((ticker: "CMCSA", shares: 15, price: 33.49));
      purchases.Add((ticker: "CMCSA", shares: 19, price: 31.38));
      purchases.Add((ticker: "CMCSA", shares: 13, price: 32.80));

      // Procter & Gamble
      purchases.Add((ticker: "PG", shares: 7, price: 124.16));
      purchases.Add((ticker: "PG", shares: 7, price: 107.95));
      purchases.Add((ticker: "PG", shares: 6, price: 91.03));
      purchases.Add((ticker: "PG", shares: 5, price: 72.05));
      purchases.Add((ticker: "PG", shares: 5, price: 82.21));

      // Pfizer
      purchases.Add((ticker: "PFE", shares: 45, price: 33.59));
      purchases.Add((ticker: "PFE", shares: 60, price: 30.28));
      purchases.Add((ticker: "PFE", shares: 32, price: 33.79));
      purchases.Add((ticker: "PFE", shares: 25, price: 33.61));
      purchases.Add((ticker: "PFE", shares: 43, price: 29.35));
      // Add more for each stock you added to the stocks dictionary

      Console.WriteLine($"\nPurchases: \n{string.Join("\n, ", purchases)}\n");

      //Create a total ownership report that computes the total value of each stock that you have purchased.
      //This is the basic relational database join algorithm between two tables.

      Dictionary<string, double> ownership = new Dictionary<string, double>();

      double sum = 0.0;

      foreach(var (stockKey, stockDescription)  in stocks)
      {
        foreach (var (ticker, share, price) in purchases)
        {
          if (ticker == stockKey)
          {
            sum += share * price;
          }
        }
        ownership.Add(stockKey, sum);
        sum = 0.0;
        //ownership.Add(stockKey, purchases.Sum(purchases.Where(purchase => purchase.ticker == stockKey));
      }

      /*
       * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
       * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
      */
      // Iterate over the purchases and update the valuation for each stock
      foreach ((string ticker, int shares, double price) purchase in purchases)
      {
        // Does the company name key already exist in the report dictionary?
        // If it does, update the total valuation
        // If not, add the new key and set its value
      }
      //```


      foreach (var (stockKey, stockDescription) in stocks)
      { 
       foreach(var (ownershipKey, totalSum) in ownership)
        {
           if (stockKey == ownershipKey)
          {
          Console.WriteLine($"\n{stockDescription} {totalSum}.");
          }
        }
      
      }


      }
  }
}
