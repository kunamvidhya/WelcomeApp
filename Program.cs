// See https://aka.ms/new-console-template for more information
using WelcomeApp;

Console.WriteLine("Welcome to Authenticate App");
Signin obj = new Signin();
Console.WriteLine(Signin.Authenticate("admin", "admin12345"));
