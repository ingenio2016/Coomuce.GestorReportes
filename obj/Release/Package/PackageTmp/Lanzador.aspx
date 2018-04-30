<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lanzador.aspx.cs" Inherits="Coomuce.GestorReportes.Lanzador" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .containerReport {
            border: 1px solid;
            height: 600px;
            width: 100%;
        }

        /*scroll bar for chrome*/
        /*Let's get this party started*/
        ::-webkit-scrollbar {
            height: 16px;
            overflow: visible;
            width: 16px;
        }

        ::-webkit-scrollbar-button {
            height: 0;
            width: 0;
        }

        ::-webkit-scrollbar-corner {
            background: transparent;
        }

        ::-webkit-scrollbar-thumb {
            background-color: rgba(0,0,0,.2);
            background-clip: padding-box;
            border: solid transparent;
            border-width: 1px 1px 1px 6px;
            min-height: 28px;
            padding: 100px 0 0;
            -webkit-box-shadow: inset 1px 1px 0 rgba(0,0,0,.1), inset 0 -1px 0 rgba(0,0,0,.07);
            box-shadow: inset 1px 1px 0 rgba(0,0,0,.1), inset 0 -1px 0 rgba(0,0,0,.07);
        }

        /*Track*/
        ::-webkit-scrollbar-track {
            background-clip: padding-box;
            border: solid transparent;
            border-width: 0 0 0 4px;
        }

        ::-webkit-scrollbar-thumb:hover {
            background-color: rgba(0,0,0,.4);
            -webkit-box-shadow: inset 1px 1px 1px rgba(0,0,0,.25);
            box-shadow: inset 1px 1px 1px rgba(0,0,0,.25);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="containerReport">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
  
        <rsweb:ReportViewer AsyncRendering="false" DocumentMapCollapsed="true" DocumentMapWidth="100%" Height="100%" ID="ReportViewer1" runat="server" Width="100%">
        </rsweb:ReportViewer>
    
    </div>
    </form>
</body>
</html>
