using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpIndexers
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //First create an Instance of the Company class
            //Once the Instance is created 
            //the constructor gets called automatically.
            Company company = new Company();

            //Using INDEXER OVERLOADING
            //To get the Number of Male Employees
            //company["Male"] invokes Get Accesor.
            Response.Write("Before update");
            Response.Write("<br />");
            Response.Write("Total Number of Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Number of Female Employees = " + company["Female"]);

            Response.Write("<br />");
            Response.Write("<br />");

            //Invoke the Set Accessor
            company["Male"] = "Female";

            Response.Write("After update");
            Response.Write("<br />");
            Response.Write("Total Number of Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Number of Female Employees = " + company["Female"]);
            Response.Write("<br />");
            Response.Write("<br />");


            //Now print Employee Names using Indexers
            Response.Write("Name of Employee with id 10: " +company[10]);
            Response.Write("<br />");

            Response.Write("Name of Employee with id 12: " + company[12]);
            Response.Write("<br />");
            Response.Write("<br />");

            //Change the Names of those Employees
            Response.Write("Changing Names of Employees with Ids: 10 & 12");
            Response.Write("<br />");
            Response.Write("<br />");

            company[10] = " 10th Employee Changed!";
            company[12] = " 12th Employee Changed!";

            //Print the New values
            Response.Write("Name of Employee with id 10: " + company[10]);
            Response.Write("<br />");

            Response.Write("Name of Employee with id 12: " + company[12]);
            Response.Write("<br />");
        }
    }
}