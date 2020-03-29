using System;
using ServiceStack;
using data_soruce_mil.services;
namespace groccit_ss_web_rest_api.ServiceInterface
{
    public class GroccitUserService : Service
    {
        public UserService userService { get; set; }


        public object Any(groccit_ss_web_rest_api.ServiceModel.User response)
        {
            data_soruce_mil.models.User user = new data_soruce_mil.models.User();
            userService.CreateOrUpdate(user);


            return new groccit_ss_web_rest_api.ServiceModel.UserResponse { user = response.user.user }; 
        }
        
    }
}
