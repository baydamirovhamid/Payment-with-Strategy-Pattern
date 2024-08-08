
# C# Strategy Design Pattern

Let's dive into the **Strategy Design Pattern**, which falls under the category of **Behavioral Patterns**. There are situations where an operation can be executed using several different methods. In such cases, determining which method to apply or which one to activate can be achieved using the *Strategy Design Pattern*.

![Process](https://www.gencayyildiz.com/blog/wp-content/uploads/2016/04/C-Strategy-Design-PatternStrateji-Tasar%C4%B1m-Deseni.png)

As you can see in the diagram, there are three methods named "StrategyA," "StrategyB," and "StrategyC" for performing an operation. The Context class, which represents our operation, needs to apply the *Strategy Design Pattern* with the following logic.

The Context must update itself to use the appropriate method for performing the operation. If there's a need to change the method again, we'd have to modify the Context once more. In this scenario, a Strategy interface (which could be an **interface** or an **abstract class**) is defined to represent each method, or more precisely, to act as a template for each method. This interface stabilizes all tasks through the elements it contains, and upon inheritance, it enforces the implementation. The Context class performs its operations through this interface.
