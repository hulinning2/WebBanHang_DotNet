using System;
using System.ServiceModel;
using System.Data;
using System.Collections.Generic;

namespace WcfServiceProcessData
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        DataSet getTableProcedurce(string nameProcedure, Dictionary<string, object> values);
        [OperationContract]
        DataSet getTable(string SQL);
        [OperationContract]
        int ExeCuteSQL(string SQL);
        [OperationContract]
        int ExeCuteProcedurce(string nameProcedure, Dictionary<string, object> values);
    }
}
