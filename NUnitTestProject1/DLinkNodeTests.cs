using CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    //测试双向链表
    public class DLinkNodeTests
    {
        private DLinkNode node1, node2, node3, node4, node5;

        [SetUp]
        public void SetUp()
        {
            node1 = new DLinkNode() { value = 1 };//赋值
            node2 = new DLinkNode() { value = 2 };
            node3 = new DLinkNode() { value = 3 };
            node4 = new DLinkNode() { value = 4 };
            node5 = new DLinkNode() { value = 5 };

            node1.Next = node2;
            node2.Previous = node1;
            node2.Next = node3;
            node3.Previous = node2;
            node3.Next = node4;
            node4.Previous = node3;
            node4.Next = node5;
            node5.Previous = node4;
        }

        [Test]
        public void AddTest()
        {
            //DLinkNode node1 = new DLinkNode();
            //DLinkNode node2 = new DLinkNode();
            //node1.AddAfter(node2);//node1的后面是node2


            //// 1 2
            //Assert.AreEqual(node2, node1.Next); //node1的下一个是node2 Next之后 //AreEqual是不是相等
            //Assert.IsNull(node1.Previous);//判断是不是头  是头前面就是null

            //Assert.AreEqual(node1, node2.Previous); //node2的前一个是node1  Previous之前
            //Assert.IsNull(node2.Next);//判断是不是尾  是尾后面就是null


            ////1  2  [3]
            ////DLinkNode node3 = new DLinkNode();
            ////node2.AddAfter(node3);//把node3+在node2后面

            //Assert.AreEqual(node2, node3.Previous); //node3的前面一个是node2
            //Assert.AreEqual(node3, node2.Next);// node2的后面一个是node3
            //Assert.IsNull(node3.Next);   //判断node3的后面是不是null

            // 1  2  [6] 3  4 5
            DLinkNode node6 = new DLinkNode() { value = 6 };
            node2.AddAfter(node6);//把node6+在node2后面

            Assert.AreEqual(node2, node6.Previous);
            Assert.AreEqual(node6, node2.Next);
            Assert.AreEqual(node3, node6.Next);
            Assert.AreEqual(node6, node3.Previous);
            Assert.IsNull(node5.Next);   //判断node5的后面是不是null


        }
        [Test]
        public void AddBefore()//添加在……之前节点
        {
            //  [11] 1 2 3 4 5
            DLinkNode node11 = new DLinkNode() { value = 11 };
            node1.AddBefore(node11);

            Assert.AreEqual(node11, node1.Previous);
            Assert.AreEqual(node1, node11.Next);
        }
        [Test]
        public void DeleteTest()//删除节点
        {
            //[1] 2 3 4 5
            node1.Delete();
            Assert.AreEqual(null, node2.Previous);



            //1 2 [3] 4 5
            node3.Delete();
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);

            //1 2 3 [4] 5
            node4.Delete();
            Assert.AreEqual(null, node3.Next);
        }


        [Test]
        public void SwapTest()//交换
        {
            //1 2 3 4 5

            // 1[3][2]  4 5
            node2.Swap(node3);
            Assert.AreEqual(node3, node1.Next);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node2.Previous);
            Assert.AreEqual(node2, node3.Next);
            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);


            // 1  3 2  4 5
            // [3] [1] 2 4 5

            node3.Swap(node1);
            Assert.IsNull(node3.Previous);
            Assert.AreEqual(node1, node3.Next);
            Assert.AreEqual(node3, node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);

            // 3 1 2 4 5
            // [5] 1 2 4 [3]
            node5.Swap(node3);
            Assert.IsNull(node5.Previous);
            Assert.AreEqual(node5, node1.Previous);
            Assert.AreEqual(node1, node5.Next);
            Assert.IsNull(node3.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.AreEqual(node3, node4.Next);

            // 5 1 2 4 3
            // 5 [4] 2 [1] 3
            node1.Swap(node4);
            Assert.AreEqual(node5, node4.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node3, node1.Next);

        }
        [Test]
        public void SwapSwapBorderTestTest() //交换
        {

            //1 2 3 4 5
            // 1 [4]  3 [ 2]  5
            //node2.Swap(node4);
            //Assert.AreEqual(node1, node4.Previous);
            //Assert.AreEqual(node4, node1.Next);
            //Assert.AreEqual(node3, node4.Next);
            //Assert.AreEqual(node4, node3.Previous);
            //Assert.AreEqual(node3, node2.Previous);
            //Assert.AreEqual(node2, node3.Next);
            //Assert.AreEqual(node2, node5.Previous);
            //Assert.AreEqual(node5, node2.Next);

            //1 2 3 4 5
            // [2] [1] 3 4 5
            node2.Swap(node1);
            Assert.IsNull(node2.Previous);
            Assert.AreEqual(2, node1.Previous.value);
            Assert.AreEqual(1, node2.Next.value);
            Assert.AreEqual(1, node3.Previous.value);
            Assert.AreEqual(3, node1.Next.value);

        }

    }
}
