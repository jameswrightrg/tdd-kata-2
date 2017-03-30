namespace tddkata
{
    public class Cylinder : IShape
    {
        private int v1;
        private int v2;

        public Cylinder(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double GetVolume()
        {
            return 0;
        }
    }
}