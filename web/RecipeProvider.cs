using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
  public class RecipeProvider
  {
    public Tag[] GetTags()
    {
      var client = new ElasticLowLevelClient();
      return new Tag[0];
    }
  }
}
