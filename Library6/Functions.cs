namespace Library6
{
    public static class Functions
    {
        public static double GradusToRadian(double gradus)
        {
            double radian = 0;
            radian = 150 / gradus;
            return radian;
        }

        public static double AToB(double a, double b)
        {
            double range = b - a;
            return range;

        }

        public static double Azimut(double gradus)
        {
            double azim = 350 - gradus;
            return azim;
        }

        public static double ConvertToMili(double x)
        {
            return x * 1.11;
        }
        public static double ConvertToKm(double x)
        {
            return x / 1.11;
        }
        public static double ConvertToFoot(double x)
        {
            return x * 3.33;
        }
        public static double ConvertToMetr(double x)
        {
            return x / 3.33;
        }
        public static double ConvertToAkr(double x)
        {
            return x * 2.22;
        }
        public static double ConvertToGektar(double x)
        {
            return x / 2.22;
        }
    }
}
