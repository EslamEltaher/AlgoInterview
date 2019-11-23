////16 https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=trees

////From JAVA Implementation //only copy lca function
//namespace whatever
//{
//    class Node
//    {
//        public Node left;
//        public Node right;
//        public int data;

//        public Node(int data)
//        {
//            this.data = data;
//            left = null;
//            right = null;
//        }
//    }

//    class Solution
//    {

//        /*
//        class Node 
//    	    int data;
//    	    Node left;
//    	    Node right;
//	    */
//        public bool checkBST(Node root)
//        {
//            return checkBST(root, 0, 10000); //as in constraints 0 < data <10^4
//        }

//        public bool checkBST(Node root, int min, int max)
//        {
//            if (root == null)
//                return true;

//            if (root.data < min || root.data > max)
//                return false;

//            return checkBST(root.left, min, root.data - 1) && checkBST(root.right, root.data + 1, max);
//        }

//        public static Node insert(Node root, int data)
//        {
//            if (root == null)
//            {
//                return new Node(data);
//            }
//            else
//            {
//                Node cur;
//                if (data <= root.data)
//                {
//                    cur = insert(root.left, data);
//                    root.left = cur;
//                }
//                else
//                {
//                    cur = insert(root.right, data);
//                    root.right = cur;
//                }
//                return root;
//            }
//        }

//        //public static void main(String[] args)
//        //{
//        //    Scanner scan = new Scanner(System.in);
//        //    int t = scan.nextInt();
//        //    Node root = null;
//        //    while (t-- > 0)
//        //    {
//        //        int data = scan.nextInt();
//        //        root = insert(root, data);
//        //    }
//        //    int v1 = scan.nextInt();
//        //    int v2 = scan.nextInt();
//        //    scan.close();
//        //    Node ans = lca(root, v1, v2);
//        //    System.out.println(ans.data);
//        //}
//    }
//}
