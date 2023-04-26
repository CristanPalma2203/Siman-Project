using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.WinForm.Utils
{
    public abstract class ItemConverter
    {
        public static Image BinaryToImage(byte[] imageBytes)
        {//Convertir una matriz de bytes en imagen.
            using (MemoryStream tempStream = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {                
                tempStream.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(tempStream, true);
                return image;
            }
        }

        public static byte[] ImageToBinary(Image image)
        {//Convertir una imagen en una matriz de bytes.
            using (MemoryStream tempStream = new MemoryStream())
            {                
                image.Save(tempStream, ImageFormat.Png);
                tempStream.Seek(0, SeekOrigin.Begin);
                byte[] imageBytes = tempStream.ToArray();
                return imageBytes;
            }
        }
    }
}
