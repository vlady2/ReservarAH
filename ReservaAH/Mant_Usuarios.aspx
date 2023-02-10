<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mant_Usuarios.aspx.cs" Inherits="ReservaAH.Mant_Usuarios" %>

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
    <nav class="navbar navbar-expand-lg bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">QHotel</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="https://github.com/vlady2">Creador</a>
                    </li>
                </ul>
                <form class="d-flex" role="search">
                    <div class="row g-2">
                        <div class="col-auto">
                            <asp:Image ID="pImage" runat="server" Class="imageP" />
                        </div>
                        <div class="col-auto">
                            <asp:Label ID="pUser" runat="server" class="top-100 start-100 translate-middle"></asp:Label>
                        </div>
                    </div>  
                </form>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server" class="row g-2 formP">
        <div class="container text-center">
            <div class="row align-items-start">
                <div class="col">
                    <label for="exampleFormControlInput1" class="form-label">Email address</label>
                    <asp:TextBox ID="txtcorreo" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="exampleFormControlInput1" class="form-label">Password</label>
                    <asp:TextBox ID="txtpasword" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="col">
                    <label for="exampleFormControlInput1" class="form-label">Rol</label>
                    <asp:TextBox ID="txtrol" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <label for="formFile" class="form-label">Picture profile</label>
            <asp:TextBox ID="txtavatar" runat="server" class="form-control"></asp:TextBox>
            <br />
            <asp:Button class="btn btn-secondary" ID="btnGuardar" runat="server" Text="Save user" data-togle="tooltip" title="Save" OnClick="btnGuardar_Click"/>
        </div>
        <br />
        <div class="col-auto">
            <asp:GridView class="table table-sm" ID="gvUser" runat="server" DataKeyNames="Id_Usu" OnRowDeleting="gvUser_RowDeleting" OnRowEditing="gvUser_RowEditing">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>