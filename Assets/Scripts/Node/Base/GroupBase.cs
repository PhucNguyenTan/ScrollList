using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupBase<D,V,S> : MonoBehaviour
    where D : NodeDataBase
    where V : NodeViewBase<D>
    where S : SlotBase<D, V>
{
    [SerializeField]
    protected S slotPrefab;
    [SerializeField]
    protected RectTransform content;

    protected RectTransform rectTransform;

    protected List<D> datas;
    protected List<S> slots;

    public List<S> Slots { get { return slots; } }

    
}
