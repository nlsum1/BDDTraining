namespace BDDTraining
{
    public class Registration
    {
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Result { get; set; }

        public IAccount account { get; set; }

        public void Register()
        {

            if (account.IsValid())
            {
                Result = "Registration successfuly";
            }
        }

    }
}