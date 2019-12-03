using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using TeduShop.Data;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Service;

[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.Startup))]

namespace TeduShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            //appbuilder cho phép khởi tạo nhiều vấn đề khi chạy ứng dụng
            ConfigAutofac(app);

        }
        public void ConfigAutofac(IAppBuilder app)
        {
            //khởi tạo builder để register các DI
            ContainerBuilder builder = new ContainerBuilder();
            //register cho controller
            //InstancePerRequest tức là mỗi session(phiên làm việc) thì nó sẽ tự động khởi tạo
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //register dbcontext
            builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();

            #region Add DI
            // services
            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(ErrorService).Assembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
            //repository
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(ErrorRepository).Assembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            //dùng autofac tạo ra container(thùng chứa) để chứa các register trên
            Autofac.IContainer container = builder.Build();
            //thay thế auto của autofac thành các register 
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //config cho cả web api
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            #endregion


        }
    }
}
