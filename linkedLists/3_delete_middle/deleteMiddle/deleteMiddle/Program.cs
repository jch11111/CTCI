using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode nodea = new LLNode("a");
            LLNode nodeb = new LLNode("b");
            LLNode nodec = new LLNode("c");
            LLNode noded = new LLNode("d");
            LLNode nodee = new LLNode("e");
            LList ll = new LList(nodea);
            nodea.Next = nodeb;
            nodeb.Next = nodec;
            nodec.Next = noded;
            noded.Next = nodee;
            ll.Print();
            try
            {
                deletMiddleNode(nodec);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }
            ll.Print();
            
        }

        static void deletMiddleNode(LLNode deleteNode) {
            if (deleteNode.Next == null)
            {
                throw new Exception("deletMiddle method is invalid for last node in list");
            }

            deleteNode.Data = deleteNode.Next.Data;
            deleteNode.Next = deleteNode.Next.Next;
        }
    }

    public class LList {
        public LLNode Head { get; set; }
        public LList(LLNode headNode) {
            this.Head = headNode;
        }
        public void Print() {
            LLNode node = this.Head;
            string output = "";
            while (node != null) {
                output += node.Data;
                output += (node.Next == null) ? "" : "=>";
                node = node.Next;
            }
            Console.WriteLine(output);
        }
    }

    public class LLNode {
        public string Data { get; set; }
        public LLNode Next { get; set; }

        public LLNode(string data) {
            this.Data = data;
            this.Next = null;
        }
    }
}
