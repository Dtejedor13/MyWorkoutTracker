using MyWorkoutTracker_Base.Interfaces;

namespace MyWorkoutTracker_Base.Models
{
    /// <summary>
    /// Muskel Obergruppe
    /// </summary>
    public class MuscleCategory : IMuscleCategory
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public MuscleCategory(int id, string name)
        {
            Name = name;
            ID = id;
        }

        public MuscleCategory(IMuscleCategory dbModel)
        {
            Name = dbModel.Name;
            ID = dbModel.ID;
        }
    }
}
