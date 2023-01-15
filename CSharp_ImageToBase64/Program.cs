using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ImageToBase64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = @"C:/Users/theka/OneDrive/Desktop/Screenshot.png";
            string imgBase64String = ImageToBase64(imagePath);
            Console.WriteLine(imgBase64String);
        }
        protected static string ImageToBase64(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
    }
}
