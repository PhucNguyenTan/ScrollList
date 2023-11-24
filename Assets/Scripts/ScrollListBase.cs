

using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Scrolllist
{
    public abstract class ScrollListGroupBase<D, V, S, G>: MonoBehaviour
        where D : NodeDataBase
        where V : NodeViewBase<D>
        where S : SlotBase<D, V>
        where G : GroupBase<D, V, S>
    {
        protected ScrollRect scroll;

        [SerializeField]
        protected G groupPrefab;

        protected virtual void Awake()
        {
            scroll = GetComponent<ScrollRect>();
        }


        private void Update()
        {

        }

        public abstract void UpdateListGroup(Dictionary<int, List<D>> data);
    }

}
