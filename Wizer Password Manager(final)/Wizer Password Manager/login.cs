using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizer_Password_Manager
{
    class login
    {

        public static string abc { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string age { get; set; }
        public string Contact { get; set; }
        public void Insert()
        {
            StreamWriter sw = new StreamWriter("login.txt", true);
            sw.WriteLine(Username + "^" + Pass.ToString() + "^" + age + "^" + Contact);
            sw.Close();
        }
        public List<login> ShowAll()
        {
            string a = String.Concat(File.ReadAllLines("login.txt"));
            string[] arr = a.Split('~');
         

            List<login> lst = new List<login>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    string[] temp = arr[i].Split('^');
                    login s = new login()
                    {
                        Username = temp[0],
                        Pass = temp[1],
                        age = temp[2],
                        Contact = temp[3]
                        
                    };
                
                    lst.Add(s);
                }
            }
            Username = abc;
            return lst;
        }
    }

    
}

