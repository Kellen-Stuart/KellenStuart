using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace KellenStuart.Shared
{
    public class Base : ComponentBase
    {
        public static Dictionary<string, string> Urls { get; set; }

        public Base()
        {
            Urls = new Dictionary<string, string>();
            Urls["WSCU"] = "https://western.edu/";
            Urls["CompTIASecurityPlus"] = "https://www.comptia.org/certifications/security";
            Urls["LockheedMartin"] = "https://www.lockheedmartin.com/en-us/index.html";
            Urls["JohnPetersonObituary"] = "https://archive.gunnisontimes.com/obituaries/john-peterson";
            Urls["HaskellReport"] = "https://www.haskell.org/onlinereport/";
            Urls["GentleIntroductionToHaskell"] = "https://www.haskell.org/tutorial/";
            Urls["YampaLibrary"] = "https://hackage.haskell.org/package/Yampa";
            Urls["Home"] = "https://kellenstuart.com";
            Urls["Resume"] = "https://kellenstuart.com/resume";
            Urls["Calendly"] = "https://calendly.com/kellenstuart/phone-call";
        }
    }
}