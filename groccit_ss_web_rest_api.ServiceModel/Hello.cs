using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace groccit_ss_web_rest_api.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
   
}