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
        public int FrameCount => BitmapFrames.Length;

        public Bitmap FirstFrame
            => BitmapFrames[0];

        public Bitmap GetFrame(int id)
            => BitmapFrames[id];

        public void SetFrame(int id, Bitmap bmp)
            => BitmapFrames[id] = bmp;
    }
}
