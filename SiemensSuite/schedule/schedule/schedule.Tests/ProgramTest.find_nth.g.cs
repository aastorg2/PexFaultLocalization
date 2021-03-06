// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace schedule
{
    public partial class ProgramTest
    {
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth609()
{
    LinkedListNode<Ele> linkedListNode;
    linkedListNode = this.find_nth((LinkedList<Ele>)null, 0);
    Assert.IsNull((object)linkedListNode);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth492()
{
    LinkedList<Ele> linkedList;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[0];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedListNode = this.find_nth(linkedList, 0);
    Assert.IsNull((object)linkedListNode);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth812()
{
    LinkedList<Ele> linkedList;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[1];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedListNode = this.find_nth(linkedList, 0);
    Assert.IsNotNull((object)linkedListNode);
    Assert.IsNotNull(linkedListNode.List);
    Assert.AreEqual<int>(1, linkedListNode.List.Count);
    Assert.IsNotNull(linkedListNode.List.First);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.First, (object)linkedListNode));
    Assert.IsNotNull(linkedListNode.List.Last);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.Last, (object)linkedListNode));
    Assert.IsNull(linkedListNode.Next);
    Assert.IsNull(linkedListNode.Previous);
    Assert.IsNull(linkedListNode.Value);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth723()
{
    LinkedList<Ele> linkedList;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[1];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedListNode = this.find_nth(linkedList, 768);
    Assert.IsNull((object)linkedListNode);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth49201()
{
    LinkedList<Ele> linkedList;
    LinkedList<Ele> linkedList1;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[0];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedList1 = new LinkedList<Ele>((IEnumerable<Ele>)linkedList);
    linkedListNode = this.find_nth(linkedList1, 0);
    Assert.IsNull((object)linkedListNode);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth81201()
{
    LinkedList<Ele> linkedList;
    LinkedList<Ele> linkedList1;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[1];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedList1 = new LinkedList<Ele>((IEnumerable<Ele>)linkedList);
    linkedListNode = this.find_nth(linkedList1, 0);
    Assert.IsNotNull((object)linkedListNode);
    Assert.IsNotNull(linkedListNode.List);
    Assert.AreEqual<int>(1, linkedListNode.List.Count);
    Assert.IsNotNull(linkedListNode.List.First);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.First, (object)linkedListNode));
    Assert.IsNotNull(linkedListNode.List.Last);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.Last, (object)linkedListNode));
    Assert.IsNull(linkedListNode.Next);
    Assert.IsNull(linkedListNode.Previous);
    Assert.IsNull(linkedListNode.Value);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth283()
{
    LinkedList<Ele> linkedList;
    LinkedList<Ele> linkedList1;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[2];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedList1 = new LinkedList<Ele>((IEnumerable<Ele>)linkedList);
    linkedListNode = this.find_nth(linkedList1, 0);
    Assert.IsNotNull((object)linkedListNode);
    Assert.IsNotNull(linkedListNode.List);
    Assert.AreEqual<int>(2, linkedListNode.List.Count);
    Assert.IsNotNull(linkedListNode.List.First);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.First, (object)linkedListNode));
    Assert.IsNotNull(linkedListNode.List.Last);
    Assert.IsNotNull(linkedListNode.List.Last.List);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.List.Last.List, linkedListNode.List));
    Assert.IsNull(linkedListNode.List.Last.Next);
    Assert.IsNotNull(linkedListNode.List.Last.Previous);
    Assert.IsTrue(object.ReferenceEquals
                      (linkedListNode.List.Last.Previous, (object)linkedListNode));
    Assert.IsNull(linkedListNode.List.Last.Value);
    Assert.IsNotNull(linkedListNode.Next);
    Assert.IsTrue
        (object.ReferenceEquals(linkedListNode.Next, linkedListNode.List.Last));
    Assert.IsNull(linkedListNode.Previous);
    Assert.IsNull(linkedListNode.Value);
}
[TestMethod]
[PexGeneratedBy(typeof(ProgramTest))]
public void find_nth339()
{
    LinkedList<Ele> linkedList;
    LinkedListNode<Ele> linkedListNode;
    Ele[] eles = new Ele[2];
    linkedList = new LinkedList<Ele>((IEnumerable<Ele>)eles);
    linkedListNode = this.find_nth(linkedList, 768);
    Assert.IsNull((object)linkedListNode);
}
    }
}
