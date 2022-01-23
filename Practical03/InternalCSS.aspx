<%--3. Write a program using the concept of cascading style sheet in ASP.net--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InternalCSS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html {
            font-size: small;
            color: blue;
        }

        #ex1 {
            background-color: yellow;
            color: red;
        }

        #ex2 {
            background-color: yellow;
            color: red;
            all: inherit;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>No all property:</p>
        <div id="ex1">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</div>

        <p>all: inherit:</p>
        <div id="ex2">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</div>

    </form>
</body>
</html>
