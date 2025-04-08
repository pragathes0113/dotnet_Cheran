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
    public class Rate
    {
        public static Collection<Entity.Rate> GetRate()
        {
            string sException = string.Empty;
            Database db;
            DataSet dsList = null;
            Collection<Entity.Rate> objList = new Collection<Entity.Rate>();
            Entity.Rate objRate = new Entity.Rate();
            Entity.Agent objAgent = new Entity.Agent();
            Entity.User objCreatedUser; 
            Entity.User objModifiedUser;

            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_RATE);
                dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objRate = new Entity.Rate();
                        objAgent = new Entity.Agent();
                        objCreatedUser = new Entity.User();
                        objModifiedUser = new Entity.User();

                        objRate.RateID = Convert.ToInt32(drData["PK_RateID"]);

                        objAgent.AgentID = Convert.ToInt32(drData["FK_AgentID"]);
                        objAgent.AgentName = Convert.ToString(drData["AgentName"]);
                        objRate.Agent = objAgent;

                        objRate.RateName = Convert.ToString(drData["RateName"]);
                        objRate.RateName = Convert.ToString(drData["RateName"]);
                        objRate.FoodAllowance = Convert.ToDecimal(drData["FoodAllowance"]);
                        objRate.PipeDeapthRate = Convert.ToDecimal(drData["PipeDeapthRate"]);
                        objRate.TransportRate = Convert.ToDecimal(drData["TransportRate"]);
                        objRate.WeldingRate = Convert.ToDecimal(drData["WeldingRate"]);
                        objRate.Threehundred = Convert.ToDecimal(drData["Threehundred"]);
                        objRate.ThreehundredAmount = Convert.ToDecimal(drData["ThreehundredAmount"]);
                        objRate.Fourhundred = Convert.ToDecimal(drData["Fourhundred"]);
                        objRate.FourhundredAmount = Convert.ToDecimal(drData["FourhundredAmount"]);
                        objRate.Fivehundred = Convert.ToDecimal(drData["Fivehundred"]);
                        objRate.FivehundredAmount = Convert.ToDecimal(drData["FivehundredAmount"]);
                        objRate.Sixhundred = Convert.ToDecimal(drData["Sixhundred"]);
                        objRate.SixhundredAmount = Convert.ToDecimal(drData["SixhundredAmount"]);
                        objRate.Sevenhundred = Convert.ToDecimal(drData["Sevenhundred"]);
                        objRate.SevenhundredAmount = Convert.ToDecimal(drData["SevenhundredAmount"]);
                        objRate.Eighthundred = Convert.ToDecimal(drData["Eighthundred"]);
                        objRate.EighthundredAmount = Convert.ToDecimal(drData["EighthundredAmount"]);
                        objRate.Ninehundred = Convert.ToDecimal(drData["Ninehundred"]);
                        objRate.NinehundredAmount = Convert.ToDecimal(drData["NinehundredAmount"]);
                        objRate.Onethousand = Convert.ToDecimal(drData["Onethousand"]);
                        objRate.OnethousandAmount = Convert.ToDecimal(drData["OnethousandAmount"]);
                        objRate.OneThousandOneHundred = Convert.ToDecimal(drData["OneThousandOneHundred"]);
                        objRate.OneThousandOneHundredAmount = Convert.ToDecimal(drData["OneThousandOneHundredAmount"]);
                        objRate.OneThousandTwoHundred = Convert.ToDecimal(drData["OneThousandTwoHundred"]);
                        objRate.OneThousandTwoHundredAmount = Convert.ToDecimal(drData["OneThousandTwoHundredAmount"]);
                        objRate.OneThousandThreeHundred = Convert.ToDecimal(drData["OneThousandThreeHundred"]);
                        objRate.OneThousandThreeHundredAmount = Convert.ToDecimal(drData["OneThousandThreeHundredAmount"]);
                        objRate.OneThousandFourHundred = Convert.ToDecimal(drData["OneThousandFourHundred"]);
                        objRate.OneThousandFourHundredAmount = Convert.ToDecimal(drData["OneThousandFourHundredAmount"]);
                        objRate.OneThousandFiveHundred = Convert.ToDecimal(drData["OneThousandFiveHundred"]);
                        objRate.OneThousandFiveHundredAmount = Convert.ToDecimal(drData["OneThousandFiveHundredAmount"]);
                        objRate.OneThousandSixHundred = Convert.ToDecimal(drData["OneThousandSixHundred"]);
                        objRate.OneThousandSixHundredAmount = Convert.ToDecimal(drData["OneThousandSixHundredAmount"]);
                        objRate.OneThousandSevenHundred = Convert.ToDecimal(drData["OneThousandSevenHundred"]);
                        objRate.OneThousandSevenHundredAmount = Convert.ToDecimal(drData["OneThousandSevenHundredAmount"]);
                        objRate.OneThousandEightHundred = Convert.ToDecimal(drData["OneThousandEightHundred"]);
                        objRate.OneThousandEightHundredAmount = Convert.ToDecimal(drData["OneThousandEightHundredAmount"]);
                        objRate.OneThousandNineHundred = Convert.ToDecimal(drData["OneThousandNineHundred"]);
                        objRate.OneThousandNineHundredAmount = Convert.ToDecimal(drData["OneThousandNineHundredAmount"]);
                        objRate.TwoThousand = Convert.ToDecimal(drData["TwoThousand"]);
                        objRate.TwoThousandAmount = Convert.ToDecimal(drData["TwoThousandAmount"]);
                        objRate.TwoThousandOneHundred = Convert.ToDecimal(drData["TwoThousandOneHundred"]);
                        objRate.TwoThousandOneHundredAmount = Convert.ToDecimal(drData["TwoThousandOneHundredAmount"]);
                        objRate.TwoThousandTwoHundred = Convert.ToDecimal(drData["TwoThousandTwoHundred"]);
                        objRate.TwoThousandTwoHundredAmount = Convert.ToDecimal(drData["TwoThousandTwoHundredAmount"]);
                        objRate.TwoThousandThreeHundred = Convert.ToDecimal(drData["TwoThousandThreeHundred"]);
                        objRate.TwoThousandThreeHundredAmount = Convert.ToDecimal(drData["TwoThousandThreeHundredAmount"]);
                        objRate.TwoThousandFourHundred = Convert.ToDecimal(drData["TwoThousandFourHundred"]);
                        objRate.TwoThousandFourHundredAmount = Convert.ToDecimal(drData["TwoThousandFourHundredAmount"]);
                        objRate.TwoThousandFiveHundred = Convert.ToDecimal(drData["TwoThousandFiveHundred"]);
                        objRate.TwoThousandFiveHundredAmount = Convert.ToDecimal(drData["TwoThousandFiveHundredAmount"]);
                        objRate.TwoThousandSixHundred = Convert.ToDecimal(drData["TwoThousandSixHundred"]);
                        objRate.TwoThousandSixHundredAmount = Convert.ToDecimal(drData["TwoThousandSixHundredAmount"]);
                        objRate.TwoThousandSevenHundred = Convert.ToDecimal(drData["TwoThousandSevenHundred"]);
                        objRate.TwoThousandSevenHundredAmount = Convert.ToDecimal(drData["TwoThousandSevenHundredAmount"]);
                        objRate.TwoThousandEightHundred = Convert.ToDecimal(drData["TwoThousandEightHundred"]);
                        objRate.TwoThousandEightHundredAmount = Convert.ToDecimal(drData["TwoThousandEightHundredAmount"]);
                        objRate.TwoThousandNineHundred = Convert.ToDecimal(drData["TwoThousandNineHundred"]);
                        objRate.TwoThousandNineHundredAmount = Convert.ToDecimal(drData["TwoThousandNineHundredAmount"]);
                        objList.Add(objRate);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Rate GetRate | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objList;
        }
        public static Entity.Rate GetRateByID(int iRateID)
        {
            string sException = string.Empty;
            Database db;
            Entity.Rate objRate = new Entity.Rate();
            Entity.Agent objAgent = new Entity.Agent();
            Entity.User objCreatedUser;
            Entity.User objModifiedUser; 
            try
            {
                db = Entity.DBConnection.dbCon;
                DbCommand cmd = db.GetStoredProcCommand(constants.StoredProcedures.USP_SELECT_RATE);
                db.AddInParameter(cmd, "@PK_RateID", DbType.Int32, iRateID);
                DataSet dsList = db.ExecuteDataSet(cmd);

                if (dsList.Tables.Count > 0 && dsList.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drData in dsList.Tables[0].Rows)
                    {
                        objRate = new Entity.Rate();
                        objAgent = new Entity.Agent();
                        objCreatedUser = new Entity.User();
                        objModifiedUser = new Entity.User();

                        objRate.RateID = Convert.ToInt32(drData["PK_RateID"]);
                        objAgent.AgentID = Convert.ToInt32(drData["FK_AgentID"]);
                        objAgent.AgentName = Convert.ToString(drData["AgentName"]);
                        objRate.Agent = objAgent;
                        objRate.RateName = Convert.ToString(drData["RateName"]);
                        objRate.RateName = Convert.ToString(drData["RateName"]);
                        objRate.FoodAllowance = Convert.ToDecimal(drData["FoodAllowance"]);
                        objRate.PipeDeapthRate = Convert.ToDecimal(drData["PipeDeapthRate"]);
                        objRate.TransportRate = Convert.ToDecimal(drData["TransportRate"]);
                        objRate.WeldingRate = Convert.ToDecimal(drData["WeldingRate"]);
                        objRate.Threehundred = Convert.ToDecimal(drData["Threehundred"]);
                        objRate.ThreehundredAmount = Convert.ToDecimal(drData["ThreehundredAmount"]);
                        objRate.Fourhundred = Convert.ToDecimal(drData["Fourhundred"]);
                        objRate.FourhundredAmount = Convert.ToDecimal(drData["FourhundredAmount"]);
                        objRate.Fivehundred = Convert.ToDecimal(drData["Fivehundred"]);
                        objRate.FivehundredAmount = Convert.ToDecimal(drData["FivehundredAmount"]);
                        objRate.Sixhundred = Convert.ToDecimal(drData["Sixhundred"]);
                        objRate.SixhundredAmount = Convert.ToDecimal(drData["SixhundredAmount"]);
                        objRate.Sevenhundred = Convert.ToDecimal(drData["Sevenhundred"]);
                        objRate.SevenhundredAmount = Convert.ToDecimal(drData["SevenhundredAmount"]);
                        objRate.Eighthundred = Convert.ToDecimal(drData["Eighthundred"]);
                        objRate.EighthundredAmount = Convert.ToDecimal(drData["EighthundredAmount"]);
                        objRate.Ninehundred = Convert.ToDecimal(drData["Ninehundred"]);
                        objRate.NinehundredAmount = Convert.ToDecimal(drData["NinehundredAmount"]);
                        objRate.Onethousand = Convert.ToDecimal(drData["Onethousand"]);
                        objRate.OnethousandAmount = Convert.ToDecimal(drData["OnethousandAmount"]);
                        objRate.OneThousandOneHundred = Convert.ToDecimal(drData["OneThousandOneHundred"]);
                        objRate.OneThousandOneHundredAmount = Convert.ToDecimal(drData["OneThousandOneHundredAmount"]);
                        objRate.OneThousandTwoHundred = Convert.ToDecimal(drData["OneThousandTwoHundred"]);
                        objRate.OneThousandTwoHundredAmount = Convert.ToDecimal(drData["OneThousandTwoHundredAmount"]);
                        objRate.OneThousandThreeHundred = Convert.ToDecimal(drData["OneThousandThreeHundred"]);
                        objRate.OneThousandThreeHundredAmount = Convert.ToDecimal(drData["OneThousandThreeHundredAmount"]);
                        objRate.OneThousandFourHundred = Convert.ToDecimal(drData["OneThousandFourHundred"]);
                        objRate.OneThousandFourHundredAmount = Convert.ToDecimal(drData["OneThousandFourHundredAmount"]);
                        objRate.OneThousandFiveHundred = Convert.ToDecimal(drData["OneThousandFiveHundred"]);
                        objRate.OneThousandFiveHundredAmount = Convert.ToDecimal(drData["OneThousandFiveHundredAmount"]);
                        objRate.OneThousandSixHundred = Convert.ToDecimal(drData["OneThousandSixHundred"]);
                        objRate.OneThousandSixHundredAmount = Convert.ToDecimal(drData["OneThousandSixHundredAmount"]);
                        objRate.OneThousandSevenHundred = Convert.ToDecimal(drData["OneThousandSevenHundred"]);
                        objRate.OneThousandSevenHundredAmount = Convert.ToDecimal(drData["OneThousandSevenHundredAmount"]);
                        objRate.OneThousandEightHundred = Convert.ToDecimal(drData["OneThousandEightHundred"]);
                        objRate.OneThousandEightHundredAmount = Convert.ToDecimal(drData["OneThousandEightHundredAmount"]);
                        objRate.OneThousandNineHundred = Convert.ToDecimal(drData["OneThousandNineHundred"]);
                        objRate.OneThousandNineHundredAmount = Convert.ToDecimal(drData["OneThousandNineHundredAmount"]);
                        objRate.TwoThousand = Convert.ToDecimal(drData["TwoThousand"]);
                        objRate.TwoThousandAmount = Convert.ToDecimal(drData["TwoThousandAmount"]);
                        objRate.TwoThousandOneHundred = Convert.ToDecimal(drData["TwoThousandOneHundred"]);
                        objRate.TwoThousandOneHundredAmount = Convert.ToDecimal(drData["TwoThousandOneHundredAmount"]);
                        objRate.TwoThousandTwoHundred = Convert.ToDecimal(drData["TwoThousandTwoHundred"]);
                        objRate.TwoThousandTwoHundredAmount = Convert.ToDecimal(drData["TwoThousandTwoHundredAmount"]);
                        objRate.TwoThousandThreeHundred = Convert.ToDecimal(drData["TwoThousandThreeHundred"]);
                        objRate.TwoThousandThreeHundredAmount = Convert.ToDecimal(drData["TwoThousandThreeHundredAmount"]);
                        objRate.TwoThousandFourHundred = Convert.ToDecimal(drData["TwoThousandFourHundred"]);
                        objRate.TwoThousandFourHundredAmount = Convert.ToDecimal(drData["TwoThousandFourHundredAmount"]);
                        objRate.TwoThousandFiveHundred = Convert.ToDecimal(drData["TwoThousandFiveHundred"]);
                        objRate.TwoThousandFiveHundredAmount = Convert.ToDecimal(drData["TwoThousandFiveHundredAmount"]);
                        objRate.TwoThousandSixHundred = Convert.ToDecimal(drData["TwoThousandSixHundred"]);
                        objRate.TwoThousandSixHundredAmount = Convert.ToDecimal(drData["TwoThousandSixHundredAmount"]);
                        objRate.TwoThousandSevenHundred = Convert.ToDecimal(drData["TwoThousandSevenHundred"]);
                        objRate.TwoThousandSevenHundredAmount = Convert.ToDecimal(drData["TwoThousandSevenHundredAmount"]);
                        objRate.TwoThousandEightHundred = Convert.ToDecimal(drData["TwoThousandEightHundred"]);
                        objRate.TwoThousandEightHundredAmount = Convert.ToDecimal(drData["TwoThousandEightHundredAmount"]);
                        objRate.TwoThousandNineHundred = Convert.ToDecimal(drData["TwoThousandNineHundred"]);
                        objRate.TwoThousandNineHundredAmount = Convert.ToDecimal(drData["TwoThousandNineHundredAmount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Rate GetRateByID | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return objRate;
        }
        public static int AddRate(Entity.Rate objRate)
        {
            int ID = 0;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    ID = AddRate(oDb, objRate, oTrans);
                    oTrans.Commit();
                    if (ID > 0)
                        Framework.InsertAuditLog("tRate", "PK_RateID", objRate.RateID.ToString(), (char)Entity.Common.DatabaseAction.INSERT, objRate.CreatedBy.UserID);
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


        private static int AddRate(Database oDb, Entity.Rate objRate, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iID = 0;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_INSERT_RATE);
                oDb.AddOutParameter(cmd, "@PK_RateID", DbType.Int32, objRate.RateID);
                oDb.AddInParameter(cmd, "@FK_AgentID", DbType.Int32, objRate.Agent.AgentID);
                oDb.AddInParameter(cmd, "@RateName", DbType.String, objRate.RateName);
                oDb.AddInParameter(cmd, "@FoodAllowance", DbType.Decimal, objRate.FoodAllowance);
                oDb.AddInParameter(cmd, "@PipeDeapthRate", DbType.Decimal, objRate.PipeDeapthRate);
                oDb.AddInParameter(cmd, "@TransportRate", DbType.Decimal, objRate.TransportRate);
                oDb.AddInParameter(cmd, "@WeldingRate", DbType.Decimal, objRate.WeldingRate);
                oDb.AddInParameter(cmd, "@Threehundred", DbType.Decimal, objRate.Threehundred);
                oDb.AddInParameter(cmd, "@ThreehundredAmount", DbType.Decimal, objRate.ThreehundredAmount);
                oDb.AddInParameter(cmd, "@Fourhundred", DbType.Decimal, objRate.Fourhundred);
                oDb.AddInParameter(cmd, "@FourhundredAmount", DbType.Decimal, objRate.FourhundredAmount);
                oDb.AddInParameter(cmd, "@Fivehundred", DbType.Decimal, objRate.Fivehundred);
                oDb.AddInParameter(cmd, "@FivehundredAmount", DbType.Decimal, objRate.FivehundredAmount);
                oDb.AddInParameter(cmd, "@Sixhundred", DbType.Decimal, objRate.Sixhundred);
                oDb.AddInParameter(cmd, "@SixhundredAmount", DbType.Decimal, objRate.SixhundredAmount);
                oDb.AddInParameter(cmd, "@Sevenhundred", DbType.Decimal, objRate.Sevenhundred);
                oDb.AddInParameter(cmd, "@SevenhundredAmount", DbType.Decimal, objRate.SevenhundredAmount);
                oDb.AddInParameter(cmd, "@Eighthundred", DbType.Decimal, objRate.Eighthundred);
                oDb.AddInParameter(cmd, "@EighthundredAmount", DbType.Decimal, objRate.EighthundredAmount);
                oDb.AddInParameter(cmd, "@Ninehundred", DbType.Decimal, objRate.Ninehundred);
                oDb.AddInParameter(cmd, "@NinehundredAmount", DbType.Decimal, objRate.NinehundredAmount);
                oDb.AddInParameter(cmd, "@Onethousand", DbType.Decimal, objRate.Onethousand);
                oDb.AddInParameter(cmd, "@OnethousandAmount", DbType.Decimal, objRate.OnethousandAmount);
                oDb.AddInParameter(cmd, "@OneThousandOneHundred", DbType.Decimal, objRate.OneThousandOneHundred);
                oDb.AddInParameter(cmd, "@OneThousandOneHundredAmount", DbType.Decimal, objRate.OneThousandOneHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandTwoHundred", DbType.Decimal, objRate.OneThousandTwoHundred);
                oDb.AddInParameter(cmd, "@OneThousandTwoHundredAmount", DbType.Decimal, objRate.OneThousandTwoHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandThreeHundred", DbType.Decimal, objRate.OneThousandThreeHundred);
                oDb.AddInParameter(cmd, "@OneThousandThreeHundredAmount", DbType.Decimal, objRate.OneThousandThreeHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandFourHundred", DbType.Decimal, objRate.OneThousandFourHundred);
                oDb.AddInParameter(cmd, "@OneThousandFourHundredAmount", DbType.Decimal, objRate.OneThousandFourHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandFiveHundred", DbType.Decimal, objRate.OneThousandFiveHundred);
                oDb.AddInParameter(cmd, "@OneThousandFiveHundredAmount", DbType.Decimal, objRate.OneThousandFiveHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandSixHundred", DbType.Decimal, objRate.OneThousandSixHundred);
                oDb.AddInParameter(cmd, "@OneThousandSixHundredAmount", DbType.Decimal, objRate.OneThousandSixHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandSevenHundred", DbType.Decimal, objRate.OneThousandSevenHundred);
                oDb.AddInParameter(cmd, "@OneThousandSevenHundredAmount", DbType.Decimal, objRate.OneThousandSevenHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandEightHundred", DbType.Decimal, objRate.OneThousandEightHundred);
                oDb.AddInParameter(cmd, "@OneThousandEightHundredAmount", DbType.Decimal, objRate.OneThousandEightHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandNineHundred", DbType.Decimal, objRate.OneThousandNineHundred);
                oDb.AddInParameter(cmd, "@OneThousandNineHundredAmount", DbType.Decimal, objRate.OneThousandNineHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousand", DbType.Decimal, objRate.TwoThousand);
                oDb.AddInParameter(cmd, "@TwoThousandAmount", DbType.Decimal, objRate.TwoThousandAmount);
                oDb.AddInParameter(cmd, "@TwoThousandOneHundred", DbType.Decimal, objRate.TwoThousandOneHundred);
                oDb.AddInParameter(cmd, "@TwoThousandOneHundredAmount", DbType.Decimal, objRate.TwoThousandOneHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandTwoHundred", DbType.Decimal, objRate.TwoThousandTwoHundred);
                oDb.AddInParameter(cmd, "@TwoThousandTwoHundredAmount", DbType.Decimal, objRate.TwoThousandTwoHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandThreeHundred", DbType.Decimal, objRate.TwoThousandThreeHundred);
                oDb.AddInParameter(cmd, "@TwoThousandThreeHundredAmount", DbType.Decimal, objRate.TwoThousandThreeHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandFourHundred", DbType.Decimal, objRate.TwoThousandFourHundred);
                oDb.AddInParameter(cmd, "@TwoThousandFourHundredAmount", DbType.Decimal, objRate.TwoThousandFourHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandFiveHundred", DbType.Decimal, objRate.TwoThousandFiveHundred);
                oDb.AddInParameter(cmd, "@TwoThousandFiveHundredAmount", DbType.Decimal, objRate.TwoThousandFiveHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandSixHundred", DbType.Decimal, objRate.TwoThousandSixHundred);
                oDb.AddInParameter(cmd, "@TwoThousandSixHundredAmount", DbType.Decimal, objRate.TwoThousandSixHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandSevenHundred", DbType.Decimal, objRate.TwoThousandSevenHundred);
                oDb.AddInParameter(cmd, "@TwoThousandSevenHundredAmount", DbType.Decimal, objRate.TwoThousandSevenHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandEightHundred", DbType.Decimal, objRate.TwoThousandEightHundred);
                oDb.AddInParameter(cmd, "@TwoThousandEightHundredAmount", DbType.Decimal, objRate.TwoThousandEightHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandNineHundred", DbType.Decimal, objRate.TwoThousandNineHundred);
                oDb.AddInParameter(cmd, "@TwoThousandNineHundredAmount", DbType.Decimal, objRate.TwoThousandNineHundredAmount);
                oDb.AddInParameter(cmd, "@FK_CreatedBy", DbType.Int32, objRate.CreatedBy.UserID);

                iID = oDb.ExecuteNonQuery(cmd, oTrans);
                if (iID != 0)
                {
                    iID = Convert.ToInt32(oDb.GetParameterValue(cmd, "@PK_RateID"));
                    objRate.RateID = iID;
                }
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Rate AddRate | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return iID;
        }

        public static bool UpdateRate(Entity.Rate objRate)
        {
            bool IsUpdated = true;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    IsUpdated = UpdateRate(oDb, objRate, oTrans);
                    oTrans.Commit();
                    if (IsUpdated) Framework.InsertAuditLog("tRate", "PK_RateID", objRate.RateID.ToString(), (char)Entity.Common.DatabaseAction.UPDATE, objRate.ModifiedBy.UserID);
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
        private static bool UpdateRate(Database oDb, Entity.Rate objRate, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iID = 0;
            bool bResult = false;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_UPDATE_RATE);
                oDb.AddInParameter(cmd, "@PK_RateID", DbType.Int32, objRate.RateID);
                oDb.AddInParameter(cmd, "@FK_AgentID", DbType.Int32, objRate.Agent.AgentID);
                oDb.AddInParameter(cmd, "@RateName", DbType.String, objRate.RateName);
                oDb.AddInParameter(cmd, "@FoodAllowance", DbType.Decimal, objRate.FoodAllowance);
                oDb.AddInParameter(cmd, "@PipeDeapthRate", DbType.Decimal, objRate.PipeDeapthRate);
                oDb.AddInParameter(cmd, "@TransportRate", DbType.Decimal, objRate.TransportRate);
                oDb.AddInParameter(cmd, "@WeldingRate", DbType.Decimal, objRate.WeldingRate);
                oDb.AddInParameter(cmd, "@Threehundred", DbType.Decimal, objRate.Threehundred);
                oDb.AddInParameter(cmd, "@ThreehundredAmount", DbType.Decimal, objRate.ThreehundredAmount);
                oDb.AddInParameter(cmd, "@Fourhundred", DbType.Decimal, objRate.Fourhundred);
                oDb.AddInParameter(cmd, "@FourhundredAmount", DbType.Decimal, objRate.FourhundredAmount);
                oDb.AddInParameter(cmd, "@Fivehundred", DbType.Decimal, objRate.Fivehundred);
                oDb.AddInParameter(cmd, "@FivehundredAmount", DbType.Decimal, objRate.FivehundredAmount);
                oDb.AddInParameter(cmd, "@Sixhundred", DbType.Decimal, objRate.Sixhundred);
                oDb.AddInParameter(cmd, "@SixhundredAmount", DbType.Decimal, objRate.SixhundredAmount);
                oDb.AddInParameter(cmd, "@Sevenhundred", DbType.Decimal, objRate.Sevenhundred);
                oDb.AddInParameter(cmd, "@SevenhundredAmount", DbType.Decimal, objRate.SevenhundredAmount);
                oDb.AddInParameter(cmd, "@Eighthundred", DbType.Decimal, objRate.Eighthundred);
                oDb.AddInParameter(cmd, "@EighthundredAmount", DbType.Decimal, objRate.EighthundredAmount);
                oDb.AddInParameter(cmd, "@Ninehundred", DbType.Decimal, objRate.Ninehundred);
                oDb.AddInParameter(cmd, "@NinehundredAmount", DbType.Decimal, objRate.NinehundredAmount);
                oDb.AddInParameter(cmd, "@Onethousand", DbType.Decimal, objRate.Onethousand);
                oDb.AddInParameter(cmd, "@OnethousandAmount", DbType.Decimal, objRate.OnethousandAmount);
                oDb.AddInParameter(cmd, "@OneThousandOneHundred", DbType.Decimal, objRate.OneThousandOneHundred);
                oDb.AddInParameter(cmd, "@OneThousandOneHundredAmount", DbType.Decimal, objRate.OneThousandOneHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandTwoHundred", DbType.Decimal, objRate.OneThousandTwoHundred);
                oDb.AddInParameter(cmd, "@OneThousandTwoHundredAmount", DbType.Decimal, objRate.OneThousandTwoHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandThreeHundred", DbType.Decimal, objRate.OneThousandThreeHundred);
                oDb.AddInParameter(cmd, "@OneThousandThreeHundredAmount", DbType.Decimal, objRate.OneThousandThreeHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandFourHundred", DbType.Decimal, objRate.OneThousandFourHundred);
                oDb.AddInParameter(cmd, "@OneThousandFourHundredAmount", DbType.Decimal, objRate.OneThousandFourHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandFiveHundred", DbType.Decimal, objRate.OneThousandFiveHundred);
                oDb.AddInParameter(cmd, "@OneThousandFiveHundredAmount", DbType.Decimal, objRate.OneThousandFiveHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandSixHundred", DbType.Decimal, objRate.OneThousandSixHundred);
                oDb.AddInParameter(cmd, "@OneThousandSixHundredAmount", DbType.Decimal, objRate.OneThousandSixHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandSevenHundred", DbType.Decimal, objRate.OneThousandSevenHundred);
                oDb.AddInParameter(cmd, "@OneThousandSevenHundredAmount", DbType.Decimal, objRate.OneThousandSevenHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandEightHundred", DbType.Decimal, objRate.OneThousandEightHundred);
                oDb.AddInParameter(cmd, "@OneThousandEightHundredAmount", DbType.Decimal, objRate.OneThousandEightHundredAmount);
                oDb.AddInParameter(cmd, "@OneThousandNineHundred", DbType.Decimal, objRate.OneThousandNineHundred);
                oDb.AddInParameter(cmd, "@OneThousandNineHundredAmount", DbType.Decimal, objRate.OneThousandNineHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousand", DbType.Decimal, objRate.TwoThousand);
                oDb.AddInParameter(cmd, "@TwoThousandAmount", DbType.Decimal, objRate.TwoThousandAmount);
                oDb.AddInParameter(cmd, "@TwoThousandOneHundred", DbType.Decimal, objRate.TwoThousandOneHundred);
                oDb.AddInParameter(cmd, "@TwoThousandOneHundredAmount", DbType.Decimal, objRate.TwoThousandOneHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandTwoHundred", DbType.Decimal, objRate.TwoThousandTwoHundred);
                oDb.AddInParameter(cmd, "@TwoThousandTwoHundredAmount", DbType.Decimal, objRate.TwoThousandTwoHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandThreeHundred", DbType.Decimal, objRate.TwoThousandThreeHundred);
                oDb.AddInParameter(cmd, "@TwoThousandThreeHundredAmount", DbType.Decimal, objRate.TwoThousandThreeHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandFourHundred", DbType.Decimal, objRate.TwoThousandFourHundred);
                oDb.AddInParameter(cmd, "@TwoThousandFourHundredAmount", DbType.Decimal, objRate.TwoThousandFourHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandFiveHundred", DbType.Decimal, objRate.TwoThousandFiveHundred);
                oDb.AddInParameter(cmd, "@TwoThousandFiveHundredAmount", DbType.Decimal, objRate.TwoThousandFiveHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandSixHundred", DbType.Decimal, objRate.TwoThousandSixHundred);
                oDb.AddInParameter(cmd, "@TwoThousandSixHundredAmount", DbType.Decimal, objRate.TwoThousandSixHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandSevenHundred", DbType.Decimal, objRate.TwoThousandSevenHundred);
                oDb.AddInParameter(cmd, "@TwoThousandSevenHundredAmount", DbType.Decimal, objRate.TwoThousandSevenHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandEightHundred", DbType.Decimal, objRate.TwoThousandEightHundred);
                oDb.AddInParameter(cmd, "@TwoThousandEightHundredAmount", DbType.Decimal, objRate.TwoThousandEightHundredAmount);
                oDb.AddInParameter(cmd, "@TwoThousandNineHundred", DbType.Decimal, objRate.TwoThousandNineHundred);
                oDb.AddInParameter(cmd, "@TwoThousandNineHundredAmount", DbType.Decimal, objRate.TwoThousandNineHundredAmount);
                oDb.AddInParameter(cmd, "@FK_ModifiedBy", DbType.Int32, objRate.ModifiedBy.UserID);
                iID = oDb.ExecuteNonQuery(cmd);
                if (iID != 0) bResult = true;
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Rate UpdateRate | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return bResult;
        }
        public static bool DeleteRate(int ID, int UserID)
        {
            bool IsDeleted = false;
            Database oDb = Entity.DBConnection.dbCon;
            using (DbConnection oDbCon = oDb.CreateConnection())
            {
                oDbCon.Open();
                DbTransaction oTrans = oDbCon.BeginTransaction();
                try
                {
                    IsDeleted = DeleteRate(oDb, ID, UserID, oTrans);
                    oTrans.Commit();

                    if (IsDeleted) Framework.InsertAuditLog("tRate", "PK_RateID", ID.ToString(), (char)Entity.Common.DatabaseAction.DELETE, UserID);
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
        private static bool DeleteRate(Database oDb, int ID, int UserID, DbTransaction oTrans)
        {
            string sException = string.Empty;
            int iRemoveId = 0;
            bool bResult = false;
            try
            {
                DbCommand cmd = oDb.GetStoredProcCommand(constants.StoredProcedures.USP_DELETE_RATE);
                oDb.AddInParameter(cmd, "@PK_RateID", DbType.Int32, ID);
                iRemoveId = oDb.ExecuteNonQuery(cmd);
                if (iRemoveId != 0) bResult = true;
            }
            catch (Exception ex)
            {
                sException = "VHMS.DataAccess.Rate DeleteRate | " + ex.ToString();
                Log.Write(sException);
                throw;
            }
            return bResult;
        }
    }
}
