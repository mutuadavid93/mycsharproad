using System;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint;

namespace CRUDLISTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Start The site and web initialization
            const string siteUrl = "https://alternateltd.sharepoint.com/";
            const string siteName = "/sites/dev/Lists/";
            string listName = "Parts List";

            //Freeze UI
            Cursor = Cursors.WaitCursor;
            addListData.Enabled = false;

            //Return a site collection using the SPSite constructor providing the site URL
            SPSite siteCollection = new SPSite(siteUrl);

            //Return the target web site based on site name
            SPWeb site = siteCollection.AllWebs[siteName];

            //Return a collection of list items based on the Items property
            //for the specific named list
            SPListItemCollection listItems = site.Lists[listName].Items;

            //Add a list item to the list items collection
            SPListItem item = listItems.Add();

            //Populate item data via user indexers with form input data
            item["Title"] = textBox1.Text;
            item["Part Number"] = Convert.ToInt16(textBox2.Text);
            item["Price"] = Convert.ToInt16(textBox3.Text);

            //Update SP database with changes made to this item
            item.Update();

            //UI clean-up
            lblStatus.Text = "Done!";
            Cursor = Cursors.Default;
            addListData.Enabled = true;


        }
    }
}
