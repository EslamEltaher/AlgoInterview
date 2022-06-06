//////2 https://leetcode.com/problems/middle-of-the-linked-list/submissions/

///**
// * Definition for singly-linked list.
 
// */

//public class ListNode
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//    }
//}

//#region Solution 1
////public class Solution
////{
////    public ListNode MiddleNode(ListNode head)
////    {

////        ///Count
////        int count = 0;

////        var node = head;
////        while (node != null)
////        {
////            count++;

////            node = node.next;
////        }


////        node = head;

////        int moves = 0;

////        while(moves < count / 2)
////        {
////            moves++;
////            node = node.next;
////        }

////        return node;

////    }
////}
//#endregion

//#region Solution 2
//public class Solution
//{
//    public ListNode MiddleNode(ListNode head)
//    {
//        var slow = head;
//        var fast = head;

//        while(fast != null && fast.next != null)
//        {
//            fast = fast.next;
//            fast = fast.next;

//            slow = slow.next;
//        }

//        return slow;
//    }
//}
//#endregion