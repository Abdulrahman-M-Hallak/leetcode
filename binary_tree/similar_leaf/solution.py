from typing import Optional

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def leafSimilar(self, root1: Optional[TreeNode], root2: Optional[TreeNode]) -> bool:
        def traverse(root: Optional[TreeNode], list):
            if not root:
                return list

            if not root.left and not root.right:
                list.append(root.val)
            traverse(root.left, list)
            traverse(root.right, list)
            return list

        seq1 = traverse(root1, [])
        seq2 = traverse(root2, [])


        if seq1 != seq2:
            return False

        return True