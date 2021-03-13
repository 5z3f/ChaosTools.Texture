using System.Drawing;

namespace ChaosTools.Texture
{
    public class CTexture
    {
        public Bitmap[] BitmapFrames;
        public int Width, Height;
        public string Format, PixelFormat;

        public bool IsTexture;
        public bool IsAnimated;

        public int FrameDuration;
        public int FrameCount;
    }
}
