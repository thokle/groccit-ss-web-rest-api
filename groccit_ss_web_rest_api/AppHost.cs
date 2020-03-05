using Funq;
using ServiceStack;
using groccit_ss_web_rest_api.ServiceInterface;

namespace groccit_ss_web_rest_api
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("groccit_ss_web_rest_api", typeof(MyServices).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            var cors = new CorsFeature();
           
            this.Plugins.Add(cors);
        }
    }
}