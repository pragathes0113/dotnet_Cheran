namespace constants
{
    public class StoredProcedures
    {
        //User
        public const string USP_SELECT_USERLOGIN = "usp_Select_UserLogin";
        public const string USP_SELECT_MODULE = "usp_Select_Module";
        public const string USP_CHANGEPASSWORD = "usp_ChangePassword";
        public const string USP_INSERT_USER = "usp_Insert_User";
        public const string USP_UPDATE_USER = "usp_Update_User";
        public const string USP_DELETE_USER = "usp_Delete_User";
        public const string USP_SELECT_USER = "usp_Select_User";
        public const string USP_INSERT_LOG = "usp_Insert_Log";
        public const string USP_SELECT_LASTINVOICENO = "usp_Select_LastInvoiceNo";
        public const string USP_INSERT_VISITLOG = "usp_Insert_VisitLog";
        public const string USP_SELECT_VISITLOG = "usp_Select_VisitLog";
        public const string USP_SELECT_PURCHASEBARCODE = "usp_Select_PurchaseBarcode";
        public const string USP_SELECT_WHOLESALESTOTALAMOUNT = "usp_Select_WholeSalesTotalAmount";
        public const string USP_SELECT_TEMPLATE = "usp_Select_Template";
        public const string USP_UPDATE_TEMPLATE = "usp_Update_Template";
        //Dashboard
        public const string USP_SELECT_DASHBOARDCOUNT = "usp_Select_DashboardCount";
        public const string USP_SELECT_DASHBOARDWEEKLYSALES = "usp_Select_DashboardWeeklySales";
        //Settings
        public const string USP_UPDATE_SETTINGS = "usp_Update_Settings";
        public const string USP_SELECT_SETTINGS = "usp_Select_Settings";
        public const string USP_SELECT_LEDGERCUSTOMER = "usp_Select_LedgerCustomer";
        public const string USP_SELECT_LEDGERRETAILSCUSTOMER = "usp_Select_LedgerRetailsCustomer";
        public const string USP_SELECT_SALESRETURNCUSTOMER = "usp_Select_SalesReturnCustomer";
        public const string RPT_SELECT_PAYMENT = "RPT_Select_Payment";
        public const string RPT_SELECT_RECEIPT = "RPT_Select_Receipt";
        //Roles
        public const string USP_INSERT_ROLE = "usp_Insert_Role";
        public const string USP_UPDATE_ROLE = "usp_Update_Role";
        public const string USP_DELETE_ROLE = "usp_Delete_Role";
        public const string USP_SELECT_ROLE = "usp_Select_Role";
        //Machines
        public const string USP_INSERT_MACHINES = "usp_Insert_Machines";
        public const string USP_UPDATE_MACHINES = "usp_Update_Machines";
        public const string USP_SELECT_MACHINES = "usp_Select_Machines";
        public const string USP_UPDATE_SETTINGS_NOTIFICATION = "usp_Update_Settings_Notification";
        public const string USP_SELECT_SETTING_NOTIFICATION = "usp_Select_Setting_Notification";
        //RoleConfigurtaion
        public const string USP_SELECT_ROLECONFIGURATION = "usp_Select_RoleConfiguration";
        public const string USP_INSERT_ROLECONFIGURATION = "usp_Insert_RoleConfiguration";
        public const string USP_UPDATE_ROLECONFIGURATION = "usp_Update_RoleConfiguration";
        public const string USP_DELETE_ROLECONFIGURATION = "usp_Delete_RoleConfiguration";
        public const string USP_INSERT_AUDITALL = "usp_Insert_AuditAll"; //Log Database
        //Payment
        public const string USP_INSERT_PAYMENT = "usp_Insert_Payment";
        public const string USP_UPDATE_PAYMENT = "usp_Update_Payment";
        public const string USP_DELETE_PAYMENT = "usp_Delete_Payment";
        public const string USP_SELECT_PAYMENT = "usp_Select_Payment";
        public const string USP_SELECT_RECENTPAYMENT = "usp_Select_RecentPayment";

        //Employee
        public const string USP_INSERT_EMPLOYEE = "usp_Insert_Employee";
        public const string USP_UPDATE_EMPLOYEE = "usp_Update_Employee";
        public const string USP_DELETE_EMPLOYEE = "usp_Delete_Employee";
        public const string USP_SELECT_EMPLOYEE = "usp_Select_Employee";
        public const string USP_UPDATE_EMPLOYEE_AMOUNT = "usp_Update_Employee_Amount";
        public const string USP_RESET_PASSWORD = "usp_Reset_Password";
        //FinancialYear
        public const string USP_INSERT_FINANCIALYEAR = "usp_Insert_FinancialYear";
        public const string USP_UPDATE_FINANCIALYEAR = "usp_Update_FinancialYear";
        public const string USP_DELETE_FINANCIALYEAR = "usp_Delete_FinancialYear";
        public const string USP_SELECT_FINANCIALYEAR = "usp_Select_FinancialYear";

        //State
        public const string USP_INSERT_STATE = "usp_Insert_State";
        public const string USP_UPDATE_STATE = "usp_Update_State";
        public const string USP_DELETE_STATE = "usp_Delete_State";
        public const string USP_SELECT_STATE = "usp_Select_State";
        public const string USP_SELECT_DASHBOARD = "usp_Select_Dashboard";
        public const string USP_SELECT_RECENTADMISSION = "usp_Select_RecentAdmission";
        public const string USP_INSERT_SMSLOG = "usp_Insert_SMSLog";

        //Rate 
        public const string USP_INSERT_RATE = "usp_Insert_Rate";
        public const string USP_UPDATE_RATE = "usp_Update_Rate";
        public const string USP_DELETE_RATE = "usp_Delete_Rate";
        public const string USP_SELECT_RATE = "usp_Select_Rate";

        //Agent
        public const string USP_SELECT_AGENT = "usp_Select_Agent";
        public const string USP_DELETE_AGENT = "usp_Delete_Agent";
        public const string USP_INSERT_AGENT = "usp_Insert_Agent";
        public const string USP_UPDATE_AGENT = "usp_Update_Agent";
    }
}