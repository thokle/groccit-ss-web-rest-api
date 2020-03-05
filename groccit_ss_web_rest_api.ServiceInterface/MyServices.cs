using ServiceStack;
using groccit_ss_web_rest_api.ServiceModel;

namespace groccit_ss_web_rest_api.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}