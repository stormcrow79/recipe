using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
  public class Tag
  {
    public string Name;
    public int? Value;
  }
  public class Recipe
  {
    public string Id;
    public string Source;
    public string Name;
    public int Page;
    public int Points;
    public string[] Tags;
    public string Meal;
    public int? Rating;
  }

  public class RecipeIndexView
  {
    public Tag[] Tag;
    public Recipe[] Recipe;
  }
}
