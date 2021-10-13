namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; } // must use Pascal Case for this because it will cause less refactoring with Identity
    }
}