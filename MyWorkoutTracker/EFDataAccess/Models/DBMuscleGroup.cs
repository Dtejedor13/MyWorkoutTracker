namespace EFDataAccess.Models
{
    class DBMuscleGroup : MyWorkoutTracker_Base.Interfaces.IMuscleGroup
    {
        public int CategoryID { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public int CreateUserID { get; set; }
    }
}
