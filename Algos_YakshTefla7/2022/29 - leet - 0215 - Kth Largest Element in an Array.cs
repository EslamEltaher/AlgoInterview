////29 https://leetcode.com/problems/kth-largest-element-in-an-array/
////


//using System;

//public class Solution
//{
//    public int FindKthLargest(int[] nums, int k)
//    {
//        var queue = new MaxHeap();

//        for(int i = 0; i < nums.Length; i++)
//        {
//            queue.Insert(nums[i]);
//        }

//        int result = 0;
//        for (int i = 0; i < k; i++)
//        {
//            result = queue.Pop();
//        }
//        return result;
//    }
//}

//public class MaxHeap
//{
//    private int capacity = 10;
//    private int size = 0;

//    private int[] items;

//    public MaxHeap() { items = new int[capacity]; }

//    private int getParentIndex(int index)  { return Math.Max(0 ,(index - 1) / 2); }
//    private int getLeftChildIndex(int index) { return index * 2 + 1; }

//    public void Insert(int item) 
//    {
//        EnsureEnoughCapacity();

//        items[size++] = item;

//        HeapifyUp();
//    }

//    public int Pop()
//    {
//        if (size == 0)
//            throw new ArgumentException();

//        int item = items[0];
//        items[0] = items[size - 1];

//        size--;

//        HeapifyDown();

//        return item;
//    }

//    public void EnsureEnoughCapacity()
//    {
//        if (size >= capacity)
//            capacity *= 2;

//        var newArr = new int[capacity];
//        items.CopyTo(newArr, 0);
//        items = newArr;
//    }

//    public void HeapifyUp()
//    {
//        int index = size - 1;
//        int parentIndex = getParentIndex(index);
//        while(parentIndex != index && items[index] > items[parentIndex])
//        {
//            swap(items, index, parentIndex);
//            index = parentIndex;
//            parentIndex = getParentIndex(index);
//        }
//    }

//    public void HeapifyDown()
//    {
//        int index = 0;
//        int leftChildIndex = getLeftChildIndex(index);

//        while(leftChildIndex < size)
//        {
//            int biggerChildIndex = leftChildIndex;
//            int rightChildIndex = leftChildIndex + 1;
//            if(rightChildIndex < size && items[rightChildIndex] > items[leftChildIndex])
//            {
//                biggerChildIndex = rightChildIndex;
//            }

//            if (items[index] > items[biggerChildIndex])
//                break;

//            swap(items, index, biggerChildIndex);

//            index = biggerChildIndex;
//            leftChildIndex = getLeftChildIndex(biggerChildIndex);
//        }
//    }

//    public void swap(int[] arr, int a, int b)
//    {
//        int temp = arr[a];
//        arr[a] = arr[b];
//        arr[b] = temp;
//    }
//} 
