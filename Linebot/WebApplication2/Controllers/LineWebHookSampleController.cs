using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "mT1+MeHamE9Iy/pys2Mlnorzsb2mrRHxQPZgg6MwJ8h1w7LOV4mHqUME45K0uUa9O4OOynIptNqk156bKWr51ZXMBEXqKZ7pXTzcRH0YY5DABowHsB9wlD7ZG7gaCS1OgTsve08JqTyDgrYF7o+aGAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "Ua794d5fc8c988c9bc80a19ffe71ca4f5";

        [Route("api/LineWebHookSamplecode")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //replyToken不需要ID自動回復訊息(回復原本來源的人 ex.在群組裡)
                //回覆訊息
                if (LineEvent.message.type == "message")
                {
                    /*this.PushMessage(AdminUserId, "id:" + LineEvent.source.userId
                                                  + " \n 您的朋友：" + GetUserInfo(LineEvent.source.userId).displayName
                                                    + " \n 傳送了 " + LineEvent.message.text + " 給您");*/
                    if (LineEvent.message.type == "text") //收到文字
                    {
                        if (LineEvent.message.text == "Hello")
                        {
                            this.ReplyMessage(LineEvent.replyToken, GetUserInfo(LineEvent.source.userId).displayName + "你好");
                        }
                        else
                        {
                            this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                        }
                    }
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 117);
                    if (LineEvent.message.type == "Location")
                        this.ReplyMessage(LineEvent.replyToken, LineEvent.message.address);
                    if (LineEvent.message.type == "image")
                    {
                        //取得圖片的bytes
                        var bytes = this.GetUserUploadedContent(LineEvent.message.id);
                        //儲存圖片
                        var guid = Guid.NewGuid().ToString();
                        var filename = $"{guid}.png";
                        var path = System.Web.Hosting.HostingEnvironment.MapPath("~/temp/");
                        System.IO.File.WriteAllBytes(path + filename, bytes);
                        //取得base URL
                        var baseURL = Request.RequestUri.GetLeftPart(UriPartial.Authority);
                        //取出外界可以讀取的檔名
                        var url = $"{baseURL}/temp/{filename}";
                        this.ReplyMessage(LineEvent.replyToken, $"你的圖片位於 \n {url}");
                    }
                }
                if (LineEvent.type == "postback")
                {
                    var data = LineEvent.postback.data;
                    this.ReplyMessage(LineEvent.replyToken, $"觸發了postback");
                }
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
