﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentRegistrationAssignment;

namespace StudentRegistrationAssignment
{
    public partial class Registration : System.Web.UI.Page
    {
        
        List<Student> studentsList = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Student s = new Student() { Name = txtName.Text, Email = txtEmail.Text, DateOfBirth = DateTime.Parse(txtDateOfBirth.Text), Password = txtPassword.Text, ConfirmPassword = txtConfirmPassword.Text,
                TAState = AddressUserControl.TemporaryState, TACity = AddressUserControl.TemporaryCity, TAZipcode = AddressUserControl.TemporaryZipcode, PTState = AddressUserControl.PermanentState, PTCity = AddressUserControl.PermanentCity, PTZipcode=AddressUserControl.PermanentZipcode };
           
            studentsList.Add(s);
            Response.Redirect(string.Format("~/Welcome.aspx?NameQS={0}&TemporaryCityName={1}",txtName.Text,AddressUserControl.TemporaryCity));
        }
    }
}