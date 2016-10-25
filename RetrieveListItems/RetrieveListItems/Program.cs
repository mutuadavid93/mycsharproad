using System;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client; 

namespace Microsoft.SDK.SharePointServices.Samples
{
    class RetrieveListItems
    {
        static void Main()
        {
            string SPSite = "http://gauti.sharepoint.com/sites/SP";

            ClientContext clientContext = new ClientContext(SPSite);
            SP.List oList = clientContext.Web.Lists.GetByTitle("CustomDepartments");

            CamlQuery camlQuery = new CamlQuery();
            camlQuery.ViewXml = "<View><Query><Where><Geq><FieldRef Name='ID'/>" +
                "<Value Type='Number'>19</Value></Geq></Where></Query><RowLimit>100</RowLimit></View>";


            ListItemCollection collListItem = oList.GetItems(camlQuery);

            clientContext.Load(collListItem);

            clientContext.ExecuteQuery();

            foreach (ListItem oListItem in collListItem)
            {
                Console.WriteLine("ID: {0} \nTitle: {1} \nBody: {2}", oListItem.Id, oListItem["Title"], oListItem["Body"]);
            }
        }
    }
}  

