//7 https://leetcode.com/problems/reverse-linked-list/

//*
// *Definition for singly - linked list.

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

#region Recursion
//public class Solution
//{
//    public ListNode ReverseList(ListNode head)
//    {
//        if(head == null) return null;


//        //base case
//        if(head.next == null)
//        {
//            return head;
//        }

//        //recursion case
//        var newHead = ReverseList(head.next);

//        head.next.next = head;
//        head.next = null;

//        return newHead;
//    }
//}
#endregion

#region Iterative
//public class Solution
//{
//    public ListNode ReverseList(ListNode head)
//    {
//        if (head == null) return null;

//        ListNode prev = null;
//        while(head.next != null)
//        {
//            var curr = head;
//            head = head.next;

//            curr.next = prev;
//            prev = curr;
//        }

//        // head is last one now
//        head.next = prev;

//        return head;
//    }
//}
#endregion