using System;
using FubuMVC.Core;
using homolkam_FubuTODO.Features.Home;

namespace homolkam_FubuTODO
{
    public class HelloWorldRegistry : FubuRegistry
    {
        public HelloWorldRegistry()
        {
            Actions.FindBy(x =>
            {
                x.Applies.ToThisAssembly();
                x.IncludeClassesSuffixedWithController();
            });

            Routes.HomeIs<HomeInputModel>()
                .ConstrainToHttpMethod(x => x.Method.Name.Equals("Get", StringComparison.InvariantCultureIgnoreCase), "GET")
                .IgnoreControllerNamespaceEntirely(); //not needed for sample, but you will find it useful
        }
    }
}