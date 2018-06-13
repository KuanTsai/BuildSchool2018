using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "mT1+MeHamE9Iy/pys2Mlnorzsb2mrRHxQPZgg6MwJ8h1w7LOV4mHqUME45K0uUa9O4OOynIptNqk156bKWr51ZXMBEXqKZ7pXTzcRH0YY5DABowHsB9wlD7ZG7gaCS1OgTsve08JqTyDgrYF7o+aGAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "Ua794d5fc8c988c9bc80a19ffe71ca4f5";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}