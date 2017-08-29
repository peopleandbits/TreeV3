using TreeV3.Nodes;

namespace TreeV3.Algorithms
{
    public interface IChildFinder<T>
    {
        ITreeNode<T> FindChild(T id, ITreeNode<T> node);
    }

    public class ChildFinder<T> : IChildFinder<T>
    {
        public ITreeNode<T> FindChild(T id, ITreeNode<T> node)
        {
            if (node.Children.ContainsKey(id))
                return node.Children[id];
            else
            {
                // loop thru all children
                foreach (var c in node.Children)
                {
                    var found = FindChild(id, c.Value);
                    if (found != null)
                        return found;
                }
            }

            return null;
        }
    }
}