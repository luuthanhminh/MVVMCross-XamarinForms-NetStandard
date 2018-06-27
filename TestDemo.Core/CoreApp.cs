using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestDemo.Core.ViewModels;

namespace TestDemo.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TestViewModel>();
        }

        /// <summary>
        /// Do any UI bound startup actions here
        /// </summary>
        public override void Startup()
        {
            base.Startup();
        }

        /// <summary>
        /// If the application is restarted (eg primary activity on Android 
        /// can be restarted) this method will be called before Startup
        /// is called again
        /// </summary>
        public override void Reset()
        {
            base.Reset();
        }
    }
}
