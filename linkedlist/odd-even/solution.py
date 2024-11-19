from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev = None
        current = head

        while current:
            next = current.next
            current.next = prev
            prev = current
            current = next

        return prev

def reverse(head: Optional[ListNode]) -> Optional[ListNode]:
    if head is None or head.next is None:
        return head

    revHead = reversed(head.next)

    # Make the current head the last node
    head.next.next = head

    # Update the next of current head to None
    head.next = None

    # Return the new head of the reversed list
    return revHead


head = ListNode(1)
head.next = ListNode(2)
result = reverse(head)
