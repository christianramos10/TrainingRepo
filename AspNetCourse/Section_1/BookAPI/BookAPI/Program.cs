namespace BookAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creating the builder
            var builder = WebApplication.CreateBuilder(args);

            //Attach services and functionalities
            builder.Services.AddControllers(); //A way of telling the application that we have created and/or want to use controllers.

            //Build an application
            var app = builder.Build();

            //Add mapping
            app.MapControllers();

            //Redirecting default page
            app.MapGet("/", () =>
            {
                return Results.Redirect("api/books");
            });

            //Start the application
            app.Run();
        }
    }
}
