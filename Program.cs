namespace Assignment8._2BinaryTree
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode();
            
            tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(2);
            tree.left.left = new TreeNode(3);
            tree.left.right = new TreeNode(4);
            tree.right.left = new TreeNode(4);
            tree.right.right = new TreeNode(3);
            

            if (IsSymmetric(tree))
            {
                Console.WriteLine("The Tree is Symmetrical");

            }
            else
            {
                Console.WriteLine("The Tree is Not Symmetrical");
            }
        }
        public static bool IsSymmetric(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
           
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                TreeNode left = queue.Dequeue();
                TreeNode right = queue.Dequeue();

                if (left == null && right == null)
                {   
                    continue;
                }
                else if (left == null || right == null)
                {  
                    return false;
                }
                else if (left.value != right.value)
                {   
                    return false;
                }
                else
                {   
                    queue.Enqueue(left.left);
                    queue.Enqueue(right.right);
                    queue.Enqueue(left.right);
                    queue.Enqueue(right.left);
                }
            }

            return true;
        }

    }
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

    }


}

