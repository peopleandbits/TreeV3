namespace TreeV3.Trees
{
    /// <summary>
    /// A generic tree with unlimited amount of tiers.
    /// Tiers:
    ///     GenericTree 
    ///     └── ITreeNode<T> (root)
    ///         └── ITreeNode<T>
    ///             └── ITreeNode<T>
    ///                 └── ITreeNode<T>
    ///                     └── etc...
    /// </summary>
    public class GenericTree<T>
    {
        public GenericTree(T root)
        {
            Root = root;
        }

        public T Root { get; private set; }
    }
}
