namespace ClassBoxData
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get => _length; 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        ($"{nameof(Length)} cannot be zero or negative.");
                }
                _length = value;
            }
        }
        public double Width 
        {
            get => _width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        ($"{nameof(Width)} cannot be zero or negative.");
                }
                _width = value;
            }
        }
        public double Height 
        {
            get => _height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException
                        ($"{nameof(Height)} cannot be zero or negative.");
                }
                _height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height + 2 * this.Width * this.Length;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }

        public override string ToString()
        {
            return $"Surface Area - {SurfaceArea() :f2}" +
                $"\r\nLateral Surface Area - {LateralSurfaceArea():f2}" +
                $"\r\nVolume - {Volume():f2}\r\n";
        }

    }
}
