namespace Orders.Api.Services
{
    public class AuthService
    {
        public List<string> Users { get; private set; }

        public AuthService()
        {
            Users = new List<string>
            {
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor"
            };
        }

        public bool? Login(string lastName)
        {
            var result = false;

            if (string.IsNullOrEmpty(lastName))
            {
                return false;
            }

            if (Users.Contains(lastName))
            {
                result =  true;
            }

            return result;
        }
    }
}
