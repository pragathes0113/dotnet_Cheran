
$(function () {
    pLoadingSetup(false);
    ActionAdd = _CMActionAdd;
    ActionUpdate = _CMActionUpdate;
    ActionDelete = _CMActionDelete;
    ActionView = _CMActionView;
    $("#btnAddNew").show();
    $("#btnList").hide();
    $("#divID").hide();
    $("#btnAddMagazine").show();
    $("#btnUpdateMagazine").hide();
    $("#SearchResult").hide();
    $("#divTab").show();
    $("#divRate").hide();
    GetAgent("ddlAgent");
    GetRecord();
    pLoadingSetup(true);
});
$("#btnAddNew").click(function () {
    $("#secHeader").addClass('hidden');
    ClearRateTab();
    $("#btnAddNew").hide();
    $("#btnList").show();
    $("#hdnRateID").val("0");
    $("#divTab").hide();
    $("#divRate").show();
    $("#btnSave").show();
    $("#btnUpdate").hide();
    return false;
});

// Rate calculateAmount
function IsNumeric(e) {
    var key = e.which ? e.which : e.keyCode;
    if (key > 31 && (key < 48 || key > 57)) return false;
    return true;
}
function calculateAmount(rateInputId, depth, amountInputId) {
    var rate = parseFloat(document.getElementById(rateInputId).value) || 0;
    var total = rate * depth;
    document.getElementById(amountInputId).value = total;
}

document.addEventListener('DOMContentLoaded', function () {
    const rows = [
        { rateId: "txtThreehundredAmount", depth: 300, amountId: "txtThreehundred" },
        { rateId: "txtFourhundredAmount", depth: 100, amountId: "txtFourhundred" },
        { rateId: "txtFivehundredAmount", depth: 100, amountId: "txtFivehundred" },
        { rateId: "txtSixhundredAmount", depth: 100, amountId: "txtSixhundred" },
        { rateId: "txtSevenhundredAmount", depth: 100, amountId: "txtSevenhundred" },
        { rateId: "txtEighthundredAmount", depth: 100, amountId: "txtEighthundred" },
        { rateId: "txtNinehundredAmount", depth: 100, amountId: "txtNinehundred" },
        { rateId: "txtOnethousandAmount", depth: 100, amountId: "txtOnethousand" },
        { rateId: "txtOneThousandOneHundredAmount", depth: 100, amountId: "txtOneThousandOneHundred" },
        { rateId: "txtOneThousandTwoHundredAmount", depth: 100, amountId: "txtOneThousandTwoHundred" },
        { rateId: "txtOneThousandThreeHundredAmount", depth: 100, amountId: "txtOneThousandThreeHundred" },
        { rateId: "txtOneThousandFourHundredAmount", depth: 100, amountId: "txtOneThousandFourHundred" },
        { rateId: "txtOneThousandFiveHundredAmount", depth: 100, amountId: "txtOneThousandFiveHundred" },
        { rateId: "txtOneThousandSixHundredAmount", depth: 100, amountId: "txtOneThousandSixHundred" },
        { rateId: "txtOneThousandSevenHundredAmount", depth: 100, amountId: "txtOneThousandSevenHundred" },
        { rateId: "txtOneThousandEightHundredAmount", depth: 100, amountId: "txtOneThousandEightHundred" },
        { rateId: "txtOneThousandNineHundredAmount", depth: 100, amountId: "txtOneThousandNineHundred" },
        { rateId: "txtTwoThousandAmount", depth: 100, amountId: "txtTwoThousand" },
        { rateId: "txtTwoThousandOneHundredAmount", depth: 100, amountId: "txtTwoThousandOneHundred" },

        { rateId: "txtTwoThousandTwoHundredAmount", depth: 100, amountId: "txtTwoThousandTwoHundred" },
        { rateId: "txtTwoThousandThreeHundredAmount", depth: 100, amountId: "txtTwoThousandThreeHundred" },
        { rateId: "txtTwoThousandFourHundredAmount", depth: 100, amountId: "txtTwoThousandFourHundred" },
        { rateId: "txtTwoThousandFiveHundredAmount", depth: 100, amountId: "txtTwoThousandFiveHundred" },
        { rateId: "txtTwoThousandSixHundredAmount", depth: 100, amountId: "txtTwoThousandSixHundred" },
        { rateId: "txtTwoThousandSevenHundredAmount", depth: 100, amountId: "txtTwoThousandSevenHundred" },
        { rateId: "txtTwoThousandEightHundredAmount", depth: 100, amountId: "txtTwoThousandEightHundred" },
        { rateId: "txtTwoThousandNineHundredAmount", depth: 100, amountId: "txtTwoThousandNineHundred" },
    ];

    rows.forEach(row => {
        const input = document.getElementById(row.rateId);
        if (input) {
            input.addEventListener("input", function () {
                calculateAmount(row.rateId, row.depth, row.amountId);
            });
        }
    });
});

function GetAgent(ddlname) {
    var sControlName = "#" + ddlname;
    dProgress(true);
    $(sControlName).empty();
    $.ajax({
        type: "POST",
        url: "WebServices/VHMSService.svc/GetAgent",
        data: JSON.stringify({ AgentID: 0 }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            if (data.d != "") {
                var objResponse = jQuery.parseJSON(data.d);
                if (objResponse.Status == "Success") {
                    if (objResponse.Value != null && objResponse.Value != "NoRecord") {
                        var obj = $.parseJSON(objResponse.Value);
                        if (obj.length > 0) {
                            $(sControlName).append('<option value="' + '0' + '">' + '--All--' + '</option>');
                            for (var index = 0; index < obj.length; index++) {
                                $(sControlName).append('<option value=' + obj[index].AgentID + ' >' + obj[index].AgentName + '</option>');
                            }
                        }
                    }
                    else if (objResponse.Value == "NoRecord") {
                        $(sControlName).append('<option value="' + '0' + '">' + '--No Records--' + '</option>');
                    }
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
                $(sControlName).append('<option value="' + '0' + '">' + '--No Records--' + '</option>');
            }
        },
        error: function (e) {
            $.jGrowl("Error  Occured", { sticky: false, theme: 'danger', life: jGrowlLife });
        }
    });
    return false;
}

function ClearRateTab() {
    $("#ddlAgent").val(null).change();
    $("#txtRateName").val("");
    $("#txtFoodAllowance").val("0");
    $("#txtPipeDeapthRate").val("0");
    $("#txtTransportRate").val("0");
    $("#txtWeldingRate").val("0");
    $("#txtThreehundred").val("0");
    $("#txtThreehundredAmount").val("0");
    $("#txtFourhundred").val("0");
    $("#txtFourhundredAmount").val("0");
    $("#txtFivehundred").val("0");
    $("#txtFivehundredAmount").val("0");
    $("#txtSixhundred").val("0");
    $("#txtSixhundredAmount").val("0");
    $("#txtSevenhundred").val("0");
    $("#txtSevenhundredAmount").val("0");
    $("#txtEighthundred").val("0");
    $("#txtEighthundredAmount").val("0");
    $("#txtNinehundred").val("0");
    $("#txtNinehundredAmount").val("0");
    $("#txtOnethousand").val("0");
    $("#txtOnethousandAmount").val("0");
    $("#txtOneThousandOneHundred").val("0");
    $("#txtOneThousandOneHundredAmount").val("0");
    $("#txtOneThousandTwoHundred").val("0");
    $("#txtOneThousandTwoHundredAmount").val("0");
    $("#txtOneThousandThreeHundred").val("0");
    $("#txtOneThousandThreeHundredAmount").val("0");
    $("#txtOneThousandFourHundred").val("0");
    $("#txtOneThousandFourHundredAmount").val("0");
    $("#txtOneThousandFiveHundred").val("0");
    $("#txtOneThousandFiveHundredAmount").val("0");
    $("#txtOneThousandSixHundred").val("0");
    $("#txtOneThousandSixHundredAmount").val("0");
    $("#txtOneThousandSevenHundred").val("0");
    $("#txtOneThousandSevenHundredAmount").val("0");
    $("#txtOneThousandEightHundred").val("0");
    $("#txtOneThousandEightHundredAmount").val("0");
    $("#txtOneThousandNineHundred").val("0");
    $("#txtOneThousandNineHundredAmount").val("0");
    $("#txtTwoThousand").val("0");
    $("#txtTwoThousandAmount").val("0");
    $("#txtTwoThousandOneHundred").val("0");
    $("#txtTwoThousandOneHundredAmount").val("0");
    $("#txtTwoThousandTwoHundred").val("0");
    $("#txtTwoThousandTwoHundredAmount").val("0");
    $("#txtTwoThousandThreeHundred").val("0");
    $("#txtTwoThousandThreeHundredAmount").val("0");
    $("#txtTwoThousandFourHundred").val("0");
    $("#txtTwoThousandFourHundredAmount").val("0");
    $("#txtTwoThousandFiveHundred").val("0");
    $("#txtTwoThousandFiveHundredAmount").val("0");
    $("#txtTwoThousandSixHundred").val("0");
    $("#txtTwoThousandSixHundredAmount").val("0");
    $("#txtTwoThousandSevenHundred").val("0");
    $("#txtTwoThousandSevenHundredAmount").val("0");
    $("#txtTwoThousandEightHundred").val("0");
    $("#txtTwoThousandEightHundredAmount").val("0");
    $("#txtTwoThousandNineHundred").val("0");
    $("#txtTwoThousandNineHundredAmount").val("0");
}


$("#btnSave,#btnUpdate").click(function () {

    var ObjRate- = new Object();
    ObjRate.RateID = 0;
    var ObjAgent = new Object();
    ObjAgent.AgentID = $("#ddlAgent").val();
    ObjRate.Agent = ObjAgent;
    ObjRate.RateName = $("#txtRateName").val();
    ObjRate.FoodAllowance = $("#txtFoodAllowance").val();
    ObjRate.PipeDeapthRate = $("#txtPipeDeapthRate").val();
    ObjRate.TransportRate = $("#txtTransportRate").val();
    ObjRate.WeldingRate = $("#txtWeldingRate").val();
    ObjRate.Threehundred = $("#txtThreehundred").val();
    ObjRate.ThreehundredAmount = $("#txtThreehundredAmount").val();
    ObjRate.Fourhundred = $("#txtFourhundred").val();
    ObjRate.FourhundredAmount = $("#txtFourhundredAmount").val();
    ObjRate.Fivehundred = $("#txtFivehundred").val();
    ObjRate.FivehundredAmount = $("#txtFivehundredAmount").val();
    ObjRate.Sixhundred = $("#txtSixhundred").val();
    ObjRate.SixhundredAmount = $("#txtSixhundredAmount").val();
    ObjRate.Sevenhundred = $("#txtSevenhundred").val();
    ObjRate.SevenhundredAmount = $("#txtSevenhundredAmount").val();
    ObjRate.Eighthundred = $("#txtEighthundred").val();
    ObjRate.EighthundredAmount = $("#txtEighthundredAmount").val();
    ObjRate.Ninehundred = $("#txtNinehundred").val();
    ObjRate.NinehundredAmount = $("#txtNinehundredAmount").val();
    ObjRate.Onethousand = $("#txtOnethousand").val();
    ObjRate.OnethousandAmount = $("#txtOnethousandAmount").val();
    ObjRate.OneThousandOneHundred = $("#txtOneThousandOneHundred").val();
    ObjRate.OneThousandOneHundredAmount = $("#txtOneThousandOneHundredAmount").val();
    ObjRate.OneThousandTwoHundred = $("#txtOneThousandTwoHundred").val();
    ObjRate.OneThousandTwoHundredAmount = $("#txtOneThousandTwoHundredAmount").val();
    ObjRate.OneThousandThreeHundred = $("#txtOneThousandThreeHundred").val();
    ObjRate.OneThousandThreeHundredAmount = $("#txtOneThousandThreeHundredAmount").val();
    ObjRate.OneThousandFourHundred = $("#txtOneThousandFourHundred").val();
    ObjRate.OneThousandFourHundredAmount = $("#txtOneThousandFourHundredAmount").val();
    ObjRate.OneThousandFiveHundred = $("#txtOneThousandFiveHundred").val();
    ObjRate.OneThousandFiveHundredAmount = $("#txtOneThousandFiveHundredAmount").val();
    ObjRate.OneThousandSixHundred = $("#txtOneThousandSixHundred").val();
    ObjRate.OneThousandSixHundredAmount = $("#txtOneThousandSixHundredAmount").val();
    ObjRate.OneThousandSevenHundred = $("#txtOneThousandSevenHundred").val();
    ObjRate.OneThousandSevenHundredAmount = $("#txtOneThousandSevenHundredAmount").val();
    ObjRate.OneThousandEightHundred = $("#txtOneThousandEightHundred").val();
    ObjRate.OneThousandEightHundredAmount = $("#txtOneThousandEightHundredAmount").val();
    ObjRate.OneThousandNineHundred = $("#txtOneThousandNineHundred").val();
    ObjRate.OneThousandNineHundredAmount = $("#txtOneThousandNineHundredAmount").val();
    ObjRate.TwoThousand = $("#txtTwoThousand").val();
    ObjRate.TwoThousandAmount = $("#txtTwoThousandAmount").val();
    ObjRate.TwoThousandOneHundred = $("#txtTwoThousandOneHundred").val();
    ObjRate.TwoThousandOneHundredAmount = $("#txtTwoThousandOneHundredAmount").val();
    ObjRate.TwoThousandTwoHundred = $("#txtTwoThousandTwoHundred").val();
    ObjRate.TwoThousandTwoHundredAmount = $("#txtTwoThousandTwoHundredAmount").val();
    ObjRate.TwoThousandThreeHundred = $("#txtTwoThousandThreeHundred").val();
    ObjRate.TwoThousandThreeHundredAmount = $("#txtTwoThousandThreeHundredAmount").val();
    ObjRate.TwoThousandFourHundred = $("#txtTwoThousandFourHundred").val();
    ObjRate.TwoThousandFourHundredAmount = $("#txtTwoThousandFourHundredAmount").val();
    ObjRate.TwoThousandFiveHundred = $("#txtTwoThousandFiveHundred").val();
    ObjRate.TwoThousandFiveHundredAmount = $("#txtTwoThousandFiveHundredAmount").val();
    ObjRate.TwoThousandSixHundred = $("#txtTwoThousandSixHundred").val();
    ObjRate.TwoThousandSixHundredAmount = $("#txtTwoThousandSixHundredAmount").val();
    ObjRate.TwoThousandSevenHundred = $("#txtTwoThousandSevenHundred").val();
    ObjRate.TwoThousandSevenHundredAmount = $("#txtTwoThousandSevenHundredAmount").val();
    ObjRate.TwoThousandEightHundred = $("#txtTwoThousandEightHundred").val();
    ObjRate.TwoThousandEightHundredAmount = $("#txtTwoThousandEightHundredAmount").val();
    ObjRate.TwoThousandNineHundred = $("#txtTwoThousandNineHundred").val();
    ObjRate.TwoThousandNineHundredAmount = $("#txtTwoThousandNineHundredAmount").val();
    if ($("#hdnRateID").val() > 0) {
        ObjRate.RateID = $("#hdnRateID").val();
        sMethodName = "UpdateRate";
    }
    else {
        sMethodName = "AddRate";
        ObjRate.RateID = 0;
    }
    SaveandUpdateRate(ObjRate, sMethodName);
});

function SaveandUpdateRate(ObjRate, sMethodName) {
    $.ajax({
        type: "POST",
        url: "WebServices/VHMSService.svc/" + sMethodName,
        data: JSON.stringify({ Objdata: ObjRate }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            if (data.d != "") {
                var objResponse = jQuery.parseJSON(data.d);
                if (objResponse.Status == "Success") {
                    if (objResponse.Value > 0) {
                        ClearRateTab();
                        GetRecord();
                        $("#btnAddNew").show();
                        $("#divTab").show();
                        $("#secHeader").addClass('hidden');
                        $("#divRate").hide();
                        if (sMethodName == "AddRate") {
                            $.jGrowl("Added Successfully", { sticky: false, theme: 'success', life: jGrowlLife });
                            $("#hdnRateID").val(objResponse.Value);
                            EditRecord($("#hdnRateID").val());
                            $("#btnSave").hide();
                            $("#btnUpdate").hide();
                        }
                        else if (sMethodName == "UpdateRate") {
                            $.jGrowl("Updated Successfully", { sticky: false, theme: 'success', life: jGrowlLife });
                            EditRecord(ObjRate.RateID);
                            $("#btnSave").hide();
                            $("#btnUpdate").hide();
                        }
                    }
                }
                else if (objResponse.Status == "Error") {
                    if (objResponse.Value == "0") {
                        window.location = "frmLogin.aspx";
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

function EditRecord(id) {
    dProgress(true);
    $.ajax({
        type: "POST",
        url: "WebServices/VHMSService.svc/GetRateByID",
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
                            $("#btnAddNew").click();
                            $("#btnSave").hide();
                            $("#btnUpdate").show();
                            $("#hdnRateID").val(obj.RateID);
                            $("#ddlAgent").val(obj.Agent.AgentID).change();
                            $("#txtRateName").val(obj.RateName);
                            $("#txtFoodAllowance").val(obj.FoodAllowance);
                            $("#txtPipeDeapthRate").val(obj.PipeDeapthRate);
                            $("#txtTransportRate").val(obj.TransportRate);
                            $("#txtWeldingRate").val(obj.WeldingRate);
                            $("#txtThreehundred").val(obj.Threehundred);
                            $("#txtThreehundredAmount").val(obj.ThreehundredAmount);
                            $("#txtFourhundred").val(obj.Fourhundred);
                            $("#txtFourhundredAmount").val(obj.FourhundredAmount);
                            $("#txtFivehundred").val(obj.Fivehundred);
                            $("#txtFivehundredAmount").val(obj.FivehundredAmount);
                            $("#txtSixhundred").val(obj.Sixhundred);
                            $("#txtSixhundredAmount").val(obj.SixhundredAmount);
                            $("#txtSevenhundred").val(obj.Sevenhundred);
                            $("#txtSevenhundredAmount").val(obj.SevenhundredAmount);
                            $("#txtEighthundred").val(obj.Eighthundred);
                            $("#txtEighthundredAmount").val(obj.EighthundredAmount);
                            $("#txtNinehundred").val(obj.Ninehundred);
                            $("#txtNinehundredAmount").val(obj.NinehundredAmount);
                            $("#txtOnethousand").val(obj.Onethousand);
                            $("#txtOnethousandAmount").val(obj.OnethousandAmount);
                            $("#txtOneThousandOneHundred").val(obj.OneThousandOneHundred);
                            $("#txtOneThousandOneHundredAmount").val(obj.OneThousandOneHundredAmount);
                            $("#txtOneThousandTwoHundred").val(obj.OneThousandTwoHundred);
                            $("#txtOneThousandTwoHundredAmount").val(obj.OneThousandTwoHundredAmount);
                            $("#txtOneThousandThreeHundred").val(obj.OneThousandThreeHundred);
                            $("#txtOneThousandThreeHundredAmount").val(obj.OneThousandThreeHundredAmount);
                            $("#txtOneThousandFourHundred").val(obj.OneThousandFourHundred);
                            $("#txtOneThousandFourHundredAmount").val(obj.OneThousandFourHundredAmount);
                            $("#txtOneThousandFiveHundred").val(obj.OneThousandFiveHundred);
                            $("#txtOneThousandFiveHundredAmount").val(obj.OneThousandFiveHundredAmount);
                            $("#txtOneThousandSixHundred").val(obj.OneThousandSixHundred);
                            $("#txtOneThousandSixHundredAmount").val(obj.OneThousandSixHundredAmount);
                            $("#txtOneThousandSevenHundred").val(obj.OneThousandSevenHundred);
                            $("#txtOneThousandSevenHundredAmount").val(obj.OneThousandSevenHundredAmount);
                            $("#txtOneThousandEightHundred").val(obj.OneThousandEightHundred);
                            $("#txtOneThousandEightHundredAmount").val(obj.OneThousandEightHundredAmount);
                            $("#txtOneThousandNineHundred").val(obj.OneThousandNineHundred);
                            $("#txtOneThousandNineHundredAmount").val(obj.OneThousandNineHundredAmount);
                            $("#txtTwoThousand").val(obj.TwoThousand);
                            $("#txtTwoThousandAmount").val(obj.TwoThousandAmount);
                            $("#txtTwoThousandOneHundred").val(obj.TwoThousandOneHundred);
                            $("#txtTwoThousandOneHundredAmount").val(obj.TwoThousandOneHundredAmount);
                            $("#txtTwoThousandTwoHundred").val(obj.TwoThousandTwoHundred);
                            $("#txtTwoThousandTwoHundredAmount").val(obj.TwoThousandTwoHundredAmount);
                            $("#txtTwoThousandThreeHundred").val(obj.TwoThousandThreeHundred);
                            $("#txtTwoThousandThreeHundredAmount").val(obj.TwoThousandThreeHundredAmount);
                            $("#txtTwoThousandFourHundred").val(obj.TwoThousandFourHundred);
                            $("#txtTwoThousandFourHundredAmount").val(obj.TwoThousandFourHundredAmount);
                            $("#txtTwoThousandFiveHundred").val(obj.TwoThousandFiveHundred);
                            $("#txtTwoThousandFiveHundredAmount").val(obj.TwoThousandFiveHundredAmount);
                            $("#txtTwoThousandSixHundred").val(obj.TwoThousandSixHundred);
                            $("#txtTwoThousandSixHundredAmount").val(obj.TwoThousandSixHundredAmount);
                            $("#txtTwoThousandSevenHundred").val(obj.TwoThousandSevenHundred);
                            $("#txtTwoThousandSevenHundredAmount").val(obj.TwoThousandSevenHundredAmount);
                            $("#txtTwoThousandEightHundred").val(obj.TwoThousandEightHundred);
                            $("#txtTwoThousandEightHundredAmount").val(obj.TwoThousandEightHundredAmount);
                            $("#txtTwoThousandNineHundred").val(obj.TwoThousandNineHundred);
                            $("#txtTwoThousandNineHundredAmount").val(obj.TwoThousandNineHundredAmount);
                        }
                        dProgress(false);
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
            dProgress(false);
        }
    });
    return false;
}

function GetRecord() {
    dProgress(true);
    $.ajax({
        type: "POST",
        url: "WebServices/VHMSService.svc/GetRate",
        data: JSON.stringify({ PublisherID: 0 }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
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
                            for (var index = 0; index < obj.length; index++) {
                                var table = "<tr id='" + obj[index].RateID + "'>";
                                table += "<td>" + (index + 1) + "</td>";
                                table += "<td>" + obj[index].RateName + "</td>";
                                table += "<td>" + obj[index].Agent.AgentName + "</td>";
                                if (ActionView == "1") { table += "<td style='text-align:center;'><a href='#' id=" + obj[index].RateID + " class='View' title='Click here to View'><i class='fa fa-lg fa-clone text-yellow'/></a></td>"; }
                                else { table += "<td></td>"; }
                                if (ActionUpdate == "1") { table += "<td style='text-align:center;'><a href='#' id=" + obj[index].RateID + " class='Edit' title='Click here to Edit'><i class='fa fa-lg fa-edit'/></a></td>"; }
                                else { table += "<td></td>"; }
                                if (ActionDelete == "1") { table += "<td style='text-align:center;'><a href='#' id=" + obj[index].RateID + " class='Delete' title='Click here to Cancel'><i class='fa fa-lg fa-times-circle text-red'/></a></td>"; }
                                else { table += "<td></td>"; }
                                table += "</tr>";
                                $("#tblRecord_tbody").append(table);

                            }
                            $(".View").click(function () {
                                if (ActionView == "1") {
                                    EditRecord($(this).parent().parent()[0].id);
                                    $("#btnSave").hide();
                                    $("#btnUpdate").hide();
                                }
                                else {
                                    $.jGrowl(_CMAccessDeined, { sticky: false, theme: 'danger', life: jGrowlLife });
                                    return false;
                                }
                            });
                            $(".Edit").click(function () {
                                if (ActionUpdate == "1") {
                                    EditRecord($(this).parent().parent()[0].id);
                                }
                                else {
                                    $.jGrowl(_CMAccessDeined, { sticky: false, theme: 'danger', life: jGrowlLife });
                                    return false;
                                }
                            });

                            $(".Delete").click(function () {
                                if (ActionDelete == "1") {
                                    if (confirm('Are you sure to cancel the selected record ?')) { DeleteRecord($(this).parent().parent()[0].id); }
                                }
                                else {
                                    $.jGrowl(_CMAccessDeined, { sticky: false, theme: 'danger', life: jGrowlLife });
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
                            { "sWidth": "5%" },
                            { "sWidth": "10%" },
                            { "sWidth": "15%" },
                            { "sWidth": "2%" },
                            { "sWidth": "2%" },
                            { "sWidth": "2%" }
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
function DeleteRecord(id, Reason) {

    $.ajax({
        type: "POST",
        url: "WebServices/VHMSService.svc/DeleteAgent",
        data: JSON.stringify({ ID: id }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (data) {
            if (data.d != "") {
                var objResponse = jQuery.parseJSON(data.d);
                if (objResponse.Status == "Success") {
                    if (objResponse.Value > 0) {
                        GetRecord();
                        $.jGrowl("Deleted Successfully", { sticky: false, theme: 'success', life: jGrowlLife });
                    }
                }
                else if (objResponse.Status == "Error") {
                    if (objResponse.Value == "0") {
                        window.location = "frmLogin.aspx";
                    }
                    else if (objResponse.Value == "OPBilling_R_01" || objResponse.Value == "OPBilling_D_01") {
                        $.jGrowl("Since this record is referred somewhere else you cannot delete it", { sticky: false, theme: 'danger', life: jGrowlLife });
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

$("#btnClose").click(function () {
    $("#secHeader").removeClass('hidden');
    $("#hdnRateID").val("0");
    ClearRateTab();
    $("#btnList").click();
    return false;
});