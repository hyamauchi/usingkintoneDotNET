using System;
using kintoneDotNET.API;
using kintoneDotNET.API.Types;

namespace usingkintoneDotNET
{
    public class BookModel : AbskintoneModel
    {
        public override string app
        {
            get
            {
                return "104";
            }
        }

        public string age { get; set; }
        public string job { get; set; }
        public string contact { get; set; }
        public string duration { get; set; }
        public string euribor3m { get; set; }
        public string nr_employed { get; set; }

    }
}
