using MyWorkoutTracker_Base.Interfaces;

namespace MyWorkoutTracker_Base.Models
{
    /// <summary>
    /// Muskel Gruppe
    /// </summary>
    public class MuscleGroup : IMuscleGroup
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

        public MuscleGroup(IMuscleGroup dbModel)
        {
            ID = dbModel.ID;
            Name = dbModel.Name;
            CategoryID = dbModel.CategoryID;
        }
    }
}
