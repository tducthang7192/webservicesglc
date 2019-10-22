using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://GMD.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public XmlDocument HelloWorld()
        {
            XElement test = new XElement("message",
             new XElement("SO",
             new XElement("header",
             new XElement("Transaction_Type","SO"),
             new XElement("Ou_Id", "85"),
             new XElement("Ou_Name", "140CTHO / OU: Can Tho"),
             new XElement("Plant_Code", "4F0"),
             new XElement("Process_Type", "Sales Order"),
             new XElement("Mode_Of_Transport", "ROAD"),
             new XElement("Reference_Number", "44200009081"),
             new XElement("Ship_To_Warehouse"),
             new XElement("Ship_To_Locator"),
             new XElement("Customer_Number", "1005111-58557"),
             new XElement("Customer_Name", "Cty TNHH Nuoc Giai Khat Suntory Pepsico Viet Nam"),
             new XElement("shippingAddress",
             new XElement("unit"),
             new XElement("building"),
             new XElement("street", "Phòng Field Marketing Cần Thơ"),
             new XElement("city", "TP.Can Tho"),
             new XElement("state"),
             new XElement("zip_code"),
             new XElement("country_code", "VN")),
             new XElement("Shelf_Life_Percent_Required"),
             new XElement("Order_Released_Date", "19-SEP-2019 00:00:00"),
             new XElement("Delivery_Due_Date"),
             new XElement("Header_Remarks", "Agency sampling QT Tran Quang Khai Kien Giang"),
             new XElement("Owner", "SPVB_CT")),
             new XElement("detail",
             new XElement("item",
             new XElement("Group_Id", "1"),
             new XElement("Order_Line_Id", "14827185"),
             new XElement("Order_line_detail_Id", "39040778"),
             new XElement("Item_Code", "12702001"),
             new XElement("Lot_Number"),
             new XElement("Quantity", "125"),
             new XElement("Unit_Of_Measure", "CAR"),
             new XElement("Product_Status", "Active"),
             new XElement("Ship_From_Warehouse", "4F0"),
             new XElement("Ship_From_Sub_Inventory", "4F0.F1"), 
             new XElement("Ship_From_Locator", "SPVB_ALL_00"),
             new XElement("Item_Remarks")),
             new XElement("item",
             new XElement("Group_Id", "2"),
             new XElement("Order_Line_Id", "14827165"),
             new XElement("Order_line_detail_Id", "3904064"),
             new XElement("Item_Code", "12702005"),
             new XElement("Lot_Number"),
             new XElement("Quantity", "60"),
             new XElement("Unit_Of_Measure", "CAR"),
             new XElement("Product_Status", "Active"),
             new XElement("Ship_From_Warehouse", "4F0"),
             new XElement("Ship_From_Sub_Inventory", "4F0.F1"),
             new XElement("Ship_From_Locator", "SPVB_ALL_00"),
             new XElement("Item_Remarks")))),
              new XElement("SO",
             new XElement("header",
             new XElement("Transaction_Type", "SO"),
             new XElement("Ou_Id", "85"),
             new XElement("Ou_Name", "140CTHO / OU: Can Tho"),
             new XElement("Plant_Code", "4F0"),
             new XElement("Process_Type", "Sales Order"),
             new XElement("Mode_Of_Transport", "ROAD"),
             new XElement("Reference_Number", "45000004410"),
             new XElement("Ship_To_Warehouse"),
             new XElement("Ship_To_Locator"),
             new XElement("Customer_Number", "1005111-58557"),
             new XElement("Customer_Name", "141-S&amp;D.Cty TNHH Nuoc Giai Khat Suntory Pepsico Vi"),
             new XElement("shippingAddress",
             new XElement("unit"),
             new XElement("building"),
             new XElement("street", "Lo 2.19B, 2.19D, 2.19D1 Khu CN Tra Noc 2, P.Phuoc Thoi, Q.O Mon, TP.Can Tho"),
             new XElement("city", "TP.Can Tho"),
             new XElement("state"),
             new XElement("zip_code"),
             new XElement("country_code", "VN")),
             new XElement("Shelf_Life_Percent_Required", "70"),
             new XElement("Order_Released_Date", "19-SEP-2019 00:00:00"),
             new XElement("Delivery_Due_Date"),
             new XElement("Header_Remarks", "VP Sales"),
             new XElement("Owner", "SPVB_CT")),
             new XElement("detail",
             new XElement("item",
             new XElement("Group_Id", "1"),
             new XElement("Order_Line_Id", "14824368"),
             new XElement("Order_line_detail_Id", "39033155"),
             new XElement("Item_Code", "11601003"),
             new XElement("Lot_Number"),
             new XElement("Quantity", "125"),
             new XElement("Unit_Of_Measure", "CAR"),
             new XElement("Product_Status", "Active"),
             new XElement("Ship_From_Warehouse", "4F0"),
             new XElement("Ship_From_Sub_Inventory", "4F0.F1"),
             new XElement("Ship_From_Locator", "SPVB_PK_70"),
             new XElement("Item_Remarks")))));
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(test.ToString());
            return xmlDocument;
        }

        [WebMethod]
        public XmlDocument GetData()
        {
            DataTable dt = Class1.SELECT_SQL("select top 1 * from LPN_RM");
            string lpn = dt.Rows[0]["LPN"].ToString();
            XElement test = new XElement("Contact",
         new XElement("Name", "Patrick Hines"),
             new XElement("Postal", lpn)
   );
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(test.ToString());
            return xmlDocument;
            
        }
    }
}
