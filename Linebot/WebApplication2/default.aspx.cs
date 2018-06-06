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

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            var ImageCarouselColumn1 = new ImageCarouselColumn
            {
                imageUrl = new Uri("https://stickershop.line-scdn.net/stickershop/v1/product/1192549/LINEStorePC/main@2x.png;compress=true?__=20161019"),
                action = new MessageAction() { label = "今天吃...", text = "Pizza !!" }
            };

            var ImageCarouselColumn2 = new ImageCarouselColumn
            {
                imageUrl = new Uri("https://stickershop.line-scdn.net/stickershop/v1/product/1192549/LINEStorePC/main@2x.png;compress=true?__=20161019"),
                action = new MessageAction() { label = "今天吃...", text = "Pizza !!" }
            };
            
            var ImageCarouselColumn3 = new ImageCarouselColumn
            {
                imageUrl = new Uri("https://stickershop.line-scdn.net/stickershop/v1/product/1192549/LINEStorePC/main@2x.png;compress=true?__=20161019"),
                action = new MessageAction() { label = "今天吃...", text = "Pizza !!" }
            };
            //輪動(圖)
            var ImageCarouselTemplate = new ImageCarouselTemplate();

            ImageCarouselTemplate.columns.Add(ImageCarouselColumn1);
            ImageCarouselTemplate.columns.Add(ImageCarouselColumn2);
            ImageCarouselTemplate.columns.Add(ImageCarouselColumn3);

            bot.PushMessage(AdminUserId, ImageCarouselTemplate);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            //用戶回覆行為
            var action = new List<TemplateActionBase>();
            action.Add(new MessageAction() { label = "pizza", text = "pizza!!" });
            action.Add(new UriAction() { label = "查看連結", uri = new Uri("https://www.pizzahut.com.tw/") });
            //action.Add(new PostbackAction() { label = "error", data = "eeeee" });

            var Column = new Column
            {
                title = "吃甚麼好",
                text = "pizza",
                thumbnailImageUrl = new Uri("https://stickershop.line-scdn.net/stickershop/v1/product/1192549/LINEStorePC/main@2x.png;compress=true?__=20161019"),
                actions = action
            };

            var action2 = new List<TemplateActionBase>();
            action2.Add(new MessageAction() { label = "咖哩", text = "咖哩!!" });
            action2.Add(new UriAction() { label = "查看連結", uri = new Uri("https://icook.tw/recipes/254289") });
            //action.Add(new PostbackAction() { label = "發生postback", data = "在背景傳遞訊息" });

            var Column2 = new Column
            {
                title = "吃甚麼好",
                text = "咖哩",
                thumbnailImageUrl = new Uri("https://dbjdsnch130xu.cloudfront.net/uploads/recipe/cover/254289/large_5703f216af9105dd.jpg"),
                actions = action2
            };
            //輪動(ButtonTemplate)
            var CarouselTemplate = new isRock.LineBot.CarouselTemplate();

            CarouselTemplate.columns.Add(Column);
            CarouselTemplate.columns.Add(Column2);
            CarouselTemplate.columns.Add(Column);
            
            bot.PushMessage(AdminUserId, CarouselTemplate);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            var action = new List<TemplateActionBase>();
            action.Add(new MessageAction() { label = "pizza", text = "pizza!!" });
            action.Add(new UriAction() { label = "查看連結", uri = new Uri("https://www.pizzahut.com.tw/") });
            action.Add(new DateTimePickerAction() { label = "選擇時間", mode = "datetime" });//Postback
            action.Add(new PostbackAction() { label = "發生postback", data = "在背景傳遞訊息" });


            var ButtonTemplate = new ButtonsTemplate
            {
                title = "吃甚麼好",
                text = "pizza",
                altText="請在手機上檢視",
                thumbnailImageUrl = new Uri("https://stickershop.line-scdn.net/stickershop/v1/product/1192549/LINEStorePC/main@2x.png;compress=true?__=20161019"),
                actions = action
            };

            bot.PushMessage(AdminUserId, ButtonTemplate);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            var action = new List<TemplateActionBase>();
            action.Add(new MessageAction() { label = "Yes", text = "Yes" });
            action.Add(new MessageAction() { label = "No", text = "No" });

            var ConfirmTemplate = new ConfirmTemplate()
            {
                text = "現在要吃飯嗎",
                altText = "請在手機上檢視",
                actions = action
            };

            bot.PushMessage(AdminUserId, ConfirmTemplate);
        }
    }
}