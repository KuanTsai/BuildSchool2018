using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("mT1+MeHamE9Iy/pys2Mlnorzsb2mrRHxQPZgg6MwJ8h1w7LOV4mHqUME45K0uUa9O4OOynIptNqk156bKWr51ZXMBEXqKZ7pXTzcRH0YY5DABowHsB9wlD7ZG7gaCS1OgTsve08JqTyDgrYF7o+aGAdB04t89/1O/w1cDnyilFU=");

            //bot.PushMessage("Ua794d5fc8c988c9bc80a19ffe71ca4f5", "今天要不要去唱歌");
            //bot.PushMessage("Ua794d5fc8c988c9bc80a19ffe71ca4f5", 1, 11);
            //bot.PushMessage("Ua794d5fc8c988c9bc80a19ffe71ca4f5", new Uri(""));
            var UserInfo = bot.GetUserInfo("Ua794d5fc8c988c9bc80a19ffe71ca4f5");
            Response.Write(UserInfo.displayName + "<br/>" + UserInfo.statusMessage);
        }
    }
}