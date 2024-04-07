using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apka_bazodanowa
{
    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = " http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string response = await client.GetStringAsync(call);
            Console.WriteLine(response);
        }
    }
}
