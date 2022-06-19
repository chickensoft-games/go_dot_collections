using Godot;
using GoDotCollections;
using GoDotTest;
using Shouldly;

// GoDotTest uses Map, so it creates a circular dependency warning we can
// safely ignore.
#pragma warning disable CS0436

internal class MapTest : TestClass {
  public MapTest(Node testScene) : base(testScene) { }

  [Test]
  public void Initializes()
    => new Map<string, string>().ShouldBeOfType<Map<string, string>>();
}

#pragma warning restore CS0436
