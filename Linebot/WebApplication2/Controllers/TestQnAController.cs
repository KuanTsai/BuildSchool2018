using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudyHostExampleLinebot.Controllers
{
    public class TestQnAController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "mT1+MeHamE9Iy/pys2Mlnorzsb2mrRHxQPZgg6MwJ8h1w7LOV4mHqUME45K0uUa9O4OOynIptNqk156bKWr51ZXMBEXqKZ7pXTzcRH0YY5DABowHsB9wlD7ZG7gaCS1OgTsve08JqTyDgrYF7o+aGAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "Ua794d5fc8c988c9bc80a19ffe71ca4f5";
        const string QnAKBId = "8ab18608-10e1-403b-91b0-3951d6e24acb";
        const string QnAKey = "9fbc04d4-c00b-4dbc-ba3b-b1791b669530";
        const string Endpoint = "https://qamakerapi.azurewebsites.net/qnamaker/knowledgebases/8ab18608-10e1-403b-91b0-3951d6e24acb/generateAnswer"; //ex.westus
        const string UnknowAnswer = "不好意思，您可以換個方式問嗎? 我不太明白您的意思...";

        [Route("api/TestQnA")]
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
                //回覆訊息
                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                    {
                        //建立 MsQnAMaker Client
                        var helper = new isRock.MsQnAMaker.Client(
                            new Uri(Endpoint), QnAKey);
                        var QnAResponse = helper.GetResponse(LineEvent.message.text.Trim());
                        var ret = (from c in QnAResponse.answers
                                   orderby c.score descending
                                   select c
                                ).Take(1);

                        var responseText = UnknowAnswer;
                        if (ret.FirstOrDefault().score > 0)
                            responseText = ret.FirstOrDefault().answer;
                        //回覆
                        this.ReplyMessage(LineEvent.replyToken, responseText);
                    }
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 2);
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
