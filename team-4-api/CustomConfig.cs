using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace team_4_api
{
    public class CustomConfig
    {
        public const string SectionKey = "Hackathon:CustomConfig";
        public string Environment { get; set; }
    }
}
