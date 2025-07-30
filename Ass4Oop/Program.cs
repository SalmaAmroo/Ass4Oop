namespace Ass4Oop
{
    #region Q1 
    //interface IShape 
    //{
    //    public double Area { get; }
    //    public void DisplayShapeInfo();
    //};

    //interface ICircle : IShape
    //{
    //    public double Raduis { get; set; }
    //};

    //interface IRectangle : IShape
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }
    //};
    //class Circle : ICircle , IShape
    //{
    //    double area;
    //    public double Area
    //    {
    //        get { return 3.14 * Raduis * Raduis; }
    //    }
    //  public double Raduis { get; set; }

    //  public void DisplayShapeInfo()
    //  {
    //        Console.WriteLine($"Circle with Radius: {Raduis} and Area: {Area}");
    //  }

    //}
    //class Rectangle : IRectangle, IShape
    //{
    //    double area;
    //   public double Length { get; set; }
    //   public double Width { get; set; }

    //    public double Area
    //    {
    //        get { return Length * Width; }
    //    }
    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width} and Area: {Area}");
    //    }

    //}
    #endregion

    #region Q2
    //interface IAuthenticationService
    //{
    //    public bool AuthenticateUser(string UserName, string password);
    //    public bool AuthorizeUser(string UserName , string Role);
    //}

    //class BasicAuthenticationService : IAuthenticationService
    //{
    //    public bool AuthenticateUser(string UserName, string password)
    //    {
    //        if (UserName == "Salma Amro" && password=="Salma_2004")
    //            return true;
    //        else            
    //            return false;
    //    }
    //    public bool AuthorizeUser(string UserName, string Role)
    //    {
    //        if (UserName == "Salma Amro" && Role == "Admin")
    //            return true;
    //        else
    //            return false;
    //    }

    //}
    #endregion

    #region Q3
    //interface INotificationService
    //{
    //    public void SendNotification(string Message ,string Recipient);
    //}
    //class EmailNotificationService: INotificationService
    //{
    //    public void SendNotification(string Message, string Recipient)
    //    {
    //        Console.WriteLine($"Email sent to {Recipient} with message: {Message}");
    //    }
    //}
        
    //class SmsNotificationService : INotificationService
    //{
    //    public void SendNotification(string Message, string Recipient)
    //    {
    //        Console.WriteLine($"SMS sent to {Recipient} with message: {Message}");
    //    }
    //}
    //class PushNotificationService: INotificationService
    //{
    //    public void SendNotification(string Message, string Recipient)
    //    {
    //        Console.WriteLine($"Push sent to {Recipient} with message: {Message}");
    //    }
    //}
    #endregion
    class Program
    {
     
        static void Main(string[] args)
        {
            #region CallQ1
            //Console.WriteLine("The Area Of Circle");
            //Circle C1 = new Circle();
            //C1.Raduis = 5;
            //C1.DisplayShapeInfo();
            //Console.WriteLine("The Area Of Rectangle");
            //Rectangle R1 = new Rectangle();
            //R1.Length = 6;
            //R1.Width = 12;
            //R1.DisplayShapeInfo();
            #endregion

            #region CallQ2
            //IAuthenticationService authService = new BasicAuthenticationService();
            //Console.WriteLine("Enter UserName and Password to Authenticate:");
            //Console.Write("UserName: ");
            //string? userName = Console.ReadLine();
            //Console.Write("Password: ");
            //string? password = Console.ReadLine();
            //Console.WriteLine("Authentication Result: ");
            //Console.WriteLine(authService.AuthenticateUser(userName, password));
            //Console.WriteLine("Enter UserName and Role to Authorize:");
            //Console.Write("UserName: ");
            //string? UserName = Console.ReadLine();
            //Console.Write("Role: ");
            //string? role = Console.ReadLine();
            //Console.WriteLine("Authorization Result: ");
            //Console.WriteLine(authService.AuthorizeUser(UserName, role));
            #endregion

            #region CallQ3
            //EmailNotificationService s1 = new EmailNotificationService();
            //s1.SendNotification("Hello Eng.Salma ","Salma");
            //SmsNotificationService s2 = new SmsNotificationService();
            //s2.SendNotification("Hello Eng.Karim How are you :D !!", "Karim");
            //PushNotificationService s3 = new PushNotificationService();
            //s3.SendNotification("Hello Eng.Hoda ", "Hoda");
            #endregion
        }
    }
}
