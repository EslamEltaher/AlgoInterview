////3 https://leetcode.com/problems/linked-list-cycle/

//using System.Collections.Generic;

///**
//* Definition for singly-linked list.
//* 
//*/
////public class ListNode
////{
////    public int val;
////    public ListNode next;
////    public ListNode(int val = 0, ListNode next = null)
////    {
////        this.val = val;
////        this.next = next;
////    }
////}

//#region Solution 1
////public class Solution
////{
////    public bool HasCycle(ListNode head)
////    {
////        var hashset = new HashSet<ListNode>();

////        while(head != null)
////        {
////            if (hashset.Contains((ListNode)head))
////                return true;

////            hashset.Add((ListNode)head);

////            head = head.next;
////        }

////        return false;
////    }
////}
//#endregion

//#region Solution 2
////public class Solution
////{
////    public bool HasCycle(ListNode head)
////    {
////        var fast = head;
////        var slow = head;

////        while (fast != null && fast.next != null)
////        {
////            fast = fast.next.next;

////            if(fast == slow)
////                return true;


////            slow = slow.next;

////            if (fast == slow)
////                return true;
////        }

////        return false;
////    }
////}
//#endregion