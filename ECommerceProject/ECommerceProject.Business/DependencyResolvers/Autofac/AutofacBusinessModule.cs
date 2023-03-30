using Autofac;
using ECommerceProject.Business.Abstract;
using ECommerceProject.Business.Concrete;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CustomerManager>().As<ICustomerService>();

			builder.RegisterType<OrderManager>().As<IOrderService>();

			builder.RegisterType<ProductManager>().As<IProductService>();

			builder.RegisterType<ProductPictureManager>().As<IProductPictureService>();



			builder.RegisterType<CustomerRepo>().As<ICustomerRepo>();

			builder.RegisterType<OrderRepo>().As<IOrderRepo>();

			builder.RegisterType<ProductRepo>().As<IProductRepo>();

			builder.RegisterType<ProductPictureRepo>().As<IProductPictureRepo>();

			

		}
	}
}
