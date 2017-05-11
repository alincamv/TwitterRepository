using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac.Integration;
using System.Reflection;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Autofac;
using BusinessLayer;
using BusinessLayer.Interfaces;
using DaoHelper;
using DaoHelper.Interfaces;
using DAO;
using DAO.Interfaces;
using Models;




namespace TwitterRepository
{
    public class DependencyInjectionConfig
    {
        public static void DependecyInjectionConfiguration()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterType<UserDao>().As<IUserDao>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<TweetDao>().As<ITweetDao>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<TweetManager>().As<ITweetManager>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<UserManager>().As<IUserManager>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<ConvertData>().As<IConvertData>().SingleInstance().PropertiesAutowired();
            builder.RegisterType<PasswordEncryption>().As<IPasswordEncryption>().SingleInstance().PropertiesAutowired();
          

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}