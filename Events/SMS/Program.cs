using System;

class Program
{
    static void Main()
    {
        var registerUser = new RegisterUser();
        var emailVerification = new EmailVerification();
        var smsVerification = new SMSVerification();
        registerUser.registerUserDelegateInstance += emailVerification.OnUserRegistered;
        registerUser.registerUserDelegateInstance += smsVerification.OnUserRegistered;
        registerUser.RegisterAUser(); // Call delegate  
        Console.ReadLine();
    }
}
public class RegisterUser
{
    public delegate void registerUserDelegate(); // declare a delegate  
    public registerUserDelegate registerUserDelegateInstance; // create a delegate instance  
    public void RegisterAUser()
    {
        Console.WriteLine("User registered");
        if (registerUserDelegateInstance != null)
        {
            registerUserDelegateInstance(); // Call the delegate  
        }
    }
}
public class EmailVerification
{
    public void OnUserRegistered()
    {
        Console.WriteLine("Sent Email for Verification");
    }
}
public class SMSVerification
{
    public void OnUserRegistered()
    {
        Console.WriteLine("Sent SMS for Verification");
    }
}