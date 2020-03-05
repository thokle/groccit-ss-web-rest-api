using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groccit_ss_web_rest_api.ServiceModel
{
    [Route("/calculator/{a}/{b}")]
 public   class Calculator : IReturn<CalculatorResponse>
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public class CalculatorResponse
    {
       public int Resultat { get; set; }
     
    }
}
