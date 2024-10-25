namespace remove_duplicates_from_sorted_list
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while (current != null && current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

          
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);

            ListNode result = solution.DeleteDuplicates(head);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            
        }
    }
}
