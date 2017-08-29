using TreeV3.Ids;
using TreeV3.Payloads;
using TreeV3.Algorithms;

namespace TreeV3.Nodes.Specific
{
    public class SpecificNode : TreeNode<SpecificId> { public SpecificNode(SpecificId id, object payload, IChildFinder<SpecificId> finder = null) : base(id, payload, finder) { } }

    public class LevelOneNode : SpecificNode { public LevelOneNode(SpecificId key, LevelOne payload) : base(key, payload) { } }

    public class LevelTwoNode : SpecificNode { public LevelTwoNode(SpecificId key, LevelTwo payload) : base(key, payload) { } }

    public class LevelThreeNode : SpecificNode { public LevelThreeNode(SpecificId key, LevelThree payload) : base(key, payload) { } }

    public class LevelFourNode : SpecificNode { public LevelFourNode(SpecificId key, LevelFour payload) : base(key, payload) { } }

    public class LevelFiveNode : SpecificNode { public LevelFiveNode(SpecificId key, LevelFive payload) : base(key, payload) { } }
}
