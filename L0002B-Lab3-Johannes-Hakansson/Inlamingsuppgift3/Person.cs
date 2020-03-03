// Johannes Håkansson 931011-5119   L0002B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamingsuppgift3
{
    class Person
    {
        //Personernas data
        public String firstName;
        public String lastName;
        public String SSN;

        public Person()
        {
            firstName = "Inget förnamn";
            lastName = "Inget efternamn";
            SSN = "0000000000";
        }
        
        public Person(string fName, string lName, string ssn)
        {
            firstName = fName;
            lastName = lName;
            SSN = ssn;
        }

        //Ta reda på om personnummret tillhör en man eller en kvinna.
        public string DetermineSex()
        {
            string sex;

            //Kolla om näst sista siffran är jämn eller ojämn.
            int kontrollSiffra = int.Parse(SSN[8].ToString());
            if (kontrollSiffra % 2 == 0)
            {
                sex = "Kvinna.";
            }
            else
            {
                sex = "Man.";
            }
            return "Kön: " + sex;
        }

        //Ta reda på om personnummret är godkänt.
        public string ControlNumber()
        {
            int sum = 0;
            for (int i = 0; i < SSN.Length; i++)
            {
                int add = int.Parse(SSN[i].ToString());
                if (i % 2 == 0)
                {
                    add = (2 * add);
                    //om det blir över 10, t.ex. 12, tar vi 1+2 istället för 12. 15 blir 1+5 osv...
                    if (add >= 10)
                    {
                        add = (1 + int.Parse(add.ToString()[1].ToString()));
                    }
                    sum = sum + add;
                }
                else
                {
                    sum = sum + add;
                }
            }

            //delbart med 10? personnummer OK.
            if (sum % 10 == 0 && sum != 0)
            {
                return "Personnummer: OK. ";
            }
            return "Personnummer: INTE OK. ";
        }



    }
}
