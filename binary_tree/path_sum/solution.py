from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def pathSum(self, root: Optional[TreeNode], targetSum: int) -> int:
        def traverse(root, sum, targeSum):
            if not root:
                return 0
            sum += root.val
            if sum > targeSum:
                sum = 0

            if sum == targeSum:
                return (
                    1
                    + traverse(root.left, root.val, targeSum)
                    + traverse(root.right, root.val, targeSum)
                )
            else:
                return traverse(root.left, sum, targeSum) + traverse(
                    root.right, sum, targeSum
                )

        return traverse(root, 0, targetSum)


test = TreeNode(
    10,
    TreeNode(5, TreeNode(3, TreeNode(3, TreeNode(3))), TreeNode(2, None, TreeNode(1))),
    TreeNode(-3, None, TreeNode(11)),
)

sln = Solution()
print(sln.pathSum(test, 8))
