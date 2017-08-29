using System.Collections.Generic;

namespace TreeV3.Nodes
{
    public interface ITreeNode<T> : ISelfAwareness<T>, IPayloadAwareness, IChildAwareness<T>
    {
    }

    public interface ISelfAwareness<T>
    {
        T Id { get; set; }
        string Name { get; set; }
    }

    public interface IChildAwareness<T>
    {
        IDictionary<T, ITreeNode<T>> Children { get; set; }  // keys are json strings
        ITreeNode<T> Add(ITreeNode<T> node);
        ITreeNode<T> GetChildNode(T id, ITreeNode<T> node);
    }

    public interface IPayloadAwareness
    {
        bool HasPayload { get; }
        object Payload { get; set; }
        T GetPayload<T>() where T : class;
    }
}
