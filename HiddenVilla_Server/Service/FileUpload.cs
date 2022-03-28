using HiddenVilla_Server.Service.IService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Service
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool DeleteFile(string Filename)
        {
            
            try
            {
                var path = $"{_webHostEnvironment.WebRootPath}\\RootImages\\{Filename}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileinfo = new FileInfo(file.Name);
                var filename = Guid.NewGuid().ToString() + fileinfo.Extension;
                var folderdirectory = $"{_webHostEnvironment.WebRootPath}\\RoomImages";
                var path = Path.Combine(_webHostEnvironment.WebRootPath, "RoomImages", filename);
                var Memorystream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(Memorystream);
                if (!Directory.Exists(folderdirectory))
                {
                    Directory.CreateDirectory(folderdirectory);
                }
                await using (var fs = new FileStream(path,FileMode.Create, FileAccess.Write))
                {
                    Memorystream.WriteTo(fs);
                }
                var Fullpath = $"RoomImages/{filename}";
                return Fullpath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
