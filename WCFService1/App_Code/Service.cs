using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceProcessData;
using WcfServiceProcessData.App_Code;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    WcfServiceProcessData.App_Code.XULYDULIEU xulydulieu;
    public DataSet getTable(String SQL)
    {
        DataSet ds = new DataSet();
        xulydulieu = new XULYDULIEU();
        ds.Tables.Add(xulydulieu.getTable(SQL));
        return ds;
    }
    public DataSet getTableProcedurce(String nameprocedurce, Dictionary<String, object> values)
    {
        DataSet ds = new DataSet();
        xulydulieu = new XULYDULIEU();
        SqlParameter[] pr = new SqlParameter[values.Count];
        for (int i = 0; i < values.Count; i++)
        {
            SqlParameter param;
            if (values.ElementAt(i).Value != null)
                param = new SqlParameter(values.ElementAt(i).Key, values.ElementAt(i).Value);
            else
                param = new SqlParameter(values.ElementAt(i).Key, DBNull.Value);

            pr[i] = param;
        }
        ds.Tables.Add(xulydulieu.getTable(nameprocedurce, pr));
        return ds;
    }
    public int ExeCuteSQL(string SQL)
    {
        xulydulieu = new XULYDULIEU();
        int k = xulydulieu.ExeCute(SQL);
        return k;
    }
    public int ExeCuteProcedurce(String nameprocedurce, Dictionary<String, object> values)
    {
        xulydulieu = new XULYDULIEU();
        SqlParameter[] pr = new SqlParameter[values.Count];
        for (int i = 0; i < values.Count; i++)
        {
            SqlParameter param;
            if (values.ElementAt(i).Value != null)
                param = new SqlParameter(values.ElementAt(i).Key, values.ElementAt(i).Value);
            else
                param = new SqlParameter(values.ElementAt(i).Key, DBNull.Value);

            pr[i] = param;
        }
        int k = xulydulieu.ExeCute(nameprocedurce, pr);
        return k;
    }

}
