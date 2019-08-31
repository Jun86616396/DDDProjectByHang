using Autofac;
using System;
using Autofac.Builder;
using AutoMapper;
using DDD.Application.AutoMapper;
using DDD.Application.Interfaces;
using DDD.Application.Services;
using DDD.Domain.Bus;
using DDD.Domain.CommandHandlers;
using DDD.Domain.Commands.User;
using DDD.Domain.DomainServices;
using DDD.Domain.Evens.User;
using DDD.Domain.EventHandlers;
using DDD.Domain.Interfaces;
using DDD.Domain.Notifications;
using DDD.Domain.Repository;
using Infra.EF;
using Infra.EF.Bus;
using Infra.EF.Contexts;
using Infra.EF.DomainServices;
using IContainer = Autofac.IContainer;
   
using Infra.EF.Repository;
using MediatR;

// ReSharper disable IdentifierTypo

namespace Infra.IoC.AutoFac
{
    public class AutofacContainer
    {

        private readonly IContainer container;

        //单例对象
        private static volatile AutofacContainer _aufacContainer = null;//volatile 促进线程安全 让线程按顺序操作
        //锁对象
        private static readonly object SingletonLock = new object();
       
        //获取实例
        public static AutofacContainer GetInstance()
        {
            //if (_aufacContainer == null)
            //{
            //    //使用原子操作方式实现单例模式，解决了多线程问题与双重判断加锁的代码多问题
            //    Interlocked.CompareExchange<AutofacContainer>(ref _aufacContainer, new AutofacContainer(), null);
            //}

            //container.BeginLifetimeScope()

            if (_aufacContainer == null)
            {
                lock (SingletonLock)//保证只有一个线程进去判断+初始化
                {
                    if (_aufacContainer == null)
                    {
                        _aufacContainer = new AutofacContainer();
                    }
                }
            }
            
            return _aufacContainer;
        }

        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private AutofacContainer() => container = BuildAutofacContainer();
       

        private IContainer BuildAutofacContainer()
        {
            try
            {
                //创建容器
                var builder = new ContainerBuilder();

                //注册
                RegisterTypes(builder);

                var container = builder.Build(ContainerBuildOptions.None);

                return container;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //注册需要依赖注入的类型
        private static void RegisterTypes(ContainerBuilder builder)
        {
            // 注入 基础设施层 - 数据层
            //-上下文
            builder.RegisterType<ManageContext>().InstancePerLifetimeScope();
            builder.RegisterType<GwContext>().InstancePerLifetimeScope();

            //注册工作单元
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork2>().As<IUnitOfWork2>().InstancePerLifetimeScope();
            //builder.RegisterType<UnitOfWorkTwo>().Named<IUnitOfWork>("two").InstancePerLifetimeScope();

            //注册仓储
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RightRepository>().As<IRightRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRoleRepository>().As<IUserRoleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoleRightRepository>().As<IRoleRightRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DayFinishedRepository>().As<IDayFinishedRepository>().InstancePerLifetimeScope(); 
            builder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AssembleRepository>().As<IAssembleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OrderBoxRepository>().As<IOrderBoxRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CollectionRepository>().As<ICollectionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OpwayDataRepository>().As<IOpwayDataRepository>().InstancePerLifetimeScope();
            builder.RegisterType<StorageRepository>().As<IStorageRepository>().InstancePerLifetimeScope();

            //注册领域服务
            builder.RegisterType<CollectionVerifyService>().As<ICollectionVerifyService>().InstancePerLifetimeScope();
            builder.RegisterType<AssembleVerifyService>().As<IAssembleVerifyService>().InstancePerLifetimeScope();
            builder.RegisterType<StorageVerifyService>().As<IStorageVerifyService>().InstancePerLifetimeScope();

            //注册领域命令处理
            builder.RegisterType<UserCommandHandler>().As<IRequestHandler<RegisterUserCommand, Unit>>().InstancePerLifetimeScope();

            //领域通知处理
            builder.RegisterType<DomainNotificationHandler>().As<INotificationHandler<DomainNotification>>().InstancePerLifetimeScope();

            //领域事件处理
            builder.RegisterType<UserEventHandler>().As<INotificationHandler<UerRegisteredEvent>>().InstancePerLifetimeScope();

            //注册命令总线Domain Bus
            builder.RegisterType<InMemoryBus>().As<IMediatorHandler>().InstancePerLifetimeScope();

            //注册MediatR
            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            // request & notification handlers
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });


            // 注册 应用层Application
            builder.RegisterType<UserService>().As< IUserService > ().InstancePerLifetimeScope();
            builder.RegisterType<RoleService>().As<IRoleService>().InstancePerLifetimeScope();
            builder.RegisterType<RightService>().As<IRightService>().InstancePerLifetimeScope();
            //builder.RegisterType<RoleRightService>().As<IRoleRightService>().InstancePerLifetimeScope();
            builder.RegisterType<DayFinishedService>().As<IDayFinishedService>().InstancePerLifetimeScope();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
            builder.RegisterType<AssembleService>().As<IAssembleService>().InstancePerLifetimeScope();
            builder.RegisterType<OrderBoxService>().As<IOrderBoxService>().InstancePerLifetimeScope();
            builder.RegisterType<CollectionService>().As<ICollectionService>().InstancePerLifetimeScope();
            builder.RegisterType<OpwayDataService>().As<IOpwayDataService>().InstancePerLifetimeScope();
            builder.RegisterType<StorageService>().As<IStorageService>().InstancePerLifetimeScope();
            builder.RegisterType<GatherSearchService>().As<IGatherSearchService>().InstancePerLifetimeScope();
            //注册  autoMapper
            builder.Register(c =>  AutoMapperConfig.RegisterMappings()).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>()
                    .CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
            

        }

       


        #region 兼容EF和ADO.NET
        public T GetObject<T>() => container.Resolve<T>();
        public T GetObject<T>(string name) => container.ResolveNamed<T>(name);
        //public T GetObject<T>(string name) => container.ResolveOptionalNamed<T>(name);
        
        #endregion
    }
}


