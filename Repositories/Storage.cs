using ElectronicsStore.Controllers;

namespace ElectronicsStore.Repositories
{
    public class Storage
    {
        public static readonly OrderStorage OrderStorage = new();
        public static readonly BatchStorage BatchStorage = new();
    }
}
