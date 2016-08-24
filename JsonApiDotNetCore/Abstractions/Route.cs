using System;

namespace JsonApiDotNetCore.Abstractions
{
  public class Route
  {
    public Type ModelType { get; set; }
    public string PathString { get; set; }
    public string ContextPropertyName { get; set; }
  }
}