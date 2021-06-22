using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot";
            var sourcePath = Path.GetTempFileName();
            if (file.Length>0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcePath, path + result);
            return result.Replace("\\", "/");
        }

        public static IResult Delete(string path)
        {
            string path2 = Environment.CurrentDirectory + @"\wwwroot";
            path = path.Replace("/", "\\");

            try
            {
                File.Delete(path2 + path);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot";
            var result = newPath(file);
            if (sourcePath.Length>0)
            {
                using (var stream = new FileStream(path + result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                
            }
            File.Delete(path + sourcePath);
            return result.Replace("\\", "/");
        }

        private static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            var newPath = Guid.NewGuid().ToString() + fileExtension;

            return @"\Images\" + newPath;
        }
    }
}
