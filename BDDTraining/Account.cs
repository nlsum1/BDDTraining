namespace BDDTraining
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }



        public bool IsValid()
        {
            return false;
        }
    }

    public interface IAccount
    {
        bool IsValid();
    }
}