namespace EFDataAccess.Models
{
    public class DBMuscleCategory : MyWorkoutTracker_Base.Interfaces.IMuscleCategory
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CreateUserID { get; set; }
        
        public DBMuscleCategory(int iD, string name, int createUserID)
        {
            ID = iD;
            Name = name;
            CreateUserID = createUserID;
        }
    }
}
