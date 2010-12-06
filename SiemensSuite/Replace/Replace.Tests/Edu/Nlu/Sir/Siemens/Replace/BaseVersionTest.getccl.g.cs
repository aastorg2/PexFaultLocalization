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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Edu.Nlu.Sir.Siemens.Replace
{
    public partial class BaseVersionTest
    {
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl400()
{
    bool b;
    char[] cs = new char[100];
    int i = 1;
    char[] cs1 = new char[100];
    int i1 = 0;
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(2, i);
    Assert.AreEqual<int>(2, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl710()
{
    bool b;
    char[] cs = new char[100];
    int i = 68;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[69] = '\u8000';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(70, i);
    Assert.AreEqual<int>(3, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl815()
{
    bool b;
    char[] cs = new char[100];
    int i = 2;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[3] = '^';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(4, i);
    Assert.AreEqual<int>(2, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl531()
{
    bool b;
    char[] cs = new char[100];
    int i = 64;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[64] = '@';
    cs[65] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(66, i);
    Assert.AreEqual<int>(3, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl120()
{
    bool b;
    char[] cs = new char[100];
    int i = 67;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[67] = '@';
    cs[68] = '@';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(69, i);
    Assert.AreEqual<int>(5, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl98()
{
    bool b;
    char[] cs = new char[100];
    int i = 35;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[36] = '-';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(37, i);
    Assert.AreEqual<int>(5, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl680()
{
    bool b;
    char[] cs = new char[100];
    int i = 64;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[65] = '-';
    cs[66] = '\u8000';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(67, i);
    Assert.AreEqual<int>(6, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl203()
{
    bool b;
    char[] cs = new char[100];
    int i = 1;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[1] = '1';
    cs[2] = '-';
    cs[3] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(4, i);
    Assert.AreEqual<int>(6, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl481()
{
    bool b;
    char[] cs = new char[100];
    int i = 96;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[96] = '@';
    cs[97] = '@';
    cs[98] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(99, i);
    Assert.AreEqual<int>(5, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl278()
{
    bool b;
    char[] cs = new char[100];
    int i = 65;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[65] = '@';
    cs[66] = '@';
    cs[67] = 't';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(68, i);
    Assert.AreEqual<int>(3, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl562()
{
    bool b;
    char[] cs = new char[100];
    int i = 32;
    int i1 = 0;
    cs[32] = '1';
    cs[33] = '-';
    cs[34] = '1';
    b = this.getccl(cs, ref i, cs, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(35, i);
    Assert.AreEqual<int>(2, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl505()
{
    bool b;
    char[] cs = new char[100];
    int i = 1;
    char[] cs1 = new char[100];
    int i1 = 2;
    cs[1] = '9';
    cs[2] = '-';
    cs[3] = 'x';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(4, i);
    Assert.AreEqual<int>(67, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl591()
{
    bool b;
    char[] cs = new char[100];
    int i = 17;
    char[] cs1 = new char[100];
    int i1 = 36;
    cs[18] = ']';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(true, b);
    Assert.AreEqual<int>(18, i);
    Assert.AreEqual<int>(38, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl478()
{
    bool b;
    char[] cs = new char[100];
    int i = 65;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[65] = '@';
    cs[66] = '@';
    cs[67] = 'n';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(68, i);
    Assert.AreEqual<int>(3, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl90()
{
    bool b;
    char[] cs = new char[100];
    int i = 9;
    char[] cs1 = new char[100];
    int i1 = 32;
    cs[9] = '4';
    cs[10] = '-';
    cs[11] = 's';
    cs[12] = '\u0001';
    cs[13] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(14, i);
    Assert.AreEqual<int>(99, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl143()
{
    bool b;
    char[] cs = new char[100];
    int i = 1;
    char[] cs1 = new char[100];
    int i1 = 98;
    cs[1] = '6';
    cs[2] = '-';
    cs[3] = 'p';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(4, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl617()
{
    bool b;
    char[] cs = new char[100];
    int i = 32;
    char[] cs1 = new char[100];
    int i1 = 60;
    cs[32] = '\u8031';
    cs[33] = '-';
    cs[34] = '-';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(35, i);
    Assert.AreEqual<int>(64, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl330()
{
    bool b;
    char[] cs = new char[100];
    int i = 24;
    char[] cs1 = new char[100];
    int i1 = 56;
    cs[24] = '@';
    cs[25] = '@';
    cs[26] = '@';
    cs[27] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(28, i);
    Assert.AreEqual<int>(60, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl809()
{
    bool b;
    char[] cs = new char[100];
    int i = 30;
    int i1 = 98;
    cs[30] = 'w';
    cs[31] = '-';
    cs[32] = 'z';
    cs[33] = '\u0001';
    cs[34] = '-';
    cs[35] = '\u0001';
    b = this.getccl(cs, ref i, cs, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(36, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl379()
{
    bool b;
    char[] cs = new char[100];
    int i = 27;
    char[] cs1 = new char[100];
    int i1 = 98;
    cs[27] = 'w';
    cs[28] = '-';
    cs[29] = 'z';
    cs[30] = '1';
    cs[31] = '-';
    cs[32] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(33, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl223()
{
    bool b;
    char[] cs = new char[100];
    int i = 27;
    int i1 = 98;
    cs[27] = 'w';
    cs[28] = '-';
    cs[29] = 'z';
    cs[30] = '\u0001';
    cs[31] = '2';
    cs[32] = '-';
    cs[33] = '\u0200';
    b = this.getccl(cs, ref i, cs, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(34, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl642()
{
    bool b;
    char[] cs = new char[100];
    int i = 28;
    char[] cs1 = new char[100];
    int i1 = 98;
    cs[28] = 'w';
    cs[29] = '-';
    cs[30] = 'z';
    cs[31] = '\u0001';
    cs[32] = '1';
    cs[33] = '-';
    cs[34] = '-';
    cs[35] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(36, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl635()
{
    bool b;
    char[] cs = new char[100];
    int i = 25;
    char[] cs1 = new char[100];
    int i1 = 98;
    cs[25] = 'w';
    cs[26] = '-';
    cs[27] = 'z';
    cs[28] = '\u0001';
    cs[29] = '\u0001';
    cs[30] = '@';
    cs[31] = '1';
    cs[32] = '-';
    cs[33] = '-';
    cs[34] = '@';
    cs[35] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(36, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl887()
{
    bool b;
    char[] cs = new char[100];
    int i = 32;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[32] = '@';
    cs[33] = '@';
    cs[34] = '@';
    cs[35] = '@';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(36, i);
    Assert.AreEqual<int>(4, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl614()
{
    bool b;
    char[] cs = new char[100];
    int i = 28;
    char[] cs1 = new char[100];
    int i1 = 0;
    cs[28] = '@';
    cs[29] = '@';
    cs[30] = '@';
    cs[31] = '@';
    cs[32] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(33, i);
    Assert.AreEqual<int>(4, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl835()
{
    bool b;
    char[] cs = new char[100];
    int i = 8;
    int i1 = 98;
    cs[8] = 'w';
    cs[9] = '-';
    cs[10] = 'z';
    cs[11] = '\u0001';
    cs[12] = '\u0001';
    cs[13] = '@';
    cs[14] = 'P';
    cs[15] = '-';
    cs[16] = '-';
    cs[17] = '-';
    cs[18] = '\u0001';
    b = this.getccl(cs, ref i, cs, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(19, i);
    Assert.AreEqual<int>(100, i1);
}
[TestMethod]
[PexGeneratedBy(typeof(BaseVersionTest))]
public void getccl331()
{
    bool b;
    char[] cs = new char[100];
    int i = 25;
    char[] cs1 = new char[100];
    int i1 = 98;
    cs[25] = 'w';
    cs[26] = '-';
    cs[27] = 'z';
    cs[28] = '\u0001';
    cs[29] = '\u0001';
    cs[30] = '1';
    cs[31] = '-';
    cs[32] = '@';
    cs[33] = '1';
    cs[34] = '-';
    cs[35] = '\u0001';
    b = this.getccl(cs, ref i, cs1, ref i1);
    Assert.AreEqual<bool>(false, b);
    Assert.AreEqual<int>(36, i);
    Assert.AreEqual<int>(100, i1);
}
    }
}