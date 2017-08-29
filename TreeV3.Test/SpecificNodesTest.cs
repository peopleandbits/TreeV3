using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Linq;
using TreeV3.Trees;
using TreeV3.Ids;
using TreeV3.Payloads;
using TreeV3.Nodes.Specific;

namespace TreeV3.Tests
{
    [TestClass]
    public class SpecificNodesTest
    {
        [TestMethod]
        public void GivenSpecificNodes_WhenInitialized_ThenItsContentOK()
        {
            var tree = GetAdjustTree();

            tree.Root.Children.Count.Should().Be(2);
            tree.Root.Children.First().Value.Children.Count.Should().Be(3);
            tree.Root.Children.Last().Value.Children.Count.Should().Be(2);
        }

        [TestMethod]
        public void GivenSpecificNodes_WhenAddExistingKey_ThenExceptionIsThrown()
        {
            var root = new LevelOneNode(new SpecificId(101), new LevelOne("SR101"));

            var rnode = new LevelTwoNode(new SpecificId(202), new LevelTwo("R201"));
            root.Add(rnode);

            root.Invoking(y => y.Add(rnode)).ShouldThrow<ArgumentException>();
        }

        [TestMethod]
        public void GivenSpecificNodes_WhenGetChildNode_ThenItAndItsPayloadAreFound()
        {
            var tree = GetAdjustTree();
            var node = tree.Root.GetChildNode(new SpecificId(201));
            node.Should().NotBeNull();
        }

        [TestMethod]
        public void GivenSpecificNodes_WhenGetPayload_ThenPayloadIsFound()
        {
            var tree = GetAdjustTree();
            var node = tree.Root.GetChildNode(new SpecificId(201));
            var rechnung = node.GetPayload<LevelTwo>();
            rechnung.Should().NotBeNull();
            rechnung.Should().BeOfType<LevelTwo>();
        }
                
        [TestMethod]
        public void GivenSpecificNodes_WhenAbsentNodeIsSearched_ThenItsNotFound()
        {
            var tree = GetAdjustTree();
            
            var node = tree.Root.GetChildNode(new SpecificId(234));
            node.Should().BeNull();
        }

        SpecificDataTree GetAdjustTree()
        {
            var root = new LevelOneNode(new SpecificId(101), new LevelOne("SR101"));

            root.Add(new LevelTwoNode(new SpecificId(201), new LevelTwo("R201")))
                .Add(new LevelTwoNode(new SpecificId(202), new LevelTwo("R202")));

            root.Children[new SpecificId(201)]
                .Add(new LevelThreeNode(new SpecificId(301), new LevelThree("F301")))
                .Add(new LevelThreeNode(new SpecificId(302), new LevelThree("F302")))
                .Add(new LevelThreeNode(new SpecificId(303), new LevelThree("F303")));

            root.Children[new SpecificId(202)]
                .Add(new LevelThreeNode(new SpecificId(304), new LevelThree("L304")))
                .Add(new LevelThreeNode(new SpecificId(305), new LevelThree("L305")));

            return new SpecificDataTree(root);
        }
    }
}
