using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlotBase<D, V> : MonoBehaviour
    where D: NodeDataBase
    where V: NodeViewBase<D>
{
    private int index;
    private bool isVisible;

    private V view;

    private void Awake()
    {
        view = GetComponentInChildren<V>();
    }

    public void Set(int index, D data)
    {
        this.index = index;
        view.UpdateNodeView(data);
    }
}