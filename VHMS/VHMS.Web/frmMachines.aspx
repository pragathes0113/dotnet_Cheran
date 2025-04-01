<%@ Page Title="Machines" Language="C#" MasterPageFile="~/VHMSMasterPage.master" AutoEventWireup="true" CodeFile="frmMachines.aspx.cs" Inherits="frmMachines" %>

<asp:Content ID="Content3" ContentPlaceHolderID="VHMSWebHead" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="VHMSWebContent" runat="Server">
    <div class="container-wrapper hidden">
        <section class="content-header">
            <h1>Machines
            </h1>
            <ol class="breadcrumb">
                <li><a href="frmDefault.aspx"><i class="fa fa-home"></i>Home</a></li>
                <li class="active">Machines</li>
            </ol>
            <div class="pull-right">
                <button id="btnAddNew" class="btn btn-primary">
                    <i class="fa fa-plus-square"></i>&nbsp;&nbsp;Add New</button>
                <button id="btnList" class="btn btn-primary">
                    <i class="fa fa-list"></i>&nbsp;&nbsp;List</button>
            </div>
            <br />
            <br />
        </section>
        <section class="content">
            <div class="row" id="divRecords">
                <div class="col-xs-12">
                    <div class="box box-warning">
                        <div class="box-body">
                            <div class="table-responsive">
                                <table id="tblRecord" class="table table-striped table-bordered table-hover bg-info" width="100%">
                                    <thead>
                                        <tr>
                                            <th>SNo
                                            </th>
                                            <th>Machines Name
                                            </th>
                                            <th>TransportNumber
                                            </th>
                                            <th class='hidden-xs'>Owner MobileNo
                                            </th>
                                            <th class='hidden-xs'>Manager MobileNo
                                            </th>
                                            <th class='hidden-xs'>Vehicle ChassisNo
                                            </th>
                                            <th class='hidden-xs'>RC No</th>
                                            <th class='hidden-xs'>RC Date</th>
                                            <th class='hidden-xs'>Insurance No</th>
                                            <th class='hidden-xs'>Insurance Date</th>
                                            <th class='hidden-xs'>FC Date</th>
                                            <th class='hidden-xs'>Tax Date</th>
                                            <th>View</th>
                                            <th>Edit</th>
                                        </tr>
                                    </thead>
                                    <tbody id="tblRecord_tbody">
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="nav-tabs-custom" id="tab-modal">
                <ul class="nav nav-tabs">
                    <li class="active"><a id="aGeneral" href="#General" data-toggle="tab">General</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="General">
                        <div class="row">
                            <div class="form-group col-md-5 col-sm-5" id="divMachinesName">
                                <label>
                                    Machines Name</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtMachinesName" placeholder="Please enter Machines Name"
                                        maxlength="255" tabindex="1" />
                                </div>
                            </div>
                            <div class="form-group col-md-4 col-sm-4" id="divTransportNumber">
                                <label>
                                    Transport Number</label><span class="text-danger">*</span>
                                <input type="text" class="form-control" id="txtTransportNumber" placeholder="Please enter Transport Number"
                                    maxlength="10" tabindex="2" />
                            </div>
                            <div class="form-group col-md-3 col-sm-3" id="divOwnerMobileNo">
                                <label>
                                    Owner MobileNo</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtOwnerMobileNo" placeholder="Please enter Owner MobileNo"
                                        maxlength="255" tabindex="3" />
                                </div>
                            </div>
                            <div class="form-group col-md-3 col-sm-3" id="divManagerMobileNo">
                                <label>
                                    Manager MobileNo</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtManagerMobileNo" placeholder="Please enter Manager MobileNo"
                                        maxlength="255" tabindex="4" />
                                </div>
                            </div>
                            <div class="form-group col-md-3 col-sm-3" id="divVehicleChassisNo">
                                <label>
                                    Vehicle ChassisNo</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtVehicleChassisNo" placeholder="Please enter Vehicle ChassisNo"
                                        maxlength="255" tabindex="5" />
                                </div>
                            </div>
                            <div class="form-group col-md-3 col-sm-3" id="divRCNo">
                                <label>
                                    RC No</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtRCNo" placeholder="Please enter RC No"
                                        maxlength="255" tabindex="6" />
                                </div>
                            </div>
                            <div class="form-group col-md-3" id="divRCDate">
                                <label>
                                    RC Date</label><span class="text-danger">*</span>
                                <div class="input-group date form_date" data-date-format="dd/MM/yyyy HH:ii P" data-link-field="txtOPBillingDate"
                                    data-link-format="dd/MM/yyyy">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar glyphicon glyphicon-calendar"></i>
                                    </div>
                                    <input type="text" class="form-control pull-right" tabindex="7" id="txtRCDate" readonly="true" />
                                </div>
                            </div>
                            <div class="form-group col-md-3 col-sm-3" id="divInsuranceNo">
                                <label>
                                    Insurance No</label><span class="text-danger">*</span>
                                <div class="input-group">
                                    <div class="input-group-addon"><i class="fa fa-user"></i></div>
                                    <input type="text" class="form-control" id="txtInsuranceNo" placeholder="Please enter Insurance No"
                                        maxlength="255" tabindex="8" />
                                </div>
                            </div>
                            <div class="form-group col-md-3" id="divInsuranceDate">
                                <label>
                                    Insurance Date</label><span class="text-danger">*</span>
                                <div class="input-group date form_date" data-date-format="dd/MM/yyyy HH:ii P" data-link-field="txtOPBillingDate"
                                    data-link-format="dd/MM/yyyy">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar glyphicon glyphicon-calendar"></i>
                                    </div>
                                    <input type="text" class="form-control pull-right" tabindex="9" id="txtInsuranceDate" readonly="true" />
                                </div>
                            </div>
                            <div class="form-group col-md-3" id="divFCDate">
                                <label>
                                    FC Date</label><span class="text-danger">*</span>
                                <div class="input-group date form_date" data-date-format="dd/MM/yyyy HH:ii P" data-link-field="txtOPBillingDate"
                                    data-link-format="dd/MM/yyyy">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar glyphicon glyphicon-calendar"></i>
                                    </div>
                                    <input type="text" class="form-control pull-right" tabindex="10" id="txtFCDate" readonly="true" />
                                </div>
                            </div>
                            <div class="form-group col-md-3" id="divTaxDate">
                                <label>
                                    Tax Date</label><span class="text-danger">*</span>
                                <div class="input-group date form_date" data-date-format="dd/MM/yyyy HH:ii P" data-link-field="txtOPBillingDate"
                                    data-link-format="dd/MM/yyyy">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar glyphicon glyphicon-calendar"></i>
                                    </div>
                                    <input type="text" class="form-control pull-right" tabindex="11" id="txtTaxDate" readonly="true" />
                                </div>
                            </div>
                            <div class="form-group col-md-12 col-sm-12" id="divAddress">
                                <label>
                                    Address</label><span class="text-danger">*</span>
                                <textarea id="txtAddress" class="form-control" maxlength="255" tabindex="3" rows="4"></textarea>
                            </div>
                        </div>
                        <div class="modal-footer clearfix">
                            <button id="btnSave" type="button" class="btn btn-info pull-left" tabindex="17">
                                <i class="fa fa-save"></i>&nbsp;&nbsp;
                                Save</button>
                            <button id="btnUpdate" type="button" class="btn btn-info pull-left" tabindex="18">
                                <i class="fa fa-edit"></i>&nbsp;&nbsp;
                                Update</button>
                            <button type="button" class="btn btn-danger pull-right" id="btnClose" tabindex="19">
                                <i class="fa fa-times"></i>&nbsp;&nbsp;
                                Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <input type="hidden" id="hdnMachinesID" />
    <script type="text/javascript">
        $(document).ready(function () {
            ActionAdd = '<%=Session["ActionAdd"]%>';
            ActionUpdate = '<%=Session["ActionUpdate"]%>';
            ActionDelete = '<%=Session["ActionDelete"]%>';
            ActionView = '<%=Session["ActionView"]%>';

            $("#divRecords").show();
            $("#tab-modal").hide();
            $("#btnAddNew").show();
            $("#btnList").hide();

            pLoadingSetup(false);
            $("#txtRCDate,#txtInsuranceDate,#txtFCDate,#txtTaxDate").attr("data-link-format", "dd/MM/yyyy");
            $("#txtRCDate,#txtInsuranceDate,#txtFCDate,#txtTaxDate").datetimepicker({
                pickTime: false,
                useCurrent: true,
                maxDate: moment(),
                format: 'DD/MM/YYYY'
            });
            GetRecord();
            pLoadingSetup(true);
        });

        $("#btnAddNew").click(function () {
            $("#divRecords").hide();
            $("#tab-modal").show();
            $("#btnList").show();
            $("#btnAddNew").hide();
            $("#hdnMachinesID").val("");
            $("#btnSave").show();
            $("#btnUpdate").hide();
            $("#aGeneral").click();
            ClearFields();
            ClickCount = 0;
            return false;
        });
        function ClearMachinesData() {

        }

        $("#btnList,#btnClose").click(function () {
            $("#divRecords").show();
            $("#tab-modal").hide();
            $("#btnList").hide();
            $("#btnAddNew").show();
            $("#aGeneral").click();
            GetRecord();
            return false;
        });

        function GetRecord() {
            dProgress(true);
            $.ajax({
                type: "POST",
                url: "WebServices/VHMSService.svc/GetMachines",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (data) {
                    if (data.d != "") {
                        var objResponse = jQuery.parseJSON(data.d);
                        if (objResponse.Status == "Success") {
                            var notetable = $("#tblRecord").dataTable();
                            notetable.fnDestroy();
                            if (objResponse.Value != null && objResponse.Value != "NoRecord") {
                                var obj = $.parseJSON(objResponse.Value);
                                if (obj.length > 0) {
                                    $("#tblRecord_tbody").empty();
                                    var TypeStatus = "";
                                    for (var index = 0; index < obj.length; index++) {
                                        //if (obj[index].IsActive == "1") { TypeStatus = "<span class='label label-success'>Active</span>"; }
                                        //else { TypeStatus = "<span class='label label-warning'>Inactive</span>"; }

                                        var table = "<tr id='" + obj[index].MachinesID + "'>";
                                        table += "<td>" + (index + 1) + "</td>";
                                        table += "<td>" + obj[index].MachinesName + "</td>";
                                        table += "<td>" + obj[index].TransportNumber + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].OwnerMobileNo + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].ManagerMobileNo + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].VehicleChassisNo + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].RCNo + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].sRCDate + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].InsuranceNo + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].sInsuranceDate + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].sFCDate + "</td>";
                                        table += "<td class='hidden-xs'>" + obj[index].sTaxDate + "</td>";
                                        if (ActionView == "1") { table += "<td style='text-align:center;'><a href='#' id=" + obj[index].MachinesID + " class='view' title='Click here to view'><i class='fa fa-eye text-yellow'/></a></td>"; }
                                        else { table += "<td></td>"; }
                                        if (ActionUpdate == "1") { table += "<td style='text-align:center;'><a href='#' id=" + obj[index].MachinesID + " class='Edit' title='Click here to Edit'><i class='fa fa-lg fa-edit'/></a></td>"; }
                                        else { table += "<td></td>"; }

                                        table += "</tr>";
                                        $("#tblRecord_tbody").append(table);
                                    }
                                    $(".view").click(function () {
                                        if (ActionView == "1") {
                                            GetMachinesInformation($(this).parent().parent()[0].id);
                                            $("#btnSave").hide();
                                            $("#btnUpdate").hide();
                                        }
                                        else {
                                            $.jGrowl(_CMAccessDeined, { sticky: false, theme: 'danger', life: jGrowlLife });
                                            return false;
                                        }
                                    });
                                    $(".Edit").click(function () {
                                        if (ActionUpdate == "1") { GetMachinesInformation($(this).parent().parent()[0].id); }
                                        else {
                                            $.jGrowl("Access Denied", { sticky: false, theme: 'danger', life: jGrowlLife });
                                            return false;
                                        }
                                    });
                                }
                                dProgress(false);
                            }
                            else if (objResponse.Value == "NoRecord") {
                                $("#tblRecord_tbody").empty();
                                dProgress(false);
                            }
                            $("#tblRecord").dataTable({
                                "bPaginate": true,
                                "bFilter": true,
                                "bSort": true,
                                "iDisplayLength": 25,
                                aoColumns: [
                                    { "sWidth": "3%" },
                                    { "sWidth": "20%" },
                                    { "sWidth": "5%" },
                                    { "sWidth": "10%" },
                                    { "sWidth": "10%" },

                                    { "sWidth": "10%" },
                                    { "sWidth": "20%" },
                                    { "sWidth": "8%" },
                                    { "sWidth": "8%" },
                                    { "sWidth": "8%" },

                                    { "sWidth": "8%" },
                                    { "sWidth": "8%" },
                                    { "sWidth": "3%" },
                                    { "sWidth": "3%" }
                                ]
                            });

                            $("#tblRecord_filter").addClass('pull-right');
                            $(".pagination").addClass('pull-right');
                        }
                        else if (objResponse.Status == "Error") {
                            if (objResponse.Value == "0") {
                                window.location("frmLogin.aspx");
                            }
                            else if (objResponse.Value == "Error") {
                                window.location = "frmErrorPage.aspx";
                            }
                        }
                    }
                    else {
                        $("#tblRecord_tbody").empty();
                        dProgress(false);
                    }
                },
                error: function (e) {
                    $.jGrowl("Error  Occured", { sticky: true, theme: 'danger', life: jGrowlLife });
                    dProgress(false);
                }
            });
            return false;
        }

        function ClearFields() {
            $("#txtMachinesName").val("");
            $("#txtTransportNumber").val("");
            $("#txtAddress").val("");
            $("#txtOwnerMobileNo").val("");
            $("#txtManagerMobileNo").val("");
            $("#txtVehicleChassisNo").val("");
            $("#txtRCNo").val("");
            $("#txtRCDate").val("");
            $("#txtInsuranceNo").val("");
            $("#txtInsuranceDate").val("");
            $("#txtFCDate").val("");
            $("#txtTaxDate").val("");
            $("#divMachinesName").removeClass('has-error');
            $("#divTransportNumber").removeClass('has-error');
            return false;
        }

        $("#btnSave,#btnUpdate").click(function () {
            if (this.id == "btnSave") { if (ActionAdd != "1") { $.jGrowl("Access Denied", { sticky: false, theme: 'danger', life: jGrowlLife }); return false; } }
            else { if (ActionUpdate != "1") { $.Growl("Access Denied", { sticky: false, theme: 'danger', life: jGrowlLife }); return false; } }

            if ($("#txtMachinesName").val().trim() == "" || $("#txtMachinesName").val().trim() == undefined) {
                $.jGrowl("Please enter Machines Name", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divMachinesName").addClass('has-error'); $("#txtMachinesName").focus(); return false;
            } else { $("#divMachinesName").removeClass('has-error'); }

            if ($("#txtTransportNumber").val().trim() == "" || $("#txtTransportNumber").val().trim() == undefined) {
                $.jGrowl("Please enter Transport Number", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divTransportNumber").addClass('has-error'); $("#txtTransportNumber").focus(); return false;
            } else { $("#divTransportNumber").removeClass('has-error'); }

            if ($("#txtOwnerMobileNo").val().trim() == "" || $("#txtOwnerMobileNo").val().trim() == undefined) {
                $.jGrowl("Please enter Owner MobileNo", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divOwnerMobileNo").addClass('has-error'); $("#txtOwnerMobileNo").focus(); return false;
            } else { $("#divOwnerMobileNo").removeClass('has-error'); }

            if ($("#txtManagerMobileNo").val().trim() == "" || $("#txtManagerMobileNo").val().trim() == undefined) {
                $.jGrowl("Please enter Manager MobileNo", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divManagerMobileNo").addClass('has-error'); $("#txtManagerMobileNo").focus(); return false;
            } else { $("#divManagerMobileNo").removeClass('has-error'); }

            if ($("#txtVehicleChassisNo").val().trim() == "" || $("#txtVehicleChassisNo").val().trim() == undefined) {
                $.jGrowl("Please enter Manager MobileNo", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divVehicleChassisNo").addClass('has-error'); $("#txtVehicleChassisNo").focus(); return false;
            } else { $("#divVehicleChassisNo").removeClass('has-error'); }

            if ($("#txtRCNo").val().trim() == "" || $("#txtRCNo").val().trim() == undefined) {
                $.jGrowl("Please enter RC No", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divRCNo").addClass('has-error'); $("#txtRCNo").focus(); return false;
            } else { $("#divRCNo").removeClass('has-error'); }


            if ($("#txtRCDate").val().trim() == "" || $("#txtRCDate").val().trim() == undefined) {
                $.jGrowl("Please select RC Date", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divRCDate").addClass('has-error'); $("#txtRCDate").focus(); return false;
            }
            else { $("#divRCDate").removeClass('has-error'); }

            if ($("#txtInsuranceDate").val().trim() == "" || $("#txtInsuranceDate").val().trim() == undefined) {
                $.jGrowl("Please select Insurance Date", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divInsuranceDate").addClass('has-error'); $("#txtInsuranceDate").focus(); return false;
            }
            else { $("#divInsuranceDate").removeClass('has-error'); }

            if ($("#txtFCDate").val().trim() == "" || $("#txtFCDate").val().trim() == undefined) {
                $.jGrowl("Please select FC Date", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divFCDate").addClass('has-error'); $("#txtFCDate").focus(); return false;
            }
            else { $("#divFCDate").removeClass('has-error'); }

            if ($("#txtTaxDate").val().trim() == "" || $("#txtTaxDate").val().trim() == undefined) {
                $.jGrowl("Please select Tax Date", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divTaxDate").addClass('has-error'); $("#txtTaxDate").focus(); return false;
            }
            else { $("#divTaxDate").removeClass('has-error'); }

            if ($("#txtAddress").val().trim() == "" || $("#txtAddress").val().trim() == undefined) {
                $.jGrowl("Please enter Address", { sticky: false, theme: 'warning', life: jGrowlLife });
                $("#divAddress").addClass('has-error'); $("#txtAddress").focus(); return false;
            } else { $("#divAddress").removeClass('has-error'); }

            SaveandUpdateMachinesInformation();

            return false;
        });



        function SaveandUpdateMachinesInformation() {
            var Obj = new Object();
            Obj.MachinesID = 0;
            Obj.MachinesName = $("#txtMachinesName").val().trim();
            Obj.TransportNumber = $("#txtTransportNumber").val().trim();
            Obj.OwnerMobileNo = $("#txtOwnerMobileNo").val().trim();
            Obj.ManagerMobileNo = $("#txtManagerMobileNo").val().trim();
            Obj.VehicleChassisNo = $("#txtVehicleChassisNo").val().trim();
            Obj.RCNo = $("#txtRCNo").val().trim();
            Obj.sRCDate = $("#txtRCDate").val().trim();
            Obj.InsuranceNo = $("#txtInsuranceNo").val().trim();
            Obj.sInsuranceDate = $("#txtInsuranceDate").val().trim();
            Obj.sFCDate = $("#txtFCDate").val().trim();
            Obj.sTaxDate = $("#txtTaxDate").val().trim();
            Obj.Address = $("#txtAddress").val();
            if ($("#hdnMachinesID").val() > 0) {
                Obj.MachinesID = $("#hdnMachinesID").val();
                sMethodName = "UpdateMachines";
            }
            else { sMethodName = "AddMachines"; }

            $.ajax({
                type: "POST",
                url: "WebServices/VHMSService.svc/" + sMethodName,
                data: JSON.stringify({ Objdata: Obj }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (data) {
                    if (data.d != "") {
                        var objResponse = jQuery.parseJSON(data.d);
                        if (objResponse.Status == "Success") {
                            if (objResponse.Value > 0) {
                                ClearFields();
                                if (sMethodName == "AddMachines") {
                                    $.jGrowl("Saved Successfully", { sticky: false, theme: 'success', life: jGrowlLife });
                                    $("#hdnMachinesID").val(objResponse.Value);
                                }
                                else if (sMethodName == "UpdateMachines") { $.jGrowl("Updated Successfully", { sticky: false, theme: 'success', life: jGrowlLife }); }

                                GetMachinesInformation();
                            }
                        }
                        else if (objResponse.Status == "Error") {
                            if (objResponse.Value == "0") {
                                window.location = "frmLogin.aspx";
                            }
                            else if (objResponse.Value == "Machines_A_01") {
                                $.jGrowl("Name Already Exists", { sticky: false, theme: 'danger', life: jGrowlLife });
                            }
                            else if (objResponse.Value == "Error") {
                                window.location = "frmErrorPage.aspx";
                            }
                        }
                    }
                    else {
                        $.jGrowl("Error  Occured", { sticky: true, theme: 'danger', life: jGrowlLife });
                    }
                },
                error: function (e) {
                    $.jGrowl("Error  Occured", { sticky: true, theme: 'danger', life: jGrowlLife });
                }
            });
            return false;
        }

        function GetMachinesInformation(id) {
            dProgress(true);
            $.ajax({
                type: "POST",
                url: "WebServices/VHMSService.svc/GetMachinesByID",
                data: JSON.stringify({ ID: id }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: false,
                success: function (data) {
                    if (data.d != "") {
                        var objResponse = jQuery.parseJSON(data.d);
                        if (objResponse.Status == "Success") {
                            if (objResponse.Value != null && objResponse.Value != "NoRecord" && objResponse.Value != "Error") {
                                var obj = jQuery.parseJSON(objResponse.Value);
                                if (obj != null) {
                                    ClearFields();
                                    $("#btnAddNew").hide();
                                    $("#btnList").show();
                                    $("#btnSave").hide();
                                    $("#btnUpdate").show();
                                    $("#tab-modal").show();
                                    $("#aGeneral").click();
                                    $("#divRecords").hide();
                                    $("#hdnMachinesID").val(obj.MachinesID);
                                    $("#txtMachinesName").val(obj.MachinesName);
                                    $("#txtTransportNumber").val(obj.TransportNumber);
                                    $("#txtOwnerMobileNo").val(obj.OwnerMobileNo);
                                    $("#txtManagerMobileNo").val(obj.ManagerMobileNo);
                                    $("#txtVehicleChassisNo").val(obj.VehicleChassisNo);
                                    $("#txtRCNo").val(obj.RCNo);
                                    $("#txtRCDate").val(obj.sRCDate);
                                    $("#txtInsuranceNo").val(obj.InsuranceNo);
                                    $("#txtInsuranceDate").val(obj.sInsuranceDate);
                                    $("#txtFCDate").val(obj.sFCDate);
                                    $("#txtTaxDate").val(obj.sTaxDate);
                                    $("#txtAddress").val(obj.Address);
                                    dProgress(false);
                                }
                            }
                            else if (objResponse.Value == "NoRecord") {
                                $.jGrowl("No Record", { sticky: false, theme: 'warning', life: jGrowlLife });
                                dProgress(false);
                            }
                            else if (objResponse.Value == "Error") {
                                $.jGrowl("Error", { sticky: false, theme: 'warning', life: jGrowlLife });
                            }
                        }
                        else if (objResponse.Status == "Error") {
                            if (objResponse.Value == "0") {
                                window.location("frmLogin.aspx");
                            }
                            else if (objResponse.Value == "Error") {
                                window.location = "frmErrorPage.aspx";
                            }
                            else if (objResponse.Value == "NoRecord") {
                                $.jGrowl("No Record", { sticky: false, theme: 'warning', life: jGrowlLife });
                            }
                        }
                    }
                    else {
                        $.jGrowl("Error  Occured", { sticky: true, theme: 'danger', life: jGrowlLife });
                        dProgress(false);
                    }
                },
                error: function () {
                    $.jGrowl("Error  Occured", { sticky: true, theme: 'danger', life: jGrowlLife });
                }
            });
            return false;
        }
    </script>
</asp:Content>




