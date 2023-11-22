using System.Collections.Generic;
using System.Linq;
using Scrolllist;

public class ScrollListTest : ScrollListBase<NodeGroupData, NodeGroup, SlotBase<NodeGroupData, NodeGroup>>
{

    private List<NodeGroupData> TestData = new List<NodeGroupData>()
    {
        new NodeGroupData(3, 2, 103, 30),
        new NodeGroupData(4, 2, 104, 40),
        new NodeGroupData(5, 3, 105, 50),
        new NodeGroupData(6, 3, 106, 60),
        new NodeGroupData(7, 3, 107, 70),
        new NodeGroupData(8, 4, 108, 80),
        new NodeGroupData(9, 4, 109, 90),
        new NodeGroupData(10, 4, 110, 100),
        new NodeGroupData(11, 5, 111, 110),
    };

    protected override void Awake()
    {
        base.Awake();
        var current = 0;
        // NOT CORRECT - Look into making group
        foreach (var data in TestData)
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

        var testDataSorted = TestData.OrderByDescending(x => x.IdSkill).ToList();
        UpdateList(testDataSorted);
    }
}
