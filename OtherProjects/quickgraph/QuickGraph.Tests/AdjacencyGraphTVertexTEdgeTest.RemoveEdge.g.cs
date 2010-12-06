// <copyright file="AdjacencyGraphTVertexTEdgeTest.RemoveEdge.g.cs" company="MSIT">Copyright © MSIT 2007</copyright>
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
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph
{
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void RemoveEdge918()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    Edge<int> edge;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 384);
    keyValuePairs[0] = s0;
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    edge = EdgeFactory.Create(0, 0);
    b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, edge);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(1, adjacencyGraph.EdgeCount);
}
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void RemoveEdge91801()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    Edge<int> edge;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(int.MinValue, 294912);
    keyValuePairs[0] = s0;
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    edge = EdgeFactory.Create(0, 0);
    b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, edge);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(1, adjacencyGraph.EdgeCount);
}
[TestMethod]
[PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
public void RemoveEdge13()
{
    AdjacencyGraph<int, Edge<int>> adjacencyGraph;
    Edge<int> edge;
    bool b;
    KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[3];
    KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(1678510080, 2641920);
    keyValuePairs[0] = s0;
    KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(50331650, 50331650);
    keyValuePairs[1] = s1;
    KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(50331650, 50331650);
    keyValuePairs[2] = s2;
    adjacencyGraph = AdjacencyGraphFactory.Create(false, keyValuePairs);
    edge = EdgeFactory.Create(0, 0);
    b = this.RemoveEdge<int, Edge<int>>(adjacencyGraph, edge);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)adjacencyGraph);
    Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
    Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
    Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
    Assert.AreEqual<bool>(false, adjacencyGraph.IsEdgesEmpty);
    Assert.AreEqual<int>(2, adjacencyGraph.EdgeCount);
}
    }
}
