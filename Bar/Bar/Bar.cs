using TradingPlatform.BusinessLayer;
using Singleton;

namespace Bar;

public sealed class Bar : Indicator
{
  public Bar()
  {
    Name = "Bar";
    Description = "Bar";
    SeparateWindow = false;
  }

  protected override void OnInit()
  {
    Core.Instance.Loggers.Log("Bar OnInit (shared)");
    SingletonManager.Get().Put("Bar");
    SingletonManager.Get().Print();
  }
}