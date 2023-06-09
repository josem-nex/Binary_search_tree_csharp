namespace BinaryTree;

    /// <summary>La información necesario para imprimir el árbol en pantalla</summary>
    public class NodeInfo<TKey> where TKey : IComparable<TKey>
    {
        public ABBNode<TKey> Node;
        public string Text;
        public int StartPos;
        public int Size { get { return Text.Length; } }
        public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
        public NodeInfo<TKey> Parent, Left, Right;

    public NodeInfo(ABBNode<TKey> node, string text)
    {
        this.Node = node;
        Text = text;
    }
}

    
