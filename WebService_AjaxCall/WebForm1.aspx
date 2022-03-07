<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxCall2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>
    <script>
        $(document).ready(function() {
            Bind();
        });

        function Bind() {
            $("#EmpName").blur(function() {
                $.ajax({
                    url: "WebService1.asmx/EmployeeGet",
                    data: "{ 'Name': '" + $('input[id=EmpName]').val() + "'}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    success: function(data) {
                        if (data.d != '') {
                            $('span[id=lbl1]').text(data.d.Name);
                            $('span[id=lbl2]').text(data.d.City);
                          
                        }
                    }
                });
            });
        }
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div>
        <input type="text" id="EmpName" />
        
        <div><b>Name:</b> <asp:Label ID="lbl1" runat="server"></asp:Label></div>
        <div><b>City:</b> <asp:Label ID="lbl2" runat="server"></asp:Label></div>
 
    </div>
    </div>
    </form>
</body>
</html>
