namespace VM
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CitizenshipId { get; set; }
        public DateOnly BirthDate { get; set; }
        public bool IsAdded { get; set; }
        // public User User { get; set; }
    }
    //     public class User
    //     {
    //         public bool IsLoggedIn { get; set; }
    //         public bool IsAdmin { get; set; }
    //     }
}