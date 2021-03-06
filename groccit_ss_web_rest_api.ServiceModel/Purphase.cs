﻿using data_soruce_mil.models;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groccit_ss_web_rest_api.ServiceModel
{
    [Route("/purphase", "POST")]
    public class Purphase: IReturn<PurphaseRespons>
    {
       public  TestPurchaseIntention testPurchase { get; set;}    }
    
    [Route("/purphase/", "GET")]
    public class PurphaseList: IReturn<List<PurphaseRespons>>
    {
        public List<TestPurchaseIntention> PurchaseIntentions { get; set; }
    }

    public class PurphaseRespons
    {
        public TestPurchaseIntention Resultat { get; set; }
        public List<TestPurchaseIntention> PurchaseIntentions { get; set;  }
    } 
}
