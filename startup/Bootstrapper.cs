using Autofac;
using DressMakerPol.ViewModel;

namespace DressMakerPol.startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            
            return builder.Build();
        }
    }
}
