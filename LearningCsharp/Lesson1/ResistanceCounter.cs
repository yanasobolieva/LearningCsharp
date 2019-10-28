
namespace LearningCsharp.Lesson1{
    public class ResistanceCounter
    {
        public double Resistance1 { get; private set; }
        public double Resistance2 { get; private set; }
        public double Resistance3 { get; private set; }

        public ResistanceCounter(double R1, double R2, double R3)
        {
            Resistance1 = R1;
            Resistance2 = R2;
            Resistance3 = R3;
        }

        public double CountResistance0()
        {
            double R0 = 1 / (1 / Resistance1 + 1 / Resistance2 + 1 / Resistance3);
            return R0;
        }
    }
}
