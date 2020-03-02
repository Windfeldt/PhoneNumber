using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PN
{
    class NumberHandler
    {
        Person person = new Person();
        public 

        List<string> LoadPersons()
        {
            using (StreamReader r = new StreamReader("contacts.json"))
            {
                string json = r.ReadToEnd();
                List<string> items = JsonConvert.DeserializeObject<List<string>>(json);
                return items;
            }
        }
        
        public int GetNumber(string firstName, string lastName)
        {
            var persons = LoadPersons();
            string fullName = firstName + lastName;
            if (fullName == person.FirstName+person.LastName)
            {
                return person.Number;
            }
            return 0;
        }
    }
}
