class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def goodNodes(self, root: TreeNode) -> int:
        def traverse(root, greatest):
            if not root:
                return 0

            if root.val >= greatest:
                return (
                    1 + traverse(root.left, root.val) + traverse(root.right, root.val)
                )
            else:
                return traverse(root.left, greatest) + traverse(root.right, greatest)

        return traverse(root, root.val)
