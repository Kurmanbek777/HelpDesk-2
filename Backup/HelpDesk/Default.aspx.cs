using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpDesk
{
    public partial class _Default : System.Web.UI.Page
    {
        #region Declarations
        HelpDesk hd = new HelpDesk();
        #endregion

        #region Methods
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCombos();
            }
        }

        protected void LoadCombos()
        {
            ICollection<Severity> severity = Severity.GetSeverities();
            ddlSeverity.DataTextField = "severity";
            ddlSeverity.DataValueField = "id";
            ddlSeverity.DataSource = severity;
            ddlSeverity.DataBind();

            ICollection<Status> status = Status.GetStatuses();
            ddlStatus.DataTextField = "status";
            ddlStatus.DataValueField = "id";
            ddlStatus.DataSource = status;
            ddlStatus.DataBind();

            ICollection<Department> dept = Department.GetDepartments();
            ddlDept.DataTextField = "department";
            ddlDept.DataValueField = "id";
            ddlDept.DataSource = dept;
            ddlDept.DataBind();

            ICollection<Employee> emp = Employee.GetEmployee();
            ddlEmp.DataTextField = "name";
            ddlEmp.DataValueField = "empid";
            ddlEmp.DataSource = emp;
            ddlEmp.DataBind();
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            hd.fname = fnameTB.Text;
            hd.lname = lnameTB.Text;
            hd.email = emailTB.Text;
            hd.severity = Convert.ToInt32(ddlSeverity.SelectedValue);
            hd.status = Convert.ToInt32(ddlStatus.SelectedValue);
            hd.department = Convert.ToInt32(ddlDept.SelectedValue);
            hd.comments = commentsTB.Text;
            hd.Save();
            phForm.Visible = false;
            phSuccess.Visible = true;
        }
        #endregion
    }
}
