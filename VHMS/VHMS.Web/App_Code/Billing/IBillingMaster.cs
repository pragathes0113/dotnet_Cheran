using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Collections.ObjectModel;
using VHMS.Entity;
using System.IO;


public partial interface IVHMSService
{

    #region Payment
    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string GetPayment();

    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string GetPaymentByID(int ID);

    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string GetLastPaymentDetails(int ID);

    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string AddPayment(VHMS.Entity.Billing.Payment Objdata);

    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string UpdatePayment(VHMS.Entity.Billing.Payment Objdata);

    [OperationContract]
    [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    string DeletePayment(int ID);
    #endregion


}