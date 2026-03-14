using Autofac;
using NimblePros.WebinarDemo.Core.Interfaces;
using NimblePros.WebinarDemo.Core.Services;

namespace NimblePros.WebinarDemo.Core;

/// <summary>
/// An Autofac module that is responsible for wiring up services defined in the Core project.
/// </summary>
public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();
  }
}
