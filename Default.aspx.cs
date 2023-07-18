using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace Temp.WebTemplate.Edu.jhbae
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownList();
            }
        }
        protected void BindDropDownList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["JINI_EDU"].ConnectionString; ; 

            string procedureName = "GetFruits";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    ddlFruits.DataSource = dataSet;
                    ddlFruits.DataBind();

                    ddlFruits.Items.Insert(0, new ListItem("선택하세요", "0"));
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedText = ddlFruits.SelectedItem.Text;
            string selectedValue = ddlFruits.SelectedItem.Value;

            lblResult.Text = $"선택된 과일: {selectedText}, 값: {selectedValue}";
        }

    }
}