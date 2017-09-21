using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentRegistrationAssignment
{
    public  partial class AddressUserControl : System.Web.UI.UserControl
    {
        public  string TemporaryState {
            get
            {
                return txtTState.Text;
            }
            
        }
        public string TemporaryCity
        {
            get
            {
                return txtTCity.Text;
            }
        }
        public string TemporaryZipcode
        {
            get
            {
                return txtTZipcode.Text;
            }
        }

        public string PermanentState
        {
            get
            {
                return txtPState.Text;
            }
        }

        public string PermanentCity
        {
            get
            {
                return txtPCity.Text;
            }
        }

        public string PermanentZipcode
        {
            get
            {
                return txtPZipcode.Text;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
    }
}