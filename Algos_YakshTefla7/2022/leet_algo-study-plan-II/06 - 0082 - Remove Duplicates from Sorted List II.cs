////https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/

////Definition for singly - linked list.
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

//public class Solution
//{
//    public ListNode DeleteDuplicates(ListNode head)
//    {
//        if (head == null)
//            return null;

//        ListNode prevSeq = null;

//        var seqFirst = head;
//        var seqLast = head;

//        var curr = head.next;

//        while(curr != null)
//        {
//            while (curr != null && curr.val == seqFirst.val)
//            {
//                seqLast = curr;
//                curr = curr.next;
//            }

//            if (seqFirst == seqLast)
//            {
//                prevSeq = seqLast;
//            }

//            if (prevSeq == null)
//                head = curr;
//            else
//                prevSeq.next = curr;

//            seqFirst = curr;
//            seqLast = curr;
            
//            if(curr != null)
//                curr = curr.next;
//        }

//        return head;
//    }
//}