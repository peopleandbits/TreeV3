using TreeV3.Algorithms;
using TreeV3.Nodes;

namespace TreeV3.Trees
{
    public class GenericDataTree
    {
        public GenericDataTree(TreeNodeWithStringKey root)
        {
            Root = root;
        }

        public TreeNodeWithStringKey Root { get; private set; }
    }

    public class TreeNodeWithStringKey : TreeNode<string>
    {
        public TreeNodeWithStringKey(string id, object payload, IChildFinder<string> finder = null) : base(id, payload, finder)
        {
        }
    }
}
