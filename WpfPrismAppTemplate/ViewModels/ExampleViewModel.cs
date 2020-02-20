using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPrismAppTemplate.ViewModels
{
    public class ExampleViewModel : BindableBase
    {
        public ReactivePropertySlim<string> Head { get; }

        public ExampleViewModel()
        {
            Head = new ReactivePropertySlim<string>("WpfPrismApp");
        }
    }
}
