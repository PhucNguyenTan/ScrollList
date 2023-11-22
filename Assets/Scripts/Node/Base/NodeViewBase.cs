using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NodeViewBase<Data> : MonoBehaviour
    where Data: NodeDataBase
{
    public abstract void UpdateNodeView(Data data);

}
