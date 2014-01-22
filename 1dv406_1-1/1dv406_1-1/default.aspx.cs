using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1dv406_1_1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            // Analyserar textboxfältet och presenterar antalet inmatade
            // versaler med möjlighet att rensa textfältet och börja om
            if (TextBoxArea.Enabled)
            { 
                int capitalLetters = Model.TextAnalyzer.GetNumberOfCapitals(TextBoxArea.Text);
                TextBoxArea.Enabled = false;
                ResultInfo.Text = String.Format("Texten innehåller {0} versaler", capitalLetters);
                ResultInfo.Visible = true;
                SendButton.Text = "Rensa";
            }
            else
            {
                TextBoxArea.Text = "";
                TextBoxArea.Enabled = true;
                ResultInfo.Visible = false;
                SendButton.Text = "Beräkna antalet versaler";
            }
        }
    }
}