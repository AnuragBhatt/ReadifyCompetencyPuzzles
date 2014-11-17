using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadifyCompetencyPuzzles
{
    class ComputeNodeList
    {
        private int index = 0;
        private ListNode fifthNode = null;
        private int totalNode = 0;

        public static void Run()
        {
            ComputeNodeList mPgm = new ComputeNodeList();

            ListNode node7 = new ListNode(7, null);
            ListNode node6 = new ListNode(6, node7);
            ListNode node5 = new ListNode(5, node6);
            ListNode node4 = new ListNode(4, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode root = new ListNode(1, node2);
            mPgm.CountTotalNode(root);
            mPgm.GetFifthNode(root);//The result;
            Console.WriteLine(string.Format("Node Value: {0}, Next Node: {1}", mPgm.fifthNode.NodeValue, mPgm.fifthNode.NextNode.NodeValue ));
        }

        private void CountTotalNode(ListNode curNode)
        {
            if (curNode.NextNode == null)
            {
                return;
            }
            else
            {
                totalNode += 1;
                CountTotalNode(curNode.NextNode);
            }
        }
        private void GetFifthNode(ListNode curNode)
        {
            if (index == totalNode - 5)
            {
                fifthNode = curNode.NextNode;
                return;
            }
            else
            {
                index += 1;
                GetFifthNode(curNode.NextNode);
            }
        }

        public class ListNode
        {
            int _nodeValue;
            ListNode _nextNode;

            public ListNode()
            {
            }
            public ListNode(int nodeValue, ListNode nextNode)
            {
                this._nodeValue = nodeValue;
                this._nextNode = nextNode;
            }
            public int NodeValue
            {
                get
                {
                    return this._nodeValue;
                }
                set
                {
                    this._nodeValue = value;
                }
            }

            public ListNode NextNode
            {
                get
                {
                    return this._nextNode;
                }
                set
                {
                    this._nextNode = value;
                }
            }
        }
    }
}
