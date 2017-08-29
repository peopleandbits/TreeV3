using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using TreeV3.Trees;
using TreeV3.Payloads;
using TreeV3.Nodes;
using TreeV3.Algorithms;

namespace TreeV3.Tests
{
    [TestClass]
    public class GenericNodesTest
    {
        [TestMethod]
        public void GivenTreeNodeWithStringKey_WhenInitialized_ThenItsContentOK()
        {
            var tree = GetStringKeyedTree();

            tree.Root.Children.Count.Should().Be(2);
            tree.Root.Children.First().Value.Children.Count.Should().Be(3);
            tree.Root.Children.Last().Value.Children.Count.Should().Be(2);
        }

        GenericTree<TreeNodeWithStringKey> GetStringKeyedTree()
        {
            var root = new TreeNodeWithStringKey("101", new LevelOne("SR101"));

            root.Add(new TreeNodeWithStringKey("201", new LevelTwo("R201")))
                .Add(new TreeNodeWithStringKey("202", new LevelTwo("R202")));

            root.Children["201"]
                .Add(new TreeNodeWithStringKey("301", new LevelThree("F301")))
                .Add(new TreeNodeWithStringKey("302", new LevelThree("F302")))
                .Add(new TreeNodeWithStringKey("303", new LevelThree("F303")));

            root.Children["202"]
                .Add(new TreeNodeWithStringKey("304", new LevelThree("L304")))
                .Add(new TreeNodeWithStringKey("305", new LevelThree("L305")));

            return new GenericTree<TreeNodeWithStringKey>(root);
        }
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
