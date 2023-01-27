using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxForms.Core.ViewModels;
using System;

namespace MvxForms.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
