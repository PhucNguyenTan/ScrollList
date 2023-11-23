

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Scrolllist
{
    public class ScrollListBase<D, V, S, G>: MonoBehaviour
        where D : NodeDataBase
        where V : NodeViewBase<D>
        where S : SlotBase<D, V>
        where G : GroupBase<D, V, S>
    {
        protected ScrollRect scroll;

        protected virtual void Awake()
        {
            scroll = GetComponent<ScrollRect>();
        }


        private void Update()
        {

        }

        public void UpdateList(List<G> groups)
        {
            foreach (var group in groups)
            {
                scroll.content. group.Slots;
            }
        }
    }

}
