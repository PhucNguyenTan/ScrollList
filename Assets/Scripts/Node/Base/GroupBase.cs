using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupBase<D,V,S> : MonoBehaviour
    where D : NodeDataBase
    where V : NodeViewBase<D>
    where S : SlotBase<D, V>
{
    [SerializeField]
    private S slot;

    private List<D> datas;
    private List<S> slots;

    public List<S> Slots { get { return slots; } }

    public void UpdateSlot(List<D> datasNew)
    {
        datas.Clear();
        slots.Clear();
        datas.AddRange(datasNew);

        foreach (D data in datas)
        {
            slots.Add(Instantiate(slot, transform));
        }
    }
}
