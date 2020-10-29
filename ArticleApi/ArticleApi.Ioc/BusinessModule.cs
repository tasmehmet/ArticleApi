using ArticleApi.Business.Abstract;
using ArticleApi.Business.Concrete;
using Autofac;

namespace ArticleApi.Ioc
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleManager>().As<IArticleService>();
        }
    }
}