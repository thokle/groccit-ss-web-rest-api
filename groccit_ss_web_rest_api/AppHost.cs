using Funq;
using ServiceStack;
using groccit_ss_web_rest_api.ServiceInterface;
using ServiceStack.Api.Swagger;

namespace groccit_ss_web_rest_api
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("groccit_ss_web_rest_api", typeof(MyServices).Assembly){ }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
           // container.Register(i => new data_soruce_mil.services.TestPurhaseIntentionService()).ReusedWithin(ReuseScope.Default);
            Plugins.Add(new SwaggerFeature());
            container.Register<data_soruce_mil.services.ITestPurhaseIntentionService>(i => new data_soruce_mil.services.TestPurhaseIntentionService()).ReusedWithin(ReuseScope.Request);
            Plugins.Add(new CorsFeature(
    allowOriginWhitelist: new[] { "http://localhost", "http://localhost:5000", "http://run.plnkr.co" , "http://localhost:3000", "https://www.groccit-beta.com"},
    allowCredentials: true,
    allowedHeaders: "Content-Type, Allow, Authorization, X-Args"));
        }
    }
}