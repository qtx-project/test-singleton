// Copyright QUANTOWER LLC. © 2017-2023. All rights reserved.

using Singleton;
using TradingPlatform.BusinessLayer;

namespace Foo;

public sealed class Foo : Indicator
{
  public Foo()
  {
    Name = "Foo";
    Description = "Foo";
    SeparateWindow = false;
  }

  protected override void OnInit()
  {
    Core.Instance.Loggers.Log("Foo OnInit (shared)");
    SingletonManager.Get().Put("Foo");
    SingletonManager.Get().Print();
  }
}