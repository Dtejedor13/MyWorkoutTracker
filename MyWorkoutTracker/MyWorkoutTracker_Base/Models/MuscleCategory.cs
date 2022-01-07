namespace MyWorkoutTracker_Base.Models
{
    public class MuscleCategory
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public MuscleCategory(int id, string name)
        {
            Name = name;
            ID = id;
        }
    }
}
