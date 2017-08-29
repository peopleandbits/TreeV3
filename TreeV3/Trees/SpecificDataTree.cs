using TreeV3.Nodes.Specific;

namespace TreeV3.Trees
{
    public class SpecificDataTree
    {
        public SpecificDataTree(LevelOneNode root)
        {
            Root = root;
        }

        public LevelOneNode Root { get; private set; }
    }
}
