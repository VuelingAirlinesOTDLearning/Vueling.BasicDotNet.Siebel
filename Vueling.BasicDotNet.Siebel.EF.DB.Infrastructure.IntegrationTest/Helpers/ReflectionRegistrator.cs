﻿using System.Diagnostics;
using Autofac;
using Vueling.DIRegister.Custom.ServiceLibrary;

namespace Vueling.XXX.EF.DB.Infrastructure.IntegrationTest.Helpers
{
    public class ReflectionRegistrator : DICustom
    {
        protected override void CustomDependenciesRegister(ContainerBuilder builder)
        {
            Trace.TraceInformation("Execute override of CustomDependenciesRegister.");
        }

        protected override void ResolveAfterBuildContainer(IContainer container)
        {
            Trace.TraceInformation("Execute override of ResolveAfterBuildContainer.");

            _Container = container;
        }

        IContainer _Container;
        public IContainer Container { get { return _Container; } }
    }

}