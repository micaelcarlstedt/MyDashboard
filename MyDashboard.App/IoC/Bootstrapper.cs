using MetroIoc;

namespace MyDashboard.App.IoC
{
    internal class Bootstrapper
    {
        internal static IContainer BuildContainer()
        {
            var container = new MetroContainer();

            container.RegisterInstance(container);

            //TODO: Register interfaces

            return container;
        }
    }
}