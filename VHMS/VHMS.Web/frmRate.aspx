<%@ Page Title="Rate Details" Language="C#" MasterPageFile="~/VHMSMasterPage.master" AutoEventWireup="true" CodeFile="frmRate.aspx.cs" Inherits="frmRate" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="VHMSWebHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="VHMSWebContent" runat="Server">
    <style>
        .wide-table {
            width: 90%;
            table-layout: fixed;
            margin-left: auto;
            margin-right: auto;
        }

            .wide-table th, .wide-table td {
                padding: 10px;
                text-align: center;
            }

            .wide-table input[type="text"] {
                width: 90%;
            }
    </style>
    <div class="container-wrapper hidden">
        <section class="content-header" id="secHeader">
            <div id="divTitle">
                <h3>Rate Details
                </h3>
            </div>
            <div class="breadcrumb">
                <button id="btnAddNew" class="btn btn-info">
                    <i class="fa fa-plus-square"></i>&nbsp;&nbsp;Add New</button>
                <button id="btnList" class="btn btn-info">
                    <i class="fa fa-list"></i>&nbsp;&nbsp;List</button>
            </div>
        </section>
        <section class="content">
            <div class="nav-tabs-custom" id="divTab">
                <ul class="nav nav-tabs">
                    <li class="active"><a id="aGeneral" href="#General" data-toggle="tab">General</a></li>
                    <li><a id="aSearchResult" href="#SearchResult" data-toggle="tab">Search Result</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="General">
                        <div class="box box-warning">
                            <div class="box-body">
                                <div class="table-responsive">
                                    <table id="tblRecord" class="table table-striped table-bordered bg-info" width="100%">
                                        <thead>
                                            <tr>
                                                <th>S.No</th>
                                                <th>Rate Name</th>
                                                <th>Agent Name</th>
                                                <th></th>
                                                <th></th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody id="tblRecord_tbody">
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="tab-pane" id="SearchResult">
                        <div class="box box-warning">
                            <div class="box-body">
                                <div class="form-group" id="divSearchaname">
                                    <label>
                                        Search Rate records</label><span class="text-danger">*</span>
                                    <input type="text" class="form-control" id="txtSearchName" placeholder="Please enter Details"
                                        maxlength="150" />
                                </div>
                                <div class="table-responsive">
                                    <table id="tblSearchResult" class="table table-striped table-bordered bg-info" width="100%">
                                        <thead>
                                            <tr>
                                                <th>S.No</th>
                                                <th>Rate Name</th>
                                                <th>Agent Name</th>
                                                <th></th>
                                                <th></th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody id="tblSearchResult_tbody">
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="box box-primary" id="divRate">
                <div class="box-header with-border">
                    <div class="box-title">Rate Details</div>
                </div>
                <div class="box-body">
                    <div class="row">
                        <div class="form-group col-md-2" id="divRateName">
                            <label>
                                Rate Name</label><span class="text-danger">*</span>
                            <input type="text" class="form-control" id="txtRateName" placeholder="Rate Name"
                                maxlength="50" tabindex="1" />
                        </div>
                        <div class="form-group col-md-2" id="divAgent">
                            <label>
                                Agent</label><span class="text-danger">*</span>
                            <select id="ddlAgent" class="form-control select2" data-placeholder="Select Agent" tabindex="2"></select>
                        </div>
                        <div class="form-group col-md-2" id="divFoodAllowance">
                            <label>
                                Food Allowance</label><span class="text-danger">*</span>
                            <input type="text" class="form-control TRSearch" id="txtFoodAllowance" placeholder="Food Allowance"
                                maxlength="12" tabindex="3" onkeypress="return IsNumeric(event)" autocomplete="off" />
                        </div>
                        <div class="form-group col-md-2" id="divPipeDeapthRate">
                            <label>
                                PipeDeapth Rate</label><span class="text-danger">*</span>
                            <input type="text" class="form-control TRSearch" id="txtPipeDeapthRate" placeholder="Pipe Deapth Rate"
                                maxlength="12" tabindex="4" onkeypress="return IsNumeric(event)" autocomplete="off" />
                        </div>
                        <div class="form-group col-md-2" id="divTransportRate">
                            <label>
                                Transport Rate</label><span class="text-danger">*</span>
                            <input type="text" class="form-control TRSearch" id="txtTransportRate" placeholder="Transport Rate"
                                maxlength="12" tabindex="5" onkeypress="return IsNumeric(event)" autocomplete="off" />
                        </div>
                        <div class="form-group col-md-2" id="divWeldingRate">
                            <label>
                                Welding Rate</label><span class="text-danger">*</span>
                            <input type="text" class="form-control TRSearch" id="txtWeldingRate" placeholder="Welding Rate"
                                maxlength="12" tabindex="6" onkeypress="return IsNumeric(event)" autocomplete="off" />
                        </div>
                    </div>
                    <div class="row">
                        <table class="wide-table" border="1" cellpadding="5" cellspacing="0" style="margin: 0 auto;">
                            <thead>
                                <tr>
                                    <th>
                                        <div class="col-md-12 text-center">Range</div>
                                    </th>
                                    <th>
                                        <div class="col-md-12 text-center">Rate</div>
                                    </th>
                                    <th>
                                        <div class="col-md-12 text-center">Depth</div>
                                    </th>
                                    <th>
                                        <div class="col-md-12 text-center">Amount</div>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td style="font-weight: bold;">0 - 300</td>
                                    <td>
                                        <input type="text" id="txtThreehundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">300</td>
                                    <td>
                                        <input type="text" id="txtThreehundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">400 - 500</td>
                                    <td>
                                        <input type="text" id="txtFourhundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtFourhundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">500 - 600</td>
                                    <td>
                                        <input type="text" id="txtFivehundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtFivehundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">600 - 700</td>
                                    <td>
                                        <input type="text" id="txtSixhundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtSixhundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">700 - 800</td>
                                    <td>
                                        <input type="text" id="txtSevenhundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtSevenhundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">800 - 900</td>
                                    <td>
                                        <input type="text" id="txtEighthundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtEighthundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">900 - 1000</td>
                                    <td>
                                        <input type="text" id="txtNinehundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtNinehundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1000 - 1100</td>
                                    <td>
                                        <input type="text" id="txtOnethousandAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOnethousand"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1100 - 1200</td>
                                    <td>
                                        <input type="text" id="txtOneThousandOneHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandOneHundred" onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1200 - 1300</td>
                                    <td>
                                        <input type="text" id="txtOneThousandTwoHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"/></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandTwoHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1300 - 1400</td>
                                    <td>
                                        <input type="text" id="txtOneThousandThreeHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandThreeHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1400 - 1500</td>
                                    <td>
                                        <input type="text" id="txtOneThousandFourHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandFourHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1500 - 1600</td>
                                    <td>
                                        <input type="text" id="txtOneThousandFiveHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandFiveHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1600 - 1700</td>
                                    <td>
                                        <input type="text" id="txtOneThousandSixHundredAmount"   onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandSixHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1700 - 1800</td>
                                    <td>
                                        <input type="text" id="txtOneThousandSevenHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandSevenHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1800 - 1900</td>
                                    <td>
                                        <input type="text" id="txtOneThousandEightHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandEightHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">1900 - 2000</td>
                                    <td>
                                        <input type="text" id="txtOneThousandNineHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"  /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtOneThousandNineHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2000 - 2100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandAmount" onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                   <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousand"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2100 - 2200</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandOneHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"/></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandOneHundred" onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2200 - 2300</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandTwoHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandTwoHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2300 - 2400</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandThreeHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandThreeHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2400 - 2500</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandFourHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"/></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandFourHundred"  onkeypress="return IsNumeric(event)" style="text-align:center"readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2500 - 2600</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandFiveHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"/></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandFiveHundred"  onkeypress="return IsNumeric(event)" style="text-align:center"readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2600 - 2700</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandSixHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandSixHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2700 - 2800</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandSevenHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandSevenHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2800 - 2900</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandEightHundredAmount" onkeypress="return IsNumeric(event)"  style="text-align:center" /></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandEightHundred"  onkeypress="return IsNumeric(event)"style="text-align:center" readonly /></td>
                                </tr>
                                <tr>
                                    <td style="font-weight: bold;">2900 - 3000</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandNineHundredAmount"  onkeypress="return IsNumeric(event)" style="text-align:center"/></td>
                                    <td style="font-weight: bold;">100</td>
                                    <td>
                                        <input type="text" id="txtTwoThousandNineHundred"  onkeypress="return IsNumeric(event)" style="text-align:center" readonly /></td>
                                </tr>
                            </tbody>
                        </table>

                    </div>
                </div>
                <div class="row">
                    <div class="modal-footer clearfix">
                        <button id="btnSave" type="button" class="btn btn-info margin pull-right" tabindex="27">
                            <i class="fa fa-save"></i>&nbsp;&nbsp;Save</button>
                        <button id="btnUpdate" type="button" class="btn btn-info margin pull-right" tabindex="28">
                            <i class="fa fa-save"></i>&nbsp;&nbsp;Update</button>
                        <button type="button" class="btn btn-danger margin pull-left" id="btnClose" tabindex="29">
                            <i class="fa fa-close"></i>&nbsp;&nbsp;Close</button>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <input type="hidden" id="hdnRateID" />
    <script src="UserDefined_Js/jRate.js?v=<%= BaseConfig.GetFileHash("UserDefined_Js/jRate.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        var _CMActionAdd = '<%=Session["ActionAdd"]%>';
        var _CMActionUpdate = '<%=Session["ActionUpdate"]%>';
        var _CMActionDelete = '<%=Session["ActionDelete"]%>';
        var _CMActionView = '<%=Session["ActionView"]%>';
        var pageUrl = '<%=ResolveUrl("~/frmRate.aspx") %>';
        $(document).ready(function () {
            $('input,select').keydown(function (event) {
                if (event.which == 13) {
                    var inputs = $(this).closest('form').find(':input:visible');
                    inputs.eq(inputs.index(this) + 1).focus();
                    event.preventDefault();

                }
            });
        });
    </script>
</asp:Content>

