using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCoMa
{
    public static class ImageCache
    {
        static Dictionary<string, Image> imageCache = new();

        public static async Task<Image> GetImage(string imagePath, Size? size = null)
        {
            if (!imageCache.ContainsKey(imagePath))
            {
                if (!imagePath.StartsWith("https"))
                {
                    imageCache.Add(imagePath, Image.FromFile(imagePath));
                }
                else
                {
                    var filename = Path.GetFileName(imagePath);
                    var finalFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AlCoMa", "Images", filename);
                    Directory.CreateDirectory(Path.GetDirectoryName(finalFileName)!);
                    if (!File.Exists(finalFileName))
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            try
                            {
                                byte[] imageBytes = await client.GetByteArrayAsync(imagePath);
                                await File.WriteAllBytesAsync(finalFileName, imageBytes);
                            }
                            catch (Exception ex)
                            {
                                Logger.Log(ex.ToString());
                            }
                        }
                    }

                    imageCache[imagePath] = Image.FromFile(finalFileName);
                }
            }
            if (size.HasValue)
            {
                return new Bitmap(imageCache[imagePath], size.Value);
            }
            return imageCache[imagePath];
        }
    }
}
