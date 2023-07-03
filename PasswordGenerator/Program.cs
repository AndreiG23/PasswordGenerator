using PasswordGenerator.Implementation;
internal class Program
{
    private static void Main(string[] args)
    {
        string userId = "user123";
        DateTime dateTime = DateTime.Now;
        string otp = OTPGenerator.GenerateOneTimePassword(userId, dateTime);

        Console.WriteLine("Generated one-time password: " + otp);

        bool isValid = OTPGenerator.IsPasswordValid(otp, dateTime);

        Console.WriteLine("Is password valid? " + isValid);
    }
}