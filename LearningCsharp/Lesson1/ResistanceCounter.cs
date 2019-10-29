namespace LearningCsharp.Lesson1
{
    public class ResistanceCounter
    {
        public double CountResistance(double R1, double R2, double R3)
        {
            return 1 / (1 / R1 + 1 / R2 + 1 / R3);
        }
    }
}
