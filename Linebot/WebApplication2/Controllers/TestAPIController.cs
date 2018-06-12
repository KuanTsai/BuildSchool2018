using Microsoft.ProjectOxford.Vision;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class TestAPIController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "mT1+MeHamE9Iy/pys2Mlnorzsb2mrRHxQPZgg6MwJ8h1w7LOV4mHqUME45K0uUa9O4OOynIptNqk156bKWr51ZXMBEXqKZ7pXTzcRH0YY5DABowHsB9wlD7ZG7gaCS1OgTsve08JqTyDgrYF7o+aGAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId = "Ua794d5fc8c988c9bc80a19ffe71ca4f5";
        const string VisionAPIKey = "fa33c39d08f74103be72cf8a79f5326c";

        [Route("api/TestAPI")]
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
                if (LineEvent.message.type == "image")
                {
                    //取得圖片的bytes
                    var bytes = this.GetUserUploadedContent(LineEvent.message.id);
                    //儲存圖片
                    var guid = Guid.NewGuid().ToString();
                    var filename = $"{guid}.png";
                    var path = System.Web.Hosting.HostingEnvironment.MapPath("~/temp/");
                    File.WriteAllBytes(path + filename, bytes);

                    //取得base URL
                    var baseURL = Request.RequestUri.GetLeftPart(UriPartial.Authority);
                    //取出外界可以讀取的檔名
                    var url = $"{baseURL}/temp/{filename}";


                    var fs1 = new FileStream(path + filename, FileMode.Open);
                    Bitmap bmp = new Bitmap(fs1);
                    Graphics g = Graphics.FromImage(bmp);
                    fs1.Close();

                    var visionClient = new VisionServiceClient(VisionAPIKey, "https://southeastasia.api.cognitive.microsoft.com/vision/v1.0");

                    //分析圖片(從FileUpload1.PostedFile.InputStream取得影像)
                    //分析 Faces & Description 
                    var Results = visionClient.AnalyzeImageAsync(url,
                        new VisualFeature[] { VisualFeature.Faces, VisualFeature.Description }).Result;

                    int isM = 0, isF = 0;
                    //列出每一個找到的臉
                    foreach (var Face in Results.Faces)
                    {
                        //取得人臉位置
                        var faceRect = Face.FaceRectangle;
                        //繪製人臉紅框 , 年齡 
                        g.DrawRectangle(
                                    new Pen(Brushes.Red, 10),
                                    new Rectangle(faceRect.Left, faceRect.Top,
                                        faceRect.Width, faceRect.Height));
                        g.DrawString($"{Face.Age.ToString()} 歲", new Font("Arial", 25), Brushes.Red, new Point(faceRect.Left + 30, faceRect.Top - 50));

                        if (Face.Gender.StartsWith("M"))
                            isM += 1;
                        else
                            isF += 1;
                    }

                    //建立新檔案
                    filename = $"{guid}.png";
                    bmp.Save(System.Web.Hosting.HostingEnvironment.MapPath("~/temp/" + filename));
                    //顯示新檔案
                    url = $"{baseURL}/temp/{filename}";

                    this.ReplyMessage(LineEvent.replyToken, new Uri(url));
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
