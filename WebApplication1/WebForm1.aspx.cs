using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tinhtien_Click(object sender, EventArgs e)
        {
            int send = 0;
            try
            {
                double gio_thue = double.Parse(gio.Text);
                send = 1;

                San LoaiSan;
                if (nhantao.Checked)
                {
                    LoaiSan = San.nhantao;
                }
                else if (sanco.Checked)
                {
                    LoaiSan = San.sanco;
                }
                else
                {
                    throw new Exception("Chưa chọn loại sân!");
                }


                double tongTien = Class1.TinhTongTien(LoaiSan, gio_thue);

                string ketqua = $"Tổng tiền: {tongTien} VND";
                tongtien.InnerHtml = $"{ketqua}";
            }
            catch (Exception ex)
            {
                switch (send)
                {
                    case 0:
                        tongtien.InnerHtml = "Có lỗi khi nhập số giờ";
                        break;
                    case 1:
                        tongtien.InnerHtml = "Có lỗi khi chọn loại sân";
                        break;
                    default:
                        tongtien.InnerHtml = $"Có lỗi không xác định: {ex.Message}";
                        break;
                }
            }
        }
    }
}