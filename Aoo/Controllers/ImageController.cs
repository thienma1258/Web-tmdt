using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aoo.Controllers
{
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        IImageServices imageServices;
        public ImageController(IImageServices ImageServices)
        {
            this.imageServices = ImageServices;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [Route("UploadImage")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            List<string> listImagePath = new List<string>();
            List<ImageErrorModel> listImageErrorModel =  new List<ImageErrorModel>();
            if (files.Count <= 0)
                return BadRequest(new { success="false" });
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    ImageErrorModel imageErrorModel;
                    MemoryStream memoryStream = new MemoryStream();
                     formFile.CopyTo(memoryStream);
                    string ImagePath = this.imageServices.UploadImage(memoryStream, formFile.FileName, out imageErrorModel);
                    listImagePath.Add(ImagePath);
                    listImageErrorModel.Add(imageErrorModel);
                }
              
            }
            return Ok(new { success = "true",listImagePath=listImagePath, Erros = listImageErrorModel });
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
