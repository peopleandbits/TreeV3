using TreeV3.Algorithms;
using TreeV3.Nodes;

namespace TreeV3.Trees
{
    /// <summary>
    /// A generic tree. All nodes, including root are a pre-defined string-keyed rootnodes, whose payload can vary.
    /// </summary>
    public class GenericDataTree
    {
        public GenericDataTree(TreeNodeWithStringKey root)
        {
            Root = root;
        }

        public TreeNodeWithStringKey Root { get; private set; }
    }

    /// <summary>
    /// A string-keyed node. Payload can vary.
    /// </summary>
    public class TreeNodeWithStringKey : TreeNode<string>
    {
        public TreeNodeWithStringKey(string id, object payload, IChildFinder<string> finder = null) : base(id, payload, finder)
        {
        }
    }
}
