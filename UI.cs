using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicUtil{
    public class UI{
        public static Controller control = new Controller();
      public static void show() {
            var data = control.fetchData();
            Console.WriteLine("id\tname\tprice\n");
            foreach (var i in data) {
                Console.WriteLine("{0}\t{1}\t{2}", i.ID, i.Name, (decimal)i.Price);
            }
      }
      public static void add() {
            Console.WriteLine("Name: and New Price:");
            control.addData(Console.ReadLine(), Console.ReadLine());
      }
      public static void update() {
            Console.WriteLine("Name: and New Price:");
            int val;
            if ((val=control.updateData(Console.ReadLine(), Decimal.Parse(Console.ReadLine()))) > 0) {
                Console.WriteLine("Update Successful by updating {0} rows\n",val);
            }
            else {
                Console.WriteLine("Update Failed!!");
            }
      }
      public static void delete() {
            Console.WriteLine("Name: ");
            int val;
            if ((val = control.deleteData(Console.ReadLine())) > 0) {
                Console.WriteLine("Delete Successful by removing {0} rows\n",val);
            }
            else {
                Console.WriteLine("Delete Unsuccessful");
            }
        }
    }
}
