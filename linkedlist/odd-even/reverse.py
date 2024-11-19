# Recursive Python program to reverse
# a linked list
class Node:
    def __init__(self, x):
        self.data = x
        self.next = None


# Function to reverse the linked list
def reverse_list(head):
    if head is None or head.next is None:
        return head

    revHead = reverse_list(head.next)
    head.next.next = head
    head.next = None

    return revHead


def print_list(head):
    curr = head
    while curr:
        print(curr.data, end=" ")
        curr = curr.next
    print()


if __name__ == "__main__":
    # Create a hard-coded linked list:
    # 1 -> 2 -> 3 -> 4 -> 5
    head = Node(1)
    head.next = Node(2)
    head.next.next = Node(3)
    head.next.next.next = Node(4)
    head.next.next.next.next = Node(5)

    head = reverse_list(head)
    print_list(head)
