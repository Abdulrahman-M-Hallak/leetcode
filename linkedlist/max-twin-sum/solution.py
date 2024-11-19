from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        fast = head
        slow = head

        while fast and fast.next:
            fast = fast.next.next
            slow = slow.next # type: ignore

        curr, prev = slow, None

        while curr:
            curr.next, prev, curr = prev, curr, curr.next 

        largest_sum = 0

        while prev:
            largest_sum = max(largest_sum, head.val + prev.val) # type: ignore
            head = head.next # type: ignore
            prev = prev.next

        return largest_sum