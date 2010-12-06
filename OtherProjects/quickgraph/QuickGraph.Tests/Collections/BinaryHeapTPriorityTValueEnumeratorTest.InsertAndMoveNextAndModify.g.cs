// <copyright file="BinaryHeapTPriorityTValueEnumeratorTest.InsertAndMoveNextAndModify.g.cs" company="MSIT">Copyright � MSIT 2007</copyright>
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

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueEnumeratorTest
    {
[TestMethod]
[PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
public void InsertAndMoveNextAndModify832()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(0);
    this.InsertAndMoveNextAndModify<int, int>
        (binaryHeap, default(KeyValuePair<int, int>));
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual<int>(3, binaryHeap.Capacity);
    Assert.AreEqual<int>(2, binaryHeap.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
public void InsertAndMoveNextAndModify83201()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(1);
    this.InsertAndMoveNextAndModify<int, int>
        (binaryHeap, default(KeyValuePair<int, int>));
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual<int>(3, binaryHeap.Capacity);
    Assert.AreEqual<int>(2, binaryHeap.Count);
}
[TestMethod]
[PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
public void InsertAndMoveNextAndModify83202()
{
    BinaryHeap<int, int> binaryHeap;
    binaryHeap = BinaryHeapFactory.Create(2);
    this.InsertAndMoveNextAndModify<int, int>
        (binaryHeap, default(KeyValuePair<int, int>));
    Assert.IsNotNull((object)binaryHeap);
    Assert.IsNotNull(binaryHeap.PriorityComparison);
    Assert.AreEqual<int>(2, binaryHeap.Capacity);
    Assert.AreEqual<int>(2, binaryHeap.Count);
}
    }
}
