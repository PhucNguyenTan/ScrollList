using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Node;
using Scrolllist;
using UnityEngine.Events;

public sealed class ScrollListTest : ScrollListGroupBase<Skill, NodeSkill, SlotSkill, GroupSkillBoard>
{

    private List<GroupSkillBoard> groups;

    private int chosenIndex;

    protected override void Awake()
    {
        base.Awake();
        var current = 0;

        //????Maybe find a way to create the Dictionary outside, instead of doing it here.
        var testData = DataManager.Instance.TestSkills.OrderByDescending(x => x.Id);
        var testDict = testData
            .GroupBy(sk => sk.Level)
            .ToDictionary(gr => gr.Key, g => g.ToList());

        var test = testDict.OrderByDescending(g => g.Key);
        UpdateListGroup(testDict);
    }

    public override void UpdateListGroup(Dictionary<int, List<Skill>> skills)
    {
        foreach (var key in skills.Keys)
        {
            //????Check for a better way
            var TestSkills = skills[key].OrderBy(x => x.Id).ToList();

            var group = Instantiate(groupPrefab, scroll.content);
            group.SetupGroup(TestSkills);
        }
    }
}
