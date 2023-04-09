// See https://aka.ms/new-console-template for more information

using BuilderPattern;
using FactoryPattern;
using FactoryPattern.SimpleFactory;
using ProxyPattern;
using SingletonPattern;

Console.WriteLine(LazyIdGen.GetInstance().GetId());

CacheConfigParserFactory simpleFactory = new CacheConfigParserFactory();
ICacheConfigurationParser parser1 = simpleFactory.createParser("JSON");
parser1.Load("1.json");
Console.WriteLine(parser1.GetSection("ConnStr"));

ResourcePoolConfig resourcePoolConfig = new ResourcePoolConfigBuilder()
                                            .SetName("test")
                                            .SetMaxTotal(10)
                                            .SetMaxIdel(2)
                                            .SetMinIdel(1)
                                            .Build();
Console.WriteLine(resourcePoolConfig);

UserController userController = new UserControllerProxy(MetricUtils.getInstance());
userController.login("tying", "123");