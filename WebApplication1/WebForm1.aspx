<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính tiền Thuê sân bóng</title>
</head>
<body>
    <form id="form1" runat="server" class="form-container">
        <div class="content-wrapper">
            <h2 class="title">Tính tiền thuê sân bóng</h2>
            
            <div class="input-group">
                <label >Số giờ thuê sân:</label>
                <asp:TextBox ID="gio" runat="server" CssClass="input-box" ></asp:TextBox>
            </div>

            <div class="input-group">
                <label>Loại sân:</label>
               <div class="checkbox-group">
                    <asp:RadioButton ID="nhantao" runat="server" CssClass="checkbox" Text="Sân cỏ nhân tạo (70.000đ/giờ)" GroupName="LoaiSan" />
                    <asp:RadioButton ID="sanco" runat="server" CssClass="checkbox" Text="Sân cỏ (50.000đ/giờ)" GroupName="LoaiSan" />
                </div>

            </div>

            <div class="input-group">
                <asp:Button ID="tinhtien" runat="server" CssClass="btn-calculate" Text="Tính tiền" OnClick="tinhtien_Click" />
            </div>
            <div id="tongtien" runat="server"></div>
        </div>
    </form>
</body>
</html>

