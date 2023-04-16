// See https://aka.ms/new-console-template for more information

using BridgePattern;
using BuilderPattern;
using DecoratorPattern;
using FactoryPattern;
using FactoryPattern.SimpleFactory;
using ProxyPattern;
using SingletonPattern;

// Singleton pattern
Console.WriteLine(LazyIdGen.GetInstance().GetId());

// Factory pattern
CacheConfigParserFactory simpleFactory = new CacheConfigParserFactory();
ICacheConfigurationParser parser1 = simpleFactory.createParser("JSON");
parser1.Load("1.json");
Console.WriteLine(parser1.GetSection("ConnStr"));

// Builder pattern
ResourcePoolConfig resourcePoolConfig = new ResourcePoolConfigBuilder()
                                            .SetName("test")
                                            .SetMaxTotal(10)
                                            .SetMaxIdel(2)
                                            .SetMinIdel(1)
                                            .Build();
Console.WriteLine(resourcePoolConfig);

// Proxy pattern
UserController userController = new UserControllerProxy(MetricUtils.getInstance());
userController.login("tying", "123");

// Bridge pattern
IWeapon weapon = new Sword(new FlyingEnchantment());
weapon.Wield();

// Decorator
MyFileStream myFileStream = new MyFileStream();
MyBufferedStream myBufferedStream = new MyBufferedStream(myFileStream);
myBufferedStream.Write(new byte[] { 0, 1 }, 0, 2);
