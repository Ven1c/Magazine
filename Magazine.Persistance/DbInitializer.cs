namespace Magazine.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(MagazineDbContext context)
        {
            context.Database.EnsureCreated();
        }

    }
}