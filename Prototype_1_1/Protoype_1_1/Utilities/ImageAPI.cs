using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1_1.Utilities
{
    public static class ImageAPI
    {
        private const int _BYTESPERPIXEL = 4;
        private const double _OPACITY = 0.5;

        public static Image makeIconOpaque(Image originalImage)
        {
            if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed || originalImage == null)
            {
                return originalImage;
            }

            Bitmap bmp = (Bitmap)originalImage.Clone();
            PixelFormat pxf = PixelFormat.Format32bppArgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmp.Width * bmp.Height * _BYTESPERPIXEL;
            byte[] argbValues = new byte[numBytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);
            for (int counter = 0; counter < argbValues.Length; counter += _BYTESPERPIXEL)
            {
                if (argbValues[counter + _BYTESPERPIXEL - 1] == 0)
                    continue;

                int pos = 0;
                pos++; // B value
                pos++; // G value
                pos++; // R value

                argbValues[counter + pos] = (byte)(argbValues[counter + pos] * _OPACITY);
            }

            System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);
            bmp.UnlockBits(bmpData);

            return bmp;
        }

        public static Image makeIconOpaque(Image originalImage, double opacity)
        {
            if ((originalImage.PixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed || originalImage == null)
            {
                return originalImage;
            }

            Bitmap bmp = (Bitmap)originalImage.Clone();
            PixelFormat pxf = PixelFormat.Format32bppArgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmp.Width * bmp.Height * _BYTESPERPIXEL;
            byte[] argbValues = new byte[numBytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, numBytes);
            for (int counter = 0; counter < argbValues.Length; counter += _BYTESPERPIXEL)
            {
                if (argbValues[counter + _BYTESPERPIXEL - 1] == 0)
                    continue;

                int pos = 0;
                pos++; // B value
                pos++; // G value
                pos++; // R value

                argbValues[counter + pos] = (byte)(argbValues[counter + pos] * opacity);
            }

            System.Runtime.InteropServices.Marshal.Copy(argbValues, 0, ptr, numBytes);
            bmp.UnlockBits(bmpData);

            return bmp;
        }
    }
}
