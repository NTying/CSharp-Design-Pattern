装饰器和代理模式的区别：
	代理模式中，代理类附加的是跟原始类无关的功能，而在装饰器模式中，装饰器类附加的是跟原始类相关的增强功能

装饰器模式主要解决继承关系过于复杂的问题，通过组合来替代继承。
它主要的作用是给原始类添加增强功能。这也是判断是否该用装饰器模式的一个重要的依据。
除此之外，装饰器模式还有一个特点，那就是可以对原始类嵌套使用多个装饰器。
为了满足这个应用场景，在设计的时候，装饰器类需要跟原始类继承相同的抽象类或者接口。

使用装饰器模式还是代理模式？
	对于添加缓存这个应用场景使用哪种模式，要看设计者的意图，如果设计者不需要用户关注是否使用缓存功能，要隐藏实现细节，
	也就是说用户只能看到和使用代理类，那么就使用proxy模式；
	反之，如果设计者需要用户自己决定是否使用缓存的功能，需要用户自己新建原始对象并动态添加缓存功能，那么就使用decorator模式。