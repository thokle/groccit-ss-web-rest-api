using data_soruce_mil.models;
using groccit_ss_web_rest_api.ServiceModel;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groccit_ss_web_rest_api.ServiceInterface
{
    public class PurphaseService : Service
    {
        public data_soruce_mil.services.ITestPurhaseIntentionService testPurhase { get; set; }

       
        
        public object Any(Purphase purphase)
        {
            var testpurphaoe = (data_soruce_mil.models.TestPurchaseIntention)purphase.testPurchase;eld 

          var res =   testPurhase.CreateTestPurchaseIntention(testpurphaoe);
           
        
            return new PurphaseRespons { Resultat = purphase.testPurchase};
        }

        public object Get(PurphaseList purphase)
        {
            
            return new PurphaseRespons { PurchaseIntentions = testPurhase.GetTestPurchaseIntentions() };
        }
    }
}
