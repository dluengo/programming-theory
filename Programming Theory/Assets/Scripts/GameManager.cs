using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{

}

// Example of ABSTRACTION.
// We need, for whatever reason (i.e. to demonstrate abstraction), two classes that share something in
// common, we call that "foo". It is better to abstract that property into a more generic class that
// implements the logic required to handle it.

// Example of INHERITANCE
// The classes Child1Class and Child2Class inherit from ParentClass
public class ParentClass : MonoBehaviour
{
    // Example of ENCAPSULATION
    // Setters and getters are defined for the public member foo but internally a property is
    // used.
    protected int m_foo;
    public int foo {
        get {
            return m_foo;
        }
        set {
            m_foo = value;
        } 
    }

    public virtual void FooMethod()
    {
        Debug.Log("FooMethod() from PARENT class.");
    }

    // Example of POLYMORPHISM
    // This method may be called by Child1Class and Child2Class instances.
    public void PolymorphicMethod(string callername)
    {
        Debug.Log($"PARENT method called by " + callername);
    }
}

public class Child1Class : ParentClass
{
    private string bar;

    public override void FooMethod()
    {
        base.FooMethod();

        Debug.Log("FooMethod() from CHILD1 class.");
        PolymorphicMethod("CHILD1");
    }
}

public class Child2Class : ParentClass
{
    private int bar;
    public override void FooMethod()
    {
        base.FooMethod();

        Debug.Log("FooMethod() from CHILD2 class.");
        PolymorphicMethod("CHILD2");
    }
}
