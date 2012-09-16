using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroIoc;

namespace MyDashboard.App.IoC
{
    internal class ViewModelLocator
    {
        private Lazy<IContainer> _container;

        public ViewModelLocator()
        {
            _container = new Lazy<IContainer>(Bootstrapper.BuildContainer);
        }

        IContainer Container
        {
            get { return _container.Value; }
        }
    }
}
