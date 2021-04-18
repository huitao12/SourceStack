using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class DLinkNode<T>
    {
        public DLinkNode<T> Previous { get; set; } //前面一个节点
        public DLinkNode<T> Next { get; set; }  //后面一个节点
        public int value { get; set; }

        public void AddAfter(DLinkNode<T> node) //添加在……之后节点
        {
            //if (this.Next==null)
            //{
            //    this.Next = node;
            //    node.Previous = this;
            //}
            //else
            //{
            //    node.Next = this.Next;//node(3)的下一个是原来this(1)的下一个
            //    node.Previous = this; //node的前一个是这个对象(1)

            //    this.Next.Previous = node;//这个对象的下一个的上一个是node
            //    this.Next = node;//这个对象(1)的后一个是node
            //}


            //重构以上：重构的基础是单元测试
            if (this.Next != null)
            {
                node.Next = this.Next;//node(3)的下一个是原来this(1)的下一个
                this.Next.Previous = node;//这个对象的下一个的上一个是node
            }
            node.Previous = this; //node的前一个是这个对象(1)
            this.Next = node;//这个对象(1)的后一个是node


            ////this.Next = node; //这个对象(1)的后一个是node
            //node.Next = this.Next;//node(3)的下一个是原来this(1)的下一个
            //node.Previous = this; //node的前一个是这个对象(1)

            //this.Next.Previous = node;//这个对象的下一个的上一个是node
            //this.Next = node;//这个对象(1)的后一个是node

        }



        public void AddBefore(DLinkNode<T> node)//添加在……之前节点
        {
            if (this.Previous != null)
            {
                this.Previous = node.Previous;
                this.Previous.Next = node;
            }
            this.Previous = node;
            node.Next = this;

        }

        public void Delete() //删除节点
        {
            if (this.Next != null)
            {
                this.Next.Previous = this.Previous;
            }
            if (this.Previous != null)
            {
                this.Previous.Next = this.Next;
            }
            this.Next = null;
            this.Previous = null;
        }

        public void Swap(DLinkNode<T> node) //交换节点  
        {
            // 1  2  3  4  5
            // 1 [4] 3 [2] 5
            //node2.Swap(node4);
            DLinkNode<T> preThis = this.Previous; //当前的前一个1
            DLinkNode<T> NextThis = this.Next;    //当前的后一个3;
            if (node.Next != this)             //5!=2
            {
                this.Delete();                 //1345
                node.AddAfter(this);           //134[2]5
            }
            if (preThis == node)               //1 = 4?
            {
                preThis = this;                //
            }
            if (preThis == null)
            {
                if (node.Next != NextThis)
                {
                    node.Delete();
                    NextThis.AddBefore(node);//之前
                }
            }
            else
            {
                if (node.Previous != preThis)
                {
                    node.Delete();
                    preThis.AddAfter(node);
                }
            }
        }

    }
}
