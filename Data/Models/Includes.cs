using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace twitter_showcase_app.Data.Models
{

    public class TwitterResponse
    {

        public List<Includes> Includes { get; set; }
    }

    public class Includes
    {


        public List<TwitterUsers> Users { get; set; }

    }

}


