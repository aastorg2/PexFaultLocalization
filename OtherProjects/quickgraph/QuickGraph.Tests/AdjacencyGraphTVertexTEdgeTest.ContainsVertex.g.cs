// <copyright file="AdjacencyGraphTVertexTEdgeTest.ContainsVertex.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
using Microsoft.ExtendedReflection.DataAccess;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void ContainsVertex412()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    b = this.ContainsVertex<int, Edge<int>>(adjacencyGraph, 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(0, adjacencyGraph.EdgeCount);
}
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void ContainsVertex70()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    b = this.ContainsVertex<int, Edge<int>>(adjacencyGraph, 0);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(1, adjacencyGraph.EdgeCount);
}
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void ContainsVertex7001()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    b = this.ContainsVertex<int, Edge<int>>(adjacencyGraph, 0);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(1, adjacencyGraph.EdgeCount);
}
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void ContainsVertex716()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(15362, 1);
    keyValuePairs[0] = s0;
    KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(115616930, 49152);
    keyValuePairs[1] = s1;
    adjacencyGraph = AdjacencyGraphFactory.Create(true, keyValuePairs);
    b = this.ContainsVertex<int, Edge<int>>(adjacencyGraph, 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(true, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(2, adjacencyGraph.EdgeCount);
}
    }
}
