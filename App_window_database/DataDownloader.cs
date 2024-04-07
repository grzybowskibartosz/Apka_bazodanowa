using System;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace ExchangeRateApp
{
    public class Rates
    {
        public Dictionary<string, decimal> rates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var rate in rates)
            {
                sb.AppendLine($"{rate.Key}: {rate.Value}");
            }
            return sb.ToString();
        }

        public static Rates Deserialize(string json)
        {
            return JsonSerializer.Deserialize<Rates>(json);
        }
    }
}
