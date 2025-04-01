using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VHMSReportPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Assembly assembly = Assembly.Load("App_Code");
            string version = assembly.GetName().Version.ToString();

            divFooterLeft.InnerHtml = "Copyright <b><a target='_blank'>KVA Tech</a></b> &copy; "+ DateTime.Now.Year.ToString()+ " , <strong><a>"+ Session["MachinesName"].ToString().ToUpper()+ "</a></strong> v" + version;
            divLatestUpdate.InnerHtml = "Last Updated on " + GetAssemblyDate();
            VijayaTopMenuBar.InnerHtml = string.Empty;
            DrawTopMenuBar();
        }
        catch (Exception ex)
        { ex.ToString(); }
    }
    private string GetAssemblyDate()
    {
        string date = string.Empty;
        try
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileInfo = new FileInfo(assembly.Location);
            var writeTime = fileInfo.LastWriteTime;
            date = String.Format("{0} {1}", writeTime.ToString("dd MMM yyyy"), writeTime.ToShortTimeString());
        }
        catch (Exception ex)
        {
            Log.Write("SWFMasterPage - GetAssemblyDate | " + ex.ToString());
            return "";
        }
        return date;
    }
    private void DrawTopMenuBar()
    {
        string sPath = string.Empty;
        StringBuilder sbTopMenuBar = new StringBuilder();
        int Machines_MenuID = 1;
        try
        {
            int RoleID = Convert.ToInt32(Session["RoleID"]);
            DataSet dsPrivilege = VHMS.DataAccess.RoleConfiguration.GetRoleConfigurationByRoleID(RoleID);
            if (dsPrivilege.Tables.Count > 0 && dsPrivilege.Tables[0].Rows.Count > 0)
            {
                var qPrivilege = (from t in dsPrivilege.Tables[0].AsEnumerable()
                                  select new
                                  {
                                      fd_roleconfiguration_id = t.Field<int>("PK_RoleConfigurationID"),
                                      fd_menu_id = t.Field<int>("FK_MenuID"),
                                      fd_menuname = t.Field<string>("MenuName"),
                                      fd_module_id = t.Field<int>("FK_ModuleID"),
                                      fd_modulename = t.Field<string>("ModuleName"),
                                      fd_OrderNo = t.Field<int>("OrderNo"),
                                      fd_filename = t.Field<string>("FileName"),
                                      fd_IsAccess = t.Field<bool>("IsAccess"),
                                      fd_IsView = t.Field<bool>("IsView"),
                                      fd_IsAdd = t.Field<bool>("IsAdd"),
                                      fd_IsEdit = t.Field<bool>("IsEdit"),
                                      fd_IsDelete = t.Field<bool>("IsDelete")
                                  }).Where(t => t.fd_IsAccess == true);

                sbTopMenuBar.Append("<ul class='nav navbar-nav'>"); //Menu Start
                if (qPrivilege.Count() > 0)
                {
                    if ((from t in qPrivilege where t.fd_menu_id == 3 select t).Count() > 0) //Machines Menu
                        sbTopMenuBar.Append("<li class='dropdown'><a href='frmMachines.aspx'>Machines</a></li>");

                    if ((from t in qPrivilege where t.fd_menu_id == 2 select t).Count() > 0) //Master
                    {
                        sbTopMenuBar.Append("<li class='dropdown'><a href='#' class='dropdown-toggle' data-toggle='dropdown' aria-expanded='false'>Master<span class='caret'></span></a>");
                        sbTopMenuBar.Append("<ul class='dropdown-menu' role='menu'>");
                        var qMasterMenu = (from t in qPrivilege where t.fd_menu_id == 2 select t).OrderBy(o => o.fd_OrderNo);
                        int MenuItemCount = qMasterMenu.Count();
                        foreach (var qMenuItem in qMasterMenu)
                        {
                            if (qMenuItem.fd_modulename != "Add Patient" && qMenuItem.fd_OrderNo > 0)
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'>" + qMenuItem.fd_modulename + "</a></li>");
                        }

                        sbTopMenuBar.Append("</ul>");
                    }
                    if ((from t in qPrivilege where t.fd_menu_id == 5 select t).Count() > 0) //Master
                    {
                        sbTopMenuBar.Append("<li class='dropdown'><a href='#' class='dropdown-toggle' data-toggle='dropdown' aria-expanded='false'>Billing<span class='caret'></span></a>");
                        sbTopMenuBar.Append("<ul class='dropdown-menu' role='menu'>");
                        var qMasterMenu = (from t in qPrivilege where t.fd_menu_id == 5 select t).OrderBy(o => o.fd_OrderNo);
                        int MenuItemCount = qMasterMenu.Count();
                        foreach (var qMenuItem in qMasterMenu)
                            if (qMenuItem.fd_OrderNo > 0)
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'>" + qMenuItem.fd_modulename + "</a></li>");

                        sbTopMenuBar.Append("</ul>");
                    }
                    if ((from t in qPrivilege where t.fd_menu_id == 4 select t).Count() > 0) //Master
                    {
                        sbTopMenuBar.Append("<li class='dropdown'><a href='#' class='dropdown-toggle' data-toggle='dropdown' aria-expanded='false'>Reports<span class='caret'></span></a>");
                        sbTopMenuBar.Append("<ul class='dropdown-menu' role='menu'>");
                        var qMasterMenu = (from t in qPrivilege where t.fd_menu_id == 4 select t).OrderBy(o => o.fd_OrderNo);
                        int MenuItemCount = qMasterMenu.Count();
                        foreach (var qMenuItem in qMasterMenu)
                            if (qMenuItem.fd_OrderNo > 0)
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'>" + qMenuItem.fd_modulename + "</a></li>");

                        sbTopMenuBar.Append("</ul>");
                    }


                    if ((from t in qPrivilege where t.fd_menu_id == 1 select t).Count() > 0) //Accounts
                    {
                        sbTopMenuBar.Append("<li class='dropdown'><a href='#' class='dropdown-toggle' data-toggle='dropdown' aria-expanded='false'>Accounts<span class='caret'></span></a>");
                        sbTopMenuBar.Append("<ul class='dropdown-menu' role='menu'>");
                        var qUserAccountsMenu = (from t in qPrivilege where t.fd_menu_id == 1 select t).OrderBy(o => o.fd_OrderNo);
                        int MenuItemCount = qUserAccountsMenu.Count();
                        int i = 1;
                        foreach (var qMenuItem in qUserAccountsMenu)
                        {
                            if (qMenuItem.fd_modulename == "User")
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'><i class='fa fa-users'></i>" + qMenuItem.fd_modulename + "</a></li>");
                            else if (qMenuItem.fd_modulename == "User Privileges")
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'><i class='fa fa-wrench'></i>" + qMenuItem.fd_modulename + "</a></li>");
                            else
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'>" + qMenuItem.fd_modulename + "</a></li>");

                            if (i != MenuItemCount) sbTopMenuBar.Append("<li class='divider'></li>");
                            i++;
                        }
                        sbTopMenuBar.Append("</ul>");
                    }
                    if ((from t in qPrivilege where t.fd_menu_id == 21 select t).Count() > 0) //Master
                    {
                        sbTopMenuBar.Append("<li class='dropdown'><a href='#' class='dropdown-toggle' data-toggle='dropdown' aria-expanded='false'>Duplicate Sales<span class='caret'></span></a>");
                        sbTopMenuBar.Append("<ul class='dropdown-menu' role='menu'>");
                        var qMasterMenu = (from t in qPrivilege where t.fd_menu_id == 21 select t).OrderBy(o => o.fd_OrderNo);
                        int MenuItemCount = qMasterMenu.Count();
                        foreach (var qMenuItem in qMasterMenu)
                            if (qMenuItem.fd_OrderNo > 0)
                                sbTopMenuBar.Append("<li><a href='" + qMenuItem.fd_filename + "'>" + qMenuItem.fd_modulename + "</a></li>");

                        sbTopMenuBar.Append("</ul>");
                    }
                }
                sbTopMenuBar.Append("</ul>");
                VijayaTopMenuBar.InnerHtml = sbTopMenuBar.ToString();
            }
        }
        catch (Exception Ex)
        { Log.Write("DrawTopMenuBar | " + Ex.ToString()); }
    }
}
