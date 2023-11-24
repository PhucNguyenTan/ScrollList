using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NodeSkill : NodeViewBase<Skill>
{
    private TextMeshProUGUI textSkillId = null;

    private void Awake()
    {
        textSkillId = GetComponentInChildren<TextMeshProUGUI>();
    }

    public override void UpdateNodeView(Skill skill)
    {
        textSkillId.text = "Id" + skill.Id;
    }
}
