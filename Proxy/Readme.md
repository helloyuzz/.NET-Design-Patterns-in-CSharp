**步骤：**

1. 定义接口IMath-->和接口的实现类Mathematics
2. 此时再定义一个IMath-->的接口实现类，如：IMathProxy
3. 在IMathProxy中，再实例化new Mathematics()
4. 也就是：IMathProxy代理执行了Mathematics的功能；

**讲解：**  
所以，代理Proxy的理解应该是，用一个类去实现另一个具有相同实现接口的类功能；
