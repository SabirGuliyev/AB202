namespace MVCFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            //app.MapControllerRoute(
            //   name: "test",
            //   pattern: "{controller}/{action=detail}/{id?}"


            //   );

            //app.MapControllerRoute(
            //    "Corporative",
            //    pattern:"korporativ-satislar",
            //    defaults:new {controller= "CorporativeSales",action="index" }

            //    );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}"


                );

            app.Run();
        }
    }
}