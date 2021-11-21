using Login_Registration_ASP_NET_CORE_RAZOR.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Registration_ASP_NET_CORE_RAZOR.DataLayer
{
    public class DataAccessLayer
    {
        public int Insert(Staffs staffs)
        {
            string constring = "Server=DITPC007\\SQL2019;Database=ASPLogReg;Persist Security Info=True;User id=superadmin;Password=samuel4300;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(constring))
            {
                //string query = "insert into Staffs(FirstName,LastName,Email,Gender,MaritalStatus,Role,DOR) values(@FirstName,@LastName,@Email,@Gender,@MaritalStatus,@Role,@DOR)";
                using (SqlCommand cmd = new SqlCommand("InsertStaffs"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName",staffs.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", staffs.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Email", staffs.Email));
                    cmd.Parameters.Add(new SqlParameter("@Gender", staffs.Gender));
                    cmd.Parameters.Add(new SqlParameter("@MaritalStatus", staffs.MaritalStatus));
                    cmd.Parameters.Add(new SqlParameter("@Role", staffs.Role));

                    cmd.Connection = con;
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
