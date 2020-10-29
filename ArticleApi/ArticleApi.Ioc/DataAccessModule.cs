using ArticleApi.DataAccess.Abstract;
using ArticleApi.DataAccess.Concrete;
using Autofac;

namespace ArticleApi.Ioc
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleDal>().As<IArticleDal>();
        }
    }
}