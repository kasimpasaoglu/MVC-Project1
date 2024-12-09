namespace DMO
{
    public class Student
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string Phone { get; set; }
        required public string CitizenshipId { get; set; }
        required public DateOnly BirthDate { get; set; }
        required public DateTime RegDate { get; set; }
        public Student(string name, string lastName, string email, string phone, string citizenshipId, DateOnly birthDate)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Phone = phone;
            CitizenshipId = citizenshipId;
            BirthDate = birthDate;
            RegDate = DateTime.Now;
        }
        public Student() { }
    }
}