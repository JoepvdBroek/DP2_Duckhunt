namespace Duckhunt
{

    class Unit
    {
        private float x;
        private float y;
        private int direction;
        private float heading;
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public float Heading
        {
            get { return heading; }
            set { heading = value; }
        }

    }
}