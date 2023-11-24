using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Node;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GroupSkillBoard : GroupBase<Skill, NodeSkill, SlotSkill>
{
    [SerializeField]
    private TextMeshProUGUI Level;

    private void Awake()
    {
        rectTransform = transform.GetComponent<RectTransform>();

    }

    public void SetupGroup(List<Skill> skills)
    {
        Level.text = "lv." + skills[0].Level;

        for(var i = 0; i < skills.Count;i++)
        {
            var slot = Instantiate(slotPrefab, content);
            slot.Set(i, skills[i]);
        }
        //???? Is this needed
        LayoutRebuilder.ForceRebuildLayoutImmediate(content);

        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, content.rect.height);
    }
}
