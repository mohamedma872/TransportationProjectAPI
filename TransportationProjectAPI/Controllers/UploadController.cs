using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TransportationBL.BL;
using TransportationBL.utilities;

public class UploadController : ApiController
{
    [HttpPost, Route("api/Upload/UpdateAttachement")]
    public async Task<HttpResponseMessage> UpdateAttachement(long UserID, int key)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();
        try
        {

            var httpRequest = HttpContext.Current.Request;
            List<string> pathes = new List<string>();
            foreach (string file in httpRequest.Files)
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

                var postedFile = httpRequest.Files[file];
               
                if (postedFile != null && postedFile.ContentLength > 0)
                {

                    int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB
                    IList<string> AllowedFileExtensions = new List<string> { ".jpg", ".gif", ".png" };
                    var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                    var extension = ext.ToLower();
                    if (!AllowedFileExtensions.Contains(extension))
                    {

                        var message = string.Format("Please Upload image of type .jpg,.gif,.png.");

                        dict.Add("error", message);
                        return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                    }
                    else if (postedFile.ContentLength > MaxContentLength)
                    {

                        var message = string.Format("Please Upload a file upto 1 mb.");

                        dict.Add("error", message);
                        return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                    }
                    else
                    {

                        //YourModelProperty.imageurl = userInfo.email_id + extension;
                        //  where you want to attach your imageurl

                        //if needed write the code to update the table

                        var filePath = HttpContext.Current.Server.MapPath("~/App_Data/" + postedFile.FileName.Replace(" ", string.Empty));
                        //Userimage myfolder name where i want to save my image
                        postedFile.SaveAs(filePath);
                         pathes.Add("http://api.shuhnaty.com/attachement/" + postedFile.FileName.Replace(" ", string.Empty));
                        var json = JsonConvert.SerializeObject(new
                        {
                            Files = pathes
                        });
                        OperationResult or;
                        try
                        {
                            or = new DriverBl().updateAttachments(UserID, key, "http://api.shuhnaty.com/attachement/" + postedFile.FileName.Replace(" ", string.Empty));
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        //var message1 = string.Format("Image Updated Successfully.");
                        return Request.CreateErrorResponse(HttpStatusCode.Created, json);
                    }
                }

            }

            var res = string.Format("Please Upload a image.");
            dict.Add("error", res);
            return Request.CreateResponse(HttpStatusCode.NotFound, dict);
        }
        catch (Exception ex)
        {
            var res = string.Format(ex.StackTrace);
            dict.Add("error", res);
            return Request.CreateResponse(HttpStatusCode.NotFound, dict);
        }
    }
    //[HttpPost]
    //public async Task<List<string>> PostFile(int UserID)
    //{
    //    Check if the request contains multipart / form - data.
    //    if (!Request.Content.IsMimeMultipartContent())
    //    {
    //        throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
    //    }

    //    string root = HttpContext.Current.Server.MapPath("~/App_Data");
    //    var provider = new MultipartFormDataStreamProvider(root);
    //    List<string> data = new List<string>();
    //    List<string> Keys = new List<string>();
    //    try
    //    {


    //        StringBuilder sb = new StringBuilder(); // Holds the response body

    //        Read the form data and return an async task.
    //       var filesReadToProvider = await Request.Content.ReadAsMultipartAsync(provider);

    //        This illustrates how to get the form data.
    //        foreach (var key in filesReadToProvider.FormData.Keys)
    //        {
    //            Keys.Add(key.ToString());
    //            foreach (var val in provider.FormData.GetValues(key))
    //            {
    //                // sb.Append(string.Format("{0}: {1}\n", key, val));

    //            }
    //        }

    //        This illustrates how to get the file names for uploaded files.
    //        foreach (var file in provider.FileData)
    //            {
    //                FileInfo fileInfo = new FileInfo(file.LocalFileName);
    //                sb.Append(string.Format("Uploaded file: {0} ({1} bytes)\n", fileInfo.Name, fileInfo.Length));
    //                data.Add(string.Format("{0}/{1}", "App_Data", fileInfo.Name));
    //                sb.Append(string.Format("{0}/{1}", "App_Data", fileInfo.Name));
    //            }
    //        var json = JsonConvert.SerializeObject(new
    //        {
    //            operations = data
    //        });
    //        return Keys;
    //    }
    //    catch (System.Exception e)
    //    {
    //        return Keys;
    //    }
    //}



}