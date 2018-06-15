using System;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BasicUtil {
    public class Controller{
        public SqlCommand comnd=null;
        public ConnectUtil conn;
        LINQbasicDataContext dc;
        public Controller() {
            conn = new ConnectUtil();
            dc = new LINQbasicDataContext(conn.sqlCon);
        }
        
        public Table<ITEM> fetchData(){
            
            IQueryable k=null;
            var query = k;
            try {
                query = from e in dc.ITEMs select e;
            }catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            finally {
                //conn.destroy();
            }
            return dc.ITEMs;
        }

        public bool addData(params string[] A) {
            ITEM item = new ITEM();
            item.Name = A[0];
            item.Price = Decimal.Parse(A[1]);
            dc.ITEMs.InsertOnSubmit(item);
            dc.SubmitChanges();
            //conn.destroy();

            return true;
        }

        public int updateData(string A, Decimal changePrice) {
            ChangeSet cs;
            try {
                var itemDatas = dc.ITEMs.Where(item => item.Name.Equals(A));
                foreach (var data in itemDatas) {
                    if(data.Name.Equals(A)) {
                        data.Price = changePrice;
                    }
                }
                cs = dc.GetChangeSet();
                dc.SubmitChanges();
                //conn.destroy();
                return cs.Updates.Count;
            }catch(Exception ex){
                    Console.WriteLine(ex.ToString()+"\nUpdate Failed!!");
                    //conn.destroy();
                    return 0;
            }
        }
        public int deleteData(string A){
            try {
                ChangeSet cs;
                var itemDatas = dc.ITEMs.Where(item => item.Name.Equals(A));
                foreach(var data in itemDatas) {
                    dc.ITEMs.DeleteOnSubmit(data);
                }
                cs = dc.GetChangeSet();
                dc.SubmitChanges();
                //conn.destroy();
                return cs.Deletes.Count;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                //conn.destroy();
                return 0;
            }
        }
    }
}
