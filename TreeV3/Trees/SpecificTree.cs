using TreeV3.Nodes.Specific;

namespace TreeV3.Trees
{
    /// <summary>
    /// A specialized version of generic tree, with five-tiers.
    /// Tiers:
    ///     Tree 
    ///     └── LevelOneNodes (root)
    ///         └── LevelTwoNodes
    ///             └── LevelTreeNodes
    ///                 └── LevelFourNodes
    ///                     └── LevelFiveNodes
    /// </summary>
    public class SpecificTree : GenericTree<LevelOneNode>
    {
        public SpecificTree(LevelOneNode root) : base(root)
        {
        }
    }
}
