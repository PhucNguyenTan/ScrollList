using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBase<Data, View> : MonoBehaviour
    where Data: NodeDataBase
    where View: NodeViewBase<Data>
{
    private int index;
    private bool isVisible;

    private View view;

    private void Awake()
    {
        view = GetComponentInChildren<View>();
    }

    public void Set(int index, Data data)
    {
        this.index = index;
        view.UpdateNodeView(data);
    }
}