
namespace SOLID.SRP
{
    public class RegisterServiceWithSRP
    {
        UserRepository userRepository;
        EmailService emailService;

        public RegisterServiceWithSRP()
        {
            userRepository = new UserRepository();
            emailService = new EmailService();

        }
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            userRepository.Insert(username);

            emailService.Send(username);
        }
    }
}
