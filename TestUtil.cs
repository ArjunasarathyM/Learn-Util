using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace BasicUtil{
    public class TestUtil{
        public static string cap="";
        static void GetConnectionStrings() {
            //fectch app.config connection string innerXML values
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null) {
                foreach (ConnectionStringSettings cs in settings) {
                    cap = cs.ConnectionString;
                    Console.WriteLine("Name: {0}\nProviderName: {1}\nConStr: {2}\n\n",cs.Name,cs.ProviderName,cs.ConnectionString);
                }
                Console.WriteLine(cap);
            }
        }
        static void run() {
            string s;
            do {
                Console.WriteLine("\n1)ADD\n2)SHOW\n3)Delete\n4)Update\n5)Exit\n\t<1-5>:");
                s = Console.ReadLine();
                switch (s) {
                    case "1":
                        UI.add();
                        break;
                    case "2": {
                            UI.show();
                            break;
                        }
                    case "3":
                        UI.delete();
                        break;

                    case "4":
                        UI.update();
                        break;
                    case "5":
                        UI.control.conn.destroy();
                        return;
                }
            } while (true);
        }
        static string formatPhoneNUmberUS(string number) {
            //retrive all number from the string
            string phoneNumber = "{} - ", areaCode = "({})", CountryCode = string.Empty;
            string numberBuffer = string.Empty, formatedNumber = string.Empty;
            int index = 0;
            //Pull all the numbers [digits]
            number.ToList().ForEach(digit => {
                if (char.IsDigit(digit))
                    numberBuffer += digit;
            });
            index = numberBuffer.Count();
            //To pack the numbers to its format, accordingly
            if (numberBuffer.Count() >= 10) {
                index -= 4;
                phoneNumber += numberBuffer.Substring(index, 4);
                index -= 3;
                phoneNumber = phoneNumber.Replace("{}", numberBuffer.Substring(index, 3));
                index -= 3;
                areaCode = areaCode.Replace("{}", numberBuffer.Substring(index, 3));
            }
            if (index > 0)
                CountryCode += "+" + numberBuffer.Substring(0, index);
            formatedNumber = CountryCode + areaCode + phoneNumber;
            return formatedNumber;
        }
        public static void Main(string[] args){
            Console.WriteLine(formatPhoneNUmberUS("4107151298"));
            GetConnectionStrings();
            run();
        }
    }
}