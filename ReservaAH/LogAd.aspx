<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogAd.aspx.cs" Inherits="ReservaAH.LogAd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/bootstrap.min.css" rel="stylesheet" />
    <link href="CSS/StyleReservas.css" rel="stylesheet" />
    <script src="JS/bootstrap.bundle.min.js"></script>
</head>
<body>
    <center>
        <form id="form1" runat="server">
            <h3>LogIn</h3>
            <div class="card" style="width: 18rem;">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label">Email address</label>
                    <asp:TextBox type="email" class="form-control" ID="txtusuario" runat="server" placeholder="name@example.com"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="exampleFormControlTextarea1" class="form-label">Password</label>
                    <asp:TextBox class="form-control" ID="txtcontra" TextMode="Password" runat="server" Rows="3" placeholder="••••••"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Button class="btn btn-primary" ID="btnEntrar" runat="server" Text="Iniciar Sesion" OnClick="btnEntrar_Click" />
                </div>
                <div class="card-body">
                    <p class="card-text">Para obtener un usuario contacte con el administrador</p>
                </div>   
            </div>
        </form>
    </center>
</body>
</html>
