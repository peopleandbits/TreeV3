using System.Collections.Generic;
using TreeV3.Algorithms;

namespace TreeV3.Nodes
{
    public class TreeNode<T> : ITreeNode<T> where T : class
    {
        public TreeNode(T id, object payload, IChildFinder<T> finder = null)
        {
            Id = id;
            Payload = payload;
            Children = new Dictionary<T, ITreeNode<T>>();

            if (finder == null)
                _Finder = new ChildFinder<T>();
            else
                _Finder = finder;
        }

        #region Fields
        static IChildFinder<T> _Finder;
        #endregion

        #region ITreeNode

        #region ISelfAwareness
        public T Id { get; set; }
        public string Name { get; set; }
        #endregion
        
        #region IPayloadAwareness
        public bool HasPayload { get { return Children.Count > 0; } }

        public object Payload { get; set; }

        public P GetPayload<P>() where P : class
        {
            if (Payload is P)
                return Payload as P;

            return null;
        }
        #endregion

        #region IChildAwareness
        public IDictionary<T, ITreeNode<T>> Children { get; set; }

        public ITreeNode<T> Add(ITreeNode<T> node)
        {
            try
            {
                Children.Add(node.Id, node);
                return this as ITreeNode<T>;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public ITreeNode<T> GetChildNode(T id, ITreeNode<T> node = null)
        {
            if (node == null)
                node = this;

            return _Finder.FindChild(id, node);
        }

        #endregion

        #endregion
    }
}
