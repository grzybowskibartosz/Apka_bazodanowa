/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Apka_bazodanowa
{
    internal class Deserializer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, \tName: {Name}, \tAverage: {Average:0.00}";
        }

        private async void bDownlod_Click(object sender, EventArgs e)
        {
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string response = await client.GetStringAsync(call);
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);
            foreach (var student in students) listBox1.Items.Add(student.ToString());
        }
    }
}
*/