using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NodeSkill : NodeViewBase<Skill>
{
    private TextMeshProUGUI TextSkillId;

    private void Awake()
    {
        TextSkillId = GetComponentInChildren<TextMeshProUGUI>();
    }

    public override void UpdateNodeView(Skill skill)
    {
        TextSkillId.text = "Id" + skill.Id;
    }
}
