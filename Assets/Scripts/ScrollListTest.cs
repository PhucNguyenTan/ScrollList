using System.Collections.Generic;
using System.Linq;
using Scrolllist;
using UnityEngine.Events;

public class ScrollListTest : ScrollListBase<NodeGroupData, NodeGroup, SlotBase<NodeGroupData, NodeGroup>>
{
    

    protected override void Awake()
    {
        base.Awake();
        var current = 0;
        // NOT CORRECT - Should Make group
        foreach (var data in DataManager.Instance.TestGroupData)
        {
            if(current != data.Level)
            {
                current = data.Level;
                data.SetShowLevel(true);
            }
            else 
            {
                data.SetShowLevel(false);
            }
        }

        var testDataSorted = DataManager.Instance.TestGroupData.OrderByDescending(x => x.IdSkill).ToList();
        UpdateList(testDataSorted);
    }
}
