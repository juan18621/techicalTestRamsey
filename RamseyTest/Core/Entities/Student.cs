namespace RamseyTest.Core.Entities
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Career { get; set; }

    }
}
