using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using MeiLian.EntityFramework;

namespace MeiLian.Migrator
{
    [DependsOn(typeof(MeiLianDataModule))]
    public class MeiLianMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MeiLianDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
