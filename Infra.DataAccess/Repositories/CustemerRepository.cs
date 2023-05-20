using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public class CustemerRepository : MasterRepository, ICustemerRepository
    {

        public int Add(Custemer entity) {
            //add
            var paramters = new List<SqlParameter>();

            paramters.Add(new SqlParameter("@NameC", entity.NameCustemer));
            paramters.Add(new SqlParameter("@ArchivId", entity.ArchiId));
            paramters.Add(new SqlParameter("@LastNameC", entity.LastNameCuste));
            paramters.Add(new SqlParameter("@Email", entity.EmailCustemer));
            paramters.Add(new SqlParameter("@AddressC", entity.AddressCustemer));
            paramters.Add(new SqlParameter("@PhonoNumberC", entity.PhoneNumber));

            return ExecuteNonQuery("AddCustemer",paramters, CommandType.StoredProcedure);
        }
        public int Edit(Custemer entity) { 
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Id", entity.IdCustemer));
            parameters.Add(new SqlParameter("@NameC", entity.NameCustemer));
            parameters.Add(new SqlParameter("@ArchivId", entity.ArchiId));
            parameters.Add(new SqlParameter("@LastNameC", entity.LastNameCuste));
            parameters.Add(new SqlParameter("@Email", entity.EmailCustemer));
            parameters.Add(new SqlParameter("@AddressC", entity.AddressCustemer));
            parameters.Add(new SqlParameter("@PhonoNumberC", entity.PhoneNumber));

            return ExecuteNonQuery("EditCustemer", parameters,CommandType.StoredProcedure);
        }
        public int Remove(Custemer entity) {
            string sqlCommand = "delete from Custemer where IdCustemer=@Id";
            return ExecuteNonQuery(sqlCommand, new SqlParameter("@Id",entity.IdCustemer), CommandType.Text);
        }
        public int AddRange(List<Custemer> custemers) {
            
            var transactions = new List<BulkTransaction>();

            foreach (var custemer in custemers) { 
            var trans = new BulkTransaction();
            var parametets = new List<SqlParameter>();

                parametets.Add(new SqlParameter("@NameC", custemer.NameCustemer) {SqlDbType = SqlDbType.NVarChar});
                parametets.Add(new SqlParameter("@ArchivId", custemer.ArchiId) { SqlDbType = SqlDbType.Int});
                parametets.Add(new SqlParameter("@LastNameC", custemer.LastNameCuste) { SqlDbType = SqlDbType.NVarChar});
                parametets.Add(new SqlParameter("@Email", custemer.EmailCustemer) { SqlDbType = SqlDbType.NVarChar});
                parametets.Add(new SqlParameter("@AddressC", custemer.AddressCustemer) {SqlDbType = SqlDbType.NVarChar });
                parametets.Add(new SqlParameter("@PhonoNumberC", custemer.PhoneNumber) { SqlDbType = SqlDbType.NVarChar});

                trans.CommandText = "AddCustemer";
                trans.Parameters = parametets;

                transactions.Add(trans);
            }

            return BulkExecuteNonQuery(transactions, CommandType.StoredProcedure);

        }
        public int RemoveRange(List<Custemer> custemers) {
            var transactions = new List<BulkTransaction>();
            foreach (var custemer in custemers)
            {
                var trans = new BulkTransaction();
                trans.CommandText = "delete from Custemer where IdCustemer=@Id";
                trans.Parameters = new List<SqlParameter> { new SqlParameter("@Id", custemer.IdCustemer) { SqlDbType = SqlDbType.Int } };
                
                transactions.Add(trans);
            
            }

            return BulkExecuteNonQuery(transactions, CommandType.Text);

        }
        public Custemer GetSingle(string value) {
            string sqlCommad;
            DataTable table;
            int CustemerID;
            bool dato = int.TryParse(value, out CustemerID);

            if (dato)
            {
                table = ExecuteReader("SelectCustemerId", new SqlParameter("@findValue", CustemerID), CommandType.StoredProcedure);
            }
            else
            {
                table = ExecuteReader("SelectCustemer", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }

            if (table.Rows.Count > 0)
            {
                var custemer = new Custemer();
                foreach (DataRow row in table.Rows)
                {
                    custemer.IdCustemer = Convert.ToInt32(row[0]);
                    custemer.NameCustemer = row[1].ToString();
                    custemer.ArchiId = Convert.ToInt32(row[2]);
                    custemer.LastNameCuste = row[3].ToString();
                    custemer.EmailCustemer = row[4].ToString();
                    custemer.AddressCustemer = row[5].ToString();
                    custemer.PhoneNumber = row[6].ToString();

                }
                table.Clear();
                table = null;

                return custemer;
            }
            else return null;

            
        }
        public IEnumerable<Custemer> GetAll() { 
            var CustemerList = new List<Custemer>();
            var table = ExecuteReader("SelectAllCustemers", CommandType.StoredProcedure);
            
            foreach (DataRow row in table.Rows)
            {
                var custemer = new Custemer();
                custemer.IdCustemer = Convert.ToInt32(row[0]);
                custemer.NameCustemer= row[1].ToString();
                custemer.ArchiId = Convert.ToInt32(row[2]);
                custemer.LastNameCuste = row[3].ToString();
                custemer.EmailCustemer= row[4].ToString();
                custemer.AddressCustemer = row[5].ToString();
                custemer.PhoneNumber = row[6].ToString();

                CustemerList.Add(custemer);
            }

            return CustemerList;
        
        }

        public IEnumerable<Custemer> GetByValue(string value) {
            DataTable table;
            int CustemerId;
            bool dato = int.TryParse(value, out CustemerId);
            if (dato)
            {
                table = ExecuteReader("SelectCustemerId", new SqlParameter("@findValue", CustemerId), CommandType.StoredProcedure);
            }
            else
            {
                table = ExecuteReader("SelectCustemer", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }

            var CustemerList = new List<Custemer>(); 
            
            foreach (DataRow row in table.Rows)
            {
                var custemer = new Custemer();
                custemer.IdCustemer = Convert.ToInt32(row[0]);
                custemer.NameCustemer = row[1].ToString();
                custemer.ArchiId = Convert.ToInt32(row[2]);
                custemer.LastNameCuste = row[3].ToString();
                custemer.EmailCustemer = row[4].ToString();
                custemer.AddressCustemer = row[5].ToString();
                custemer.PhoneNumber = row[6].ToString();

                CustemerList.Add(custemer);
            }
            table.Clear();
            table = null;
            return CustemerList;
        }
    
    }
}
