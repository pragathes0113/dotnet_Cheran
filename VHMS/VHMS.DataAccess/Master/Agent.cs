using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Collections.ObjectModel;
using VHMS;

namespace VHMS.DataAccess
{
    public class Agent
    {
        public static Collection<Entity.Agent> GetAgent()
        {
            string sException = string.Empty;
            Database db;
            DataSet dsList = null;
            Collection<Entity.Agent> objList = new Collection<Entity.Agent>();
            Entity.Agent objAgent = new Entity.Agent();
            Entity.User objCreatedUser;
            Entity.Rate objRate;
            Entity.User objModifiedUser;

            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_AGENT);
                dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objAgent = new Entity.Agent();
                        objCreatedUser = new Entity.User();

                        objModifiedUser = new Entity.User();
                        objAgent.AgentID = Convert.ToInt32(drData["PK_AgentID"]);
                        objAgent.AgentName = Convert.ToString(drData["AgentName"]);
                        objAgent.Address = Convert.ToString(drData["Address"]);
                        objAgent.MobileNo = Convert.ToString(drData["MobileNo"]);
                        objAgent.AlternateNo = Convert.ToString(drData["AlternateNo"]);
                        objAgent.WhatsappNo = Convert.ToString(drData["WhatsappNo"]);
                        objAgent.IsActive = Convert.ToBoolean(drData["IsActive"]);
                        objList.Add(objAgent);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Agent GetAgent | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objList;
        }
        public static Entity.Agent GetAgentByID(int iAgentID)
        {
            string sException = string.Empty;
            Database db;
            Entity.Agent objAgent = new Entity.Agent();
            Entity.User objCreatedUser;
            Entity.User objModifiedUser; 

            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_AGENT);
                db.AddInParameter(cmd, "@PK_AgentID", DbType.Int32, iAgentID);
                DataSet dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objAgent = new Entity.Agent();
                        
                        objCreatedUser = new Entity.User();
                        objModifiedUser = new Entity.User();
                        objAgent.AgentID = Convert.ToInt32(drData["PK_AgentID"]);
                        objAgent.AgentName = Convert.ToString(drData["AgentName"]);
                        objAgent.Address = Convert.ToString(drData["Address"]);
                        objAgent.MobileNo = Convert.ToString(drData["MobileNo"]);
                        objAgent.AlternateNo = Convert.ToString(drData["AlternateNo"]);
                        objAgent.WhatsappNo = Convert.ToString(drData["WhatsappNo"]);
                        objAgent.IsActive = Convert.ToBoolean(drData["IsActive"]);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Agent GetAgentByID | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objAgent;
        }
        public static int AddAgent(Entity.Agent objAgent)
        {
            int ID = 0;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    ID = AddAgent(oDb, objAgent, oTrans);
                    oTrans.Commit();
                    if (ID > 0)
                        Framework.InsertAuditLog("tAgent", "PK_AgentID", objAgent.AgentID.ToString(), (char)Entity.Common.DatabaseAction.INSERT, objAgent.CreatedBy.UserID);
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
                finally
                {
                    oDbCon.Close();
                }
            }
            return ID;
        }
        private static int AddAgent(Database oDb, Entity.Agent objAgent, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iID = 0;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_INSERT_AGENT);
                oDb.AddOutParameter(cmd, "@PK_AgentID", DbType.Int32, objAgent.AgentID);
                oDb.AddInParameter(cmd, "@AgentName", DbType.String, objAgent.AgentName);
                oDb.AddInParameter(cmd, "@Address", DbType.String, objAgent.Address);
                oDb.AddInParameter(cmd, "@MobileNo", DbType.String, objAgent.MobileNo);
                oDb.AddInParameter(cmd, "@WhatsappNo", DbType.String, objAgent.WhatsappNo);
                oDb.AddInParameter(cmd, "@AlternateNo", DbType.String, objAgent.AlternateNo);
                oDb.AddInParameter(cmd, "@IsActive", DbType.Boolean, objAgent.IsActive);
                oDb.AddInParameter(cmd, "@FK_CreatedBy", DbType.Int32, objAgent.CreatedBy.UserID);

                iID = oDb.ExecuteNonQuery(cmd, oTrans);
                if (iID != 0)
                {
                    iID = Convert.ToInt32(oDb.GetParameterValue(cmd, "@PK_AgentID"));
                    objAgent.AgentID = iID;
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Agent AddAgent | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return iID;
        }
        public static bool UpdateAgent(Entity.Agent objAgent)
        {
            bool IsUpdated = true;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    IsUpdated = UpdateAgent(oDb, objAgent, oTrans);
                    oTrans.Commit();
                    if (IsUpdated) Framework.InsertAuditLog("tAgent", "PK_AgentID", objAgent.AgentID.ToString(), (char)Entity.Common.DatabaseAction.UPDATE, objAgent.ModifiedBy.UserID);
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
                finally
                {
                    oDbCon.Close();
                }
            }
            return IsUpdated;
        }
        private static bool UpdateAgent(Database oDb, Entity.Agent objAgent, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iID = 0;
            bool bResult = false;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_UPDATE_AGENT);
                oDb.AddInParameter(cmd, "@PK_AgentID", DbType.Int32, objAgent.AgentID);
                oDb.AddInParameter(cmd, "@AgentName", DbType.String, objAgent.AgentName);
                oDb.AddInParameter(cmd, "@Address", DbType.String, objAgent.Address);
                oDb.AddInParameter(cmd, "@MobileNo", DbType.String, objAgent.MobileNo);
                oDb.AddInParameter(cmd, "@WhatsappNo", DbType.String, objAgent.WhatsappNo);
                oDb.AddInParameter(cmd, "@AlternateNo", DbType.String, objAgent.AlternateNo);
                oDb.AddInParameter(cmd, "@IsActive", DbType.Boolean, objAgent.IsActive);
                oDb.AddInParameter(cmd, "@FK_ModifiedBy", DbType.Int32, objAgent.ModifiedBy.UserID);
                iID = oDb.ExecuteNonQuery(cmd);
                if (iID != 0) bResult = true;
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Agent UpdateAgent | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return bResult;
        }
        public static bool DeleteAgent(int ID, int UserID)
        {
            bool IsDeleted = false;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    IsDeleted = DeleteAgent(oDb, ID, UserID, oTrans);
                    oTrans.Commit();

                    if (IsDeleted) Framework.InsertAuditLog("tAgent", "PK_AgentID", ID.ToString(), (char)Entity.Common.DatabaseAction.DELETE, UserID);
                }
                catch (Exception ex)
                {
                    oTrans.Rollback();
                    throw ex;
                }
                finally
                {
                    oDbCon.Close();
                }
            }
            return IsDeleted;
        }
        private static bool DeleteAgent(Database oDb, int ID, int UserID, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iRemoveId = 0;
            bool bResult = false;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_DELETE_AGENT );
                oDb.AddInParameter(cmd, "@PK_AgentID", DbType.Int32, ID);
                iRemoveId = oDb.ExecuteNonQuery(cmd);
                if (iRemoveId != 0) bResult = true;
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Agent DeleteAgent | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return bResult;
        }
    }
}
