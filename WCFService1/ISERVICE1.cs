using System;
using System.ServiceModel;
using System.Data;
using System.Collections.Generic;

namespace WcfServiceProcessData
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet getTableProcedure(string nameProcedure, Dictionary<string, object> values);
        [OperationContract]
        DataSet getTable(string SQL);
        [OperationContract]
        int ExeCuteSQL(string SQL);
        [OperationContract]
        int ExeCuteProcedure(string nameProcedure, Dictionary<string, object> values);
    }
}
