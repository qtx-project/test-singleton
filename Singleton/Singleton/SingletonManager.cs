using System.Collections.Generic;
using TradingPlatform.BusinessLayer;

namespace Singleton;

public sealed class SingletonManager {
  private static SingletonManager _instance;
  private readonly List<string> _test;
  private int c ;
  public SingletonManager() {
    _test = [];
  }

  public void Put(string v) {
    _test.Add(v);
  }

  public void Print() {
    Core.Instance.Loggers.Log("==========================");
    Core.Instance.Loggers.Log($"- call singleton n {++c}");

    foreach (var v in _test) {
      Core.Instance.Loggers.Log($"has {v} (shared)");
    }
  }

  public static SingletonManager Get() {
    if (_instance == null) {
      _instance = new SingletonManager();
    }

    return _instance;
  }
}