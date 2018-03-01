using Flexi.Shared.Log;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RestSharp.Serializers;
using System;
using System.IO;
using System.IO.Compression;

namespace Flexi.Shared.Helper
{
    public class FileHelper
    {
        private static readonly Lazy<FileHelper> lazy = new Lazy<FileHelper>(() => new FileHelper());
        public static FileHelper Instance { get { return lazy.Value; } }
        private FileHelper()
        {
        }

        public string WriteAllText(string rootElement, Object requestObject, string fullPath)
        {
            DotNetXmlSerializer serializer = new DotNetXmlSerializer();
            string xmlRequest = serializer.Serialize(requestObject);
            File.WriteAllText(fullPath, xmlRequest);
            return xmlRequest;
        }

        public void WriteToTextFile(string data, string fullPath)
        {
            string directoryName = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            File.WriteAllText(fullPath, data);
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void CropDocument(string file, string oldchar, string repChar)
        {
            int pageNumber = 1;
            PdfReader reader = new PdfReader(file);
            //PdfReaderContentParser parser = new PdfReaderContentParser(reader);
            iTextSharp.text.Rectangle size = new iTextSharp.text.Rectangle(30F, 330F, 318F, 770F);
            Document document = new Document(size);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(file.Replace(oldchar, repChar), FileMode.Create, FileAccess.Write));
            document.Open();
            PdfContentByte pdfContentByte = writer.DirectContent;
            document.NewPage();
            PdfImportedPage page = writer.GetImportedPage(reader, pageNumber);
            pdfContentByte.AddTemplate(page, 0, 0);
            document.Close();
        }

        public byte[] Decompress(byte[] gzip)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }

        public string ReadFile(string fullPath)
        {
            string result = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (Exception exc)
            {
                Logger.Error($"ReadFile error! fullPath: {fullPath}", exc);
            }
            return result;
        }

    }
}
