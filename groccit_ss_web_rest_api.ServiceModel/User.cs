using System;
using ServiceStack;
using data_soruce_mil.models;
namespace groccit_ss_web_rest_api.ServiceModel
{
    [Route("/user", "POST")]
    public class User: IReturn<UserResponse>
    {
      public UserResponse user { get; set; }

        
    }
    [Route("/user/{token}")]
    public class GetUser : IReturn<UserResponse>
    {
        public string token { get; set; }
        public UserResponse userResponse { get; set; }
    }

    public class UserResponse
    {
       public User user { get; set; }
    }
}
