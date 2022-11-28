// namespace C__Practice;

// public class Tests
// {
//     [Test]
//     public void Test_add_1_plus_0()
//     {
//         Assert.AreEqual(1, Arith.add(1, 0));
//         Assert.AreEqual(10, Arith.add(8, 2));
//         Assert.AreEqual(5, Arith.subtract(10, 5));
//     }
// }

// namespace C__Practice;

// public class Tests
// {
//     [Test]
//     public void Test_add_1_plus_0()
//     {
//         Assert.AreEqual(1, Arith.add(2, -1));
//         Assert.AreEqual(10, Arith.add(5, 5));
//         Assert.AreEqual(5, Arith.subtract(6, 1));
//         Assert.AreEqual(4, Arith.multiply(2, 2));
//     }
// }

// namespace C__Practice;

// public class Tests
// {
//     [Test]
//     public void Test_add_1_plus_0()
//     {
//         Assert.AreEqual(1, Arith.add(3, -2));
//         Assert.AreEqual(10, Arith.subtract(15, 5));
//         Assert.AreEqual(5, Arith.subtract(9, 4));
//         Assert.AreEqual(30, Arith.multiply(10, 3));
//         Assert.AreEqual(6, Arith.divide(12, 2));
//     }
// }

// namespace C__Practice;

// public class Tests
// {
//     [Test]
//     public void Test_arith()
//     {
//         Assert.AreEqual(1, Arith.add(5, -4));
//         Assert.AreEqual(10, Arith.subtract(20, 10));
//         Assert.AreEqual(30, Arith.multiply(15, 2));
//         Assert.AreEqual(100, Arith.multiply(50, 2));
//         Assert.AreEqual(5, Arith.divide(5, 1));
//     }
// }

namespace C__Practice;

public class Tests
{
    [Test]
    public void Test_arith()
    {
        Assert.AreEqual(4, Arith.add(3, 1));
        Assert.AreEqual(7, Arith.subtract(10, 3));
        Assert.AreEqual(80, Arith.multiply(20, 4));
        Assert.AreEqual(8, Arith.divide(16, 2));
        Assert.AreEqual(14, Arith.divide(14, 1));
    }
}