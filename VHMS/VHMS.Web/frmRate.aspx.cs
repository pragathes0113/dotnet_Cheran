using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmRate : BaseConfig
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) VHMSService.AddPageVisitLog();
    }
}