using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class NodeViewBase<Data> : MonoBehaviour
    where Data: NodeDataBase
{
    private Button button = null;
    private Data data;
    private Action<Data> onClick = null;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        
    }

    private void OnClick()
    {
        onClick?.Invoke(data);
    }
    public abstract void UpdateNodeView(Data data);

    public void SetOnClick(Action<Data> onclick)
    {
        this.onClick = onclick;
    } 

}
