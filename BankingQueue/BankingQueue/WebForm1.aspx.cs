using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingQueue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queuetokens = new Queue<int>();
                Session["TokenQueue"] = queuetokens;

            }
        }

        protected void btnToken_Click(object sender, EventArgs e)
        {
            //Extract that queue from session on btn click
            //Whatever you get from the token convert it 
            //to queue.
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers ahead of you in the queue.";


            //Now compute the next token number in the queueu
            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }

            int nextTokeNumberToBeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokeNumberToBeIssued;

            //Now add it to Queue
            tokenQueue.Enqueue(nextTokeNumberToBeIssued);

            AddTokensToListBox(tokenQueue);
        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            //Display them into the ListBox
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        //Method to serve the next customer
        private void ServerNextCustomer(TextBox txtbox, int counternumber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count == 0)
            {
                txtbox.Text = "No customers in the Queue";
            }
            else
            {
                //Remove the tokenNumber at the beginning of the queue
                int tokenNumberToBeServed = tokenQueue.Dequeue();

                txtbox.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = "Token number : " + tokenNumberToBeServed.ToString() + ", Please proceed to counter number : "
                    + counternumber.ToString();

                //Now remove that token number from listbox
                AddTokensToListBox(tokenQueue);
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            //Invoke that method
            ServerNextCustomer(TextCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(TextCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(TextCounter3, 3);
        }

    }
}