using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using System.Data;
using System.Web;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using VHMS.Entity;

public partial class VHMSService : IVHMSService
{
    #region "Payment"
    public string GetPayment()
    {
        string sException = string.Empty;
        string sFileNames = string.Empty;
        JavaScriptSerializer jsObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        try
        {
            int iUserId = 0;
            int iMachinesId = 0;
            int FK_FinancialYearID = 0;

            if (ValidateSession() && Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out iUserId) && Int32.TryParse(HttpContext.Current.Session["MachinesID"].ToString(), out iMachinesId))
            {
                Collection<VHMS.Entity.Billing.Payment> ObjList = new Collection<VHMS.Entity.Billing.Payment>();
                ObjList = VHMS.DataAccess.Billing.Payment.GetPayment(iMachinesId);
                objResponse.Status = "Success";
                objResponse.Value = ObjList.Count > 0 ? jsObject.Serialize(ObjList) : "NoRecord";
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment GetPayment |" + ex.Message.ToString();
            Log.Write(sException);
            objResponse.Status = "Error";
            objResponse.Value = "Error";
        }
        return jsObject.Serialize(objResponse);
    }

    public string GetLastPaymentDetails(int ID)
    {
        string sException = string.Empty;
        string sFileNames = string.Empty;
        JavaScriptSerializer jsObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        try
        {
            int iUserId = 0;
            int iMachinesId = 0;
            int FK_FinancialYearID = 0;

            if (ValidateSession() && Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out iUserId) && Int32.TryParse(HttpContext.Current.Session["MachinesID"].ToString(), out iMachinesId))
            {
                Collection<VHMS.Entity.Billing.Payment> ObjList = new Collection<VHMS.Entity.Billing.Payment>();
                ObjList = VHMS.DataAccess.Billing.Payment.GetLastPaymentDetails(ID, iMachinesId);
                objResponse.Status = "Success";
                objResponse.Value = ObjList.Count > 0 ? jsObject.Serialize(ObjList) : "NoRecord";
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment GetPayment |" + ex.Message.ToString();
            Log.Write(sException);
            objResponse.Status = "Error";
            objResponse.Value = "Error";
        }
        return jsObject.Serialize(objResponse);
    }
    public string GetPaymentByID(int ID)
    {
        string sException = string.Empty;
        string sFileNames = string.Empty;
        JavaScriptSerializer jsObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        try
        {
            int iUserId = 0;
            int iMachinesId = 0;
            int FK_FinancialYearID = 0;

            if (ValidateSession() && Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out iUserId) && Int32.TryParse(HttpContext.Current.Session["MachinesID"].ToString(), out iMachinesId))
            {
                VHMS.Entity.Billing.Payment objPayment = new VHMS.Entity.Billing.Payment();
                objPayment = VHMS.DataAccess.Billing.Payment.GetPaymentByID(ID, iMachinesId);
                if (objPayment.PaymentID > 0)
                {
                    objResponse.Status = "Success";
                    objResponse.Value = jsObject.Serialize(objPayment);
                }
                else
                {
                    objResponse.Status = "Success";
                    objResponse.Value = "NoRecord";
                }
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment GetPaymentByID |" + ex.Message.ToString();
            Log.Write(sException);
            objResponse.Status = "Error";
            objResponse.Value = "Error";
        }
        return jsObject.Serialize(objResponse);
    }
    public string AddPayment(VHMS.Entity.Billing.Payment Objdata)
    {
        string sException = string.Empty;
        JavaScriptSerializer jsonObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        int iPaymentId = 0;

        try
        {
            int iUserId = 0;
            int iMachinesID = 0;
            if (ValidateSession() && Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out iUserId) && Int32.TryParse(HttpContext.Current.Session["MachinesID"].ToString(), out iMachinesID))
            {
                VHMS.Entity.User objUser = new VHMS.Entity.User();
                objUser.UserID = iUserId;
                Objdata.CreatedBy = objUser;

                VHMS.Entity.Machines objMachines = new VHMS.Entity.Machines();
                objMachines.MachinesID = iMachinesID;
                Objdata.Machines = objMachines;
                iPaymentId = VHMS.DataAccess.Billing.Payment.AddPayment(Objdata);
                if (iPaymentId > 0)
                {
                    objResponse.Status = "Success";
                    objResponse.Value = iPaymentId.ToString();
                }
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment AddPayment |" + ex.Message.ToString();
            Log.Write(sException);
            if (ex.Message.ToString() == "Payment_A_01")
            {
                objResponse.Status = "Error";
                objResponse.Value = ex.Message.ToString();
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "Error";
            }
        }
        return jsonObject.Serialize(objResponse);
    }
    public string UpdatePayment(VHMS.Entity.Billing.Payment Objdata)
    {
        string sPaymentId = string.Empty;
        string sException = string.Empty;
        bool bPayment = false;
        JavaScriptSerializer jsonObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        int FK_FinancialYearID = 0;

        try
        {
            int iUserId = 0;
            int iMachinesID = 0;
            if (ValidateSession() && Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out iUserId) && Int32.TryParse(HttpContext.Current.Session["MachinesID"].ToString(), out iMachinesID))
            {
                VHMS.Entity.User objUser = new VHMS.Entity.User();
                objUser.UserID = iUserId;
                Objdata.ModifiedBy = objUser;

                VHMS.Entity.Machines objMachines = new VHMS.Entity.Machines();
                objMachines.MachinesID = iMachinesID;
                Objdata.Machines = objMachines;

                bPayment = VHMS.DataAccess.Billing.Payment.UpdatePayment(Objdata);
                if (bPayment == true)
                {
                    objResponse.Status = "Success";
                    objResponse.Value = "1";
                }
                else
                {
                    objResponse.Status = "Success";
                    objResponse.Value = "0";
                }
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment UpdatePayment |" + ex.Message.ToString();
            Log.Write(sException);
            if (ex.Message.ToString() == "Payment_U_01")
            {
                objResponse.Status = "Error";
                objResponse.Value = ex.Message.ToString();
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        return jsonObject.Serialize(objResponse);
    }
    public string DeletePayment(int ID)
    {
        string sPaymentId = string.Empty;
        string sException = string.Empty;
        JavaScriptSerializer jsonObject = new JavaScriptSerializer();
        VHMS.Entity.Response objResponse = new VHMS.Entity.Response();
        bool bPayment = false;
        try
        {
            if (ValidateSession())
            {
                bPayment = VHMS.DataAccess.Billing.Payment.DeletePayment(ID);
                if (bPayment == true)
                {
                    objResponse.Status = "Success";
                    objResponse.Value = "1";
                }
                else
                {
                    objResponse.Status = "Success";
                    objResponse.Value = "0";
                }
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        catch (Exception ex)
        {
            sException = "Payment DeletePayment |" + ex.Message.ToString();
            Log.Write(sException);
            if (ex.Message.ToString() == "Payment_R_01" || ex.Message.ToString() == "Payment_D_01")
            {
                objResponse.Status = "Error";
                objResponse.Value = ex.Message.ToString();
            }
            else
            {
                objResponse.Status = "Error";
                objResponse.Value = "0";
            }
        }
        return jsonObject.Serialize(objResponse);
    }
    #endregion

}