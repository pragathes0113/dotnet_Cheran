using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Collections.ObjectModel;
using VHMS;

namespace VHMS.DAL
{
    public class Machines
    {
        public static Collection<Entity.Machines> GetMachines()
        {
            string sException = string.Empty;
            Database db;
            Collection<Entity.Machines> objList = new Collection<Entity.Machines>();
            Entity.Machines objMachines = new Entity.Machines();
            Entity.User objCreatedUser;
            Entity.User objModifiedUser;

            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_MACHINES);
                DataSet dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objMachines = new Entity.Machines();
                        objCreatedUser = new Entity.User();
                        objModifiedUser = new Entity.User();
                        objMachines.MachinesID = Convert.ToInt32(drData["PK_MachinesID"]);
                        objMachines.MachinesName = Convert.ToString(drData["MachinesName"]);
                        objMachines.Address = Convert.ToString(drData["Address"]);
                        objMachines.TransportNumber = Convert.ToString(drData["TransportNumber"]);
                        objMachines.OwnerMobileNo = Convert.ToString(drData["OwnerMobileNo"]);
                        objMachines.ManagerMobileNo = Convert.ToString(drData["ManagerMobileNo"]);
                        objMachines.VehicleChassisNo = Convert.ToString(drData["VehicleChassisNo"]);
                        objMachines.RCNo = Convert.ToString(drData["RCNo"]);
                        objMachines.RCDate = Convert.ToDateTime(drData["RCDate"]);
                        objMachines.sRCDate = objMachines.RCDate.ToString("dd/MM/yyyy");
                        objMachines.InsuranceNo = Convert.ToString(drData["InsuranceNo"]);
                        objMachines.InsuranceDate = Convert.ToDateTime(drData["InsuranceDate"]);
                        objMachines.sInsuranceDate = objMachines.InsuranceDate.ToString("dd/MM/yyyy");
                        objMachines.FCDate = Convert.ToDateTime(drData["FCDate"]);
                        objMachines.sFCDate = objMachines.FCDate.ToString("dd/MM/yyyy");
                        objMachines.TaxDate = Convert.ToDateTime(drData["TaxDate"]);
                        objMachines.sTaxDate = objMachines.TaxDate.ToString("dd/MM/yyyy");
                        objMachines.FinancialYear = Convert.ToString(drData["Financial_Year"]);
                        objList.Add(objMachines);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "Machines GetMachinesByID | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objList;
        }

        public static Entity.Machines GetMachinesByID(int MachinesID)
        {
            string sException = string.Empty;
            Database db;
            Entity.Machines objMachines = new Entity.Machines();
            Entity.User objCreatedUser;
            Entity.User objModifiedUser;

            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_MACHINES);
                db.AddInParameter(cmd, "@PK_MachinesID", DbType.Int32, MachinesID);
                DataSet dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objMachines = new Entity.Machines();
                        objCreatedUser = new Entity.User();
                        objModifiedUser = new Entity.User();
                        objMachines.MachinesID = Convert.ToInt32(drData["PK_MachinesID"]);
                        objMachines.Address = Convert.ToString(drData["Address"]);
                        objMachines.MachinesName = Convert.ToString(drData["MachinesName"]);
                        objMachines.TransportNumber = Convert.ToString(drData["TransportNumber"]);
                        objMachines.OwnerMobileNo = Convert.ToString(drData["OwnerMobileNo"]);
                        objMachines.ManagerMobileNo = Convert.ToString(drData["ManagerMobileNo"]);
                        objMachines.VehicleChassisNo = Convert.ToString(drData["VehicleChassisNo"]);
                        objMachines.RCNo = Convert.ToString(drData["RCNo"]);
                        objMachines.RCDate = Convert.ToDateTime(drData["RCDate"]);
                        objMachines.sRCDate = objMachines.RCDate.ToString("dd/MM/yyyy");
                        objMachines.InsuranceNo = Convert.ToString(drData["InsuranceNo"]);
                        objMachines.InsuranceDate = Convert.ToDateTime(drData["InsuranceDate"]);
                        objMachines.sInsuranceDate = objMachines.InsuranceDate.ToString("dd/MM/yyyy");
                        objMachines.FCDate = Convert.ToDateTime(drData["FCDate"]);
                        objMachines.sFCDate = objMachines.FCDate.ToString("dd/MM/yyyy");
                        objMachines.TaxDate = Convert.ToDateTime(drData["TaxDate"]);
                        objMachines.sTaxDate = objMachines.TaxDate.ToString("dd/MM/yyyy");
                        objMachines.FinancialYear = Convert.ToString(drData["Financial_Year"]);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "Machines GetMachinesByID | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objMachines;
        }

        public static int AddMachines(Entity.Machines objMachines)
        {
            string sException = string.Empty;
            int iID = 0;
            Database db;
            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_INSERT_MACHINES);
                db.AddOutParameter(cmd, "@PK_MachinesID", DbType.Int32, objMachines.MachinesID);
                db.AddInParameter(cmd, "@MachinesName", DbType.String, objMachines.MachinesName);
                db.AddInParameter(cmd, "@TransportNumber", DbType.String, objMachines.TransportNumber);
                db.AddInParameter(cmd, "@OwnerMobileNo", DbType.String, objMachines.OwnerMobileNo);
                db.AddInParameter(cmd, "@ManagerMobileNo", DbType.String, objMachines.ManagerMobileNo);
                db.AddInParameter(cmd, "@VehicleChassisNo", DbType.String, objMachines.VehicleChassisNo);
                db.AddInParameter(cmd, "@RCNo", DbType.String, objMachines.RCNo);
                db.AddInParameter(cmd, "@RCDate", DbType.String, objMachines.sRCDate);
                db.AddInParameter(cmd, "@InsuranceDate", DbType.String, objMachines.sInsuranceDate);
                db.AddInParameter(cmd, "@InsuranceNo", DbType.String, objMachines.InsuranceNo);
                db.AddInParameter(cmd, "@FCDate", DbType.String, objMachines.sFCDate);
                db.AddInParameter(cmd, "@TaxDate", DbType.String, objMachines.sTaxDate);
                db.AddInParameter(cmd, "@Address", DbType.String, objMachines.Address);
                db.AddInParameter(cmd, "@Financial_Year", DbType.String, objMachines.FinancialYear);
                db.AddInParameter(cmd, "@FK_CreatedBy", DbType.Int32, objMachines.CreatedBy.UserID);
                iID = db.ExecuteNonQuery(cmd);
                if (iID != 0)
                    iID = Convert.ToInt32(db.GetParameterValue(cmd, "@PK_MachinesID"));
            }
            catch (Exception ex)
            {
                sException = "Machines AddMachines | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return iID;
        }
        public static bool UpdateMachines(Entity.Machines objMachines)
        {
            string sException = string.Empty;
            int iID = 0;
            bool bResult = false;
            Database db;
            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_UPDATE_MACHINES);
                db.AddInParameter(cmd, "@PK_MachinesID", DbType.Int32, objMachines.MachinesID);
                db.AddInParameter(cmd, "@MachinesName", DbType.String, objMachines.MachinesName);
                db.AddInParameter(cmd, "@TransportNumber", DbType.String, objMachines.TransportNumber);
                db.AddInParameter(cmd, "@OwnerMobileNo", DbType.String, objMachines.OwnerMobileNo);
                db.AddInParameter(cmd, "@ManagerMobileNo", DbType.String, objMachines.ManagerMobileNo);
                db.AddInParameter(cmd, "@VehicleChassisNo", DbType.String, objMachines.VehicleChassisNo);
                db.AddInParameter(cmd, "@RCNo", DbType.String, objMachines.RCNo);
                db.AddInParameter(cmd, "@RCDate", DbType.String, objMachines.sRCDate);  
                db.AddInParameter(cmd, "@InsuranceDate", DbType.String, objMachines.sInsuranceDate);
                db.AddInParameter(cmd, "@InsuranceNo", DbType.String, objMachines.InsuranceNo);
                db.AddInParameter(cmd, "@FCDate", DbType.String, objMachines.sFCDate);  
                db.AddInParameter(cmd, "@TaxDate", DbType.String, objMachines.sTaxDate); 
                db.AddInParameter(cmd, "@Address", DbType.String, objMachines.Address);
                db.AddInParameter(cmd, "@Financial_Year", DbType.String, objMachines.FinancialYear);
                db.AddInParameter(cmd, "@FK_ModifiedBy", DbType.Int32, objMachines.ModifiedBy.UserID);

                iID = db.ExecuteNonQuery(cmd);
                if (iID != 0) bResult = true;
            }
            catch (Exception ex)
            {
                sException = "Machines UpdateMachines| " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return bResult;
        }
    
    }
}
