namespace MyWorkoutTracker_Base.Models
{
    public class MuscleGroup
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int CategoryID { get; private set; }

        public MuscleGroup(int id, string name, int catID)
        {
            ID = id;
            Name = name;
            CategoryID = catID;
        }
    }
}
