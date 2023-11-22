

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Scrolllist
{
    public class ScrollListBase<D, V, S>: MonoBehaviour
        where D : NodeDataBase
        where V : NodeViewBase<D>
        where S : SlotBase<D, V>
    {
        protected ScrollRect scroll;

        [SerializeField]
        protected S slot;

        protected virtual void Awake()
        {
            scroll = GetComponent<ScrollRect>();
        }


        private void Update()
        {

        }

        public void UpdateList(List<D> datas)
        {
            UpdateSlot(datas.Count);
            var slots = scroll.content.GetComponentsInChildren<S>();
            
            for(var i = 0; i < datas.Count; i++)
            {
               slots[i].Set(i, datas[i]);
            }
        }

        private void UpdateSlot(int slotCountNew)
        {
            var differenceCount = slotCountNew - scroll.content.childCount;

            if (differenceCount == 0) return;
            if (differenceCount > 0)
                AddSlot(differenceCount);
            else
                RemoveSlot(-differenceCount);
        }


        private void AddSlot(int num)
        {
            for(var i = 0; i < num; i++)
            {
                Instantiate(slot, scroll.content);
            }
        }

        private void RemoveSlot(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Destroy(scroll.content.transform.GetChild(i).gameObject);
            }
        }
    }

}
