using groccit_ss_web_rest_api.ServiceInterface;
using groccit_ss_web_rest_api.ServiceModel;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groccit_ss_web_rest_api
{
    public class CalculatorService : Service
    {
        public object Any(Calculator calculator)
        {

            return new CalculatorResponse { Resultat = calculator.a + calculator.b  };
        }
    }
}