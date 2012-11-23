using System;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace homolkam_FubuTODO
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication.For<HelloWorldRegistry>()
                .StructureMap(new Container())
                .Bootstrap();
        }
    }
}