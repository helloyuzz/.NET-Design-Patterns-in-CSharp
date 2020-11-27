# .NET-Design-Patterns-in-CSharp
基于C#实现，常用设计模式在C#中的应用，包括培训代码及示例。

|Patterns Type| No.| Patterns Name| Patterns Descriptin | Demo Code |
|-|-|-|-|-|
|Structural<br>结构模式|1|Adapter<br>适配器模式|主要解决不同class之间，在具有相类似操作的情况下，通过新建Adapter来完成接口统一，简化外部调用。|-|
|-|-|-|-|-|
### 1.结构模式 
    1.1 Adapter - 适配器模式
    
    主要解决不同class之间，在具有相类似操作的情况下，通过新建Adapter来完成接口统一，简化外部调用。
    示例代码：
    Class A;    => MethodA();
    Class B;    => MethodB();

    Adapter a = new Adapter(); {
        Method() = >{
            switch(type){
                Case "A":
                    return a.MethodA();
                Case "B":
                    return a.MethodB();
            }
        }
    }

    a.Method("A") => A.MethodA();
    a.Method("B") => B.MethodB();