using FubuMVC.Core;

namespace homolkam_FubuTODO
{
    public class HelloWorldRegistry : FubuRegistry
    {
        public HelloWorldRegistry()
        {
            FubuMode.Mode("Development");
        }
    }
}