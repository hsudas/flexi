using Flexi.Shared.Log;
using Flexi.Model.Poco;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;

namespace Flexi.Shared.Helper
{
    public class ImageHelper
    {
        private static readonly Lazy<ImageHelper> lazy = new Lazy<ImageHelper>(() => new ImageHelper());
        public static ImageHelper Instance { get { return lazy.Value; } }
        private ImageHelper()
        {
        }

        public void DownloadAndSaveImage(string directoryPath, string imageUrl)
        {
            Image image = DownloadImageFromUrl(imageUrl);
            string fullPath = System.IO.Path.Combine(directoryPath, Path.GetFileName(imageUrl));
            image.Save(fullPath);
            image.Dispose();
        }

        public void DownloadAndSaveImageWithFullPath(string fullPath, string imageUrl)
        {
            Image image = DownloadImageFromUrl(imageUrl);
            image.Save(fullPath);
            image.Dispose();
        }

        private Image DownloadImageFromUrl(string imageUrl)
        {
            Image image = null;
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 10000;
                WebResponse webResponse = webRequest.GetResponse();
                System.IO.Stream stream = webResponse.GetResponseStream();
                image = Image.FromStream(stream);
                webResponse.Close();
            }
            catch (Exception exc)
            {
                Logger.Error("DownloadImageFromUrl error!", exc);
                return null;
            }

            return image;
        }

        public List<string> PrepareValidImageList(List<string> imageUrlList)
        {
            List<string> validImageList = new List<string>();
            foreach (var imageUrl in imageUrlList)
            {
                if (isValidImageUrl(imageUrl))
                {
                    validImageList.Add(imageUrl);
                }
            }
            return validImageList;
        }

        public string SaveValidImageList(string directoryPath, string fileHeader, List<string> imageUrlList)
        {
            string imageNameArray = string.Empty;
            int counter = 1;
            List<ValidImagePoco> validImagePocoList = new List<ValidImagePoco>();
            foreach (string imageUrl in imageUrlList)
            {
                try
                {
                    ValidImagePoco validImagePoco = new ValidImagePoco();
                    Image image = DownloadImageFromUrl(imageUrl);
                    validImagePoco.Image = image;
                    string fileName = string.Concat(fileHeader, "_", (counter + 1).ToString(), ".jpg");
                    imageNameArray += "|" + fileName;
                    ImageHelper.Instance.DownloadAndSaveImageWithFullPath(directoryPath + @"\" + fileName, imageUrl);
                    validImagePocoList.Add(validImagePoco);
                    image.Dispose();
                }
                catch (Exception exc)
                {
                    Logger.Error("SaveValidImageList error", exc);
                }
                counter++;
            }

            return imageNameArray;
        }

        public bool isValidImageUrl(string imageUrl)
        {
            bool isValid = true;
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 10000;
                WebResponse webResponse = webRequest.GetResponse();
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        public Image CropImage(Image image, Rectangle cropArea)
        {
            Bitmap bitmap = new Bitmap(image);
            return bitmap.Clone(cropArea, bitmap.PixelFormat);
        }

        public Image RotateImage(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            }
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bitmap;
        }

        public Image Resize(Image image, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            if (onlyResizeIfWider && image.Width <= newWidth) newWidth = image.Width;
            var newHeight = image.Height * newWidth / image.Width;
            if (newHeight > maxHeight)
            {
                newWidth = image.Width * maxHeight / image.Height;
                newHeight = maxHeight;
            }

            var resizedImage = new Bitmap(newWidth, newHeight);
            using (var graphic = Graphics.FromImage(resizedImage))
            {
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;
                graphic.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

    }
}
