using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibanaJsonQuery.Model
{
    
    public class Bool
    {
        public List<Should> should { get; set; }
        public int minimum_should_match { get; set; }
    }

    public class MatchPhrase
    {
        public string Id { get; set; }
    }

    public class Query
    {
        public Bool @bool { get; set; }
    }

    public class Root
    {
        public Query query { get; set; }
    }

    public class Should
    {
        public MatchPhrase match_phrase { get; set; }
    }


}
