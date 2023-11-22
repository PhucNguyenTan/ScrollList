using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NodeSkill : MonoBehaviour
{
    private TextMeshProUGUI TextSkillId;

    private void Awake()
    {
        TextSkillId = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void UpdateSkill(int skillId)
    {
        TextSkillId.text = "Id" + skillId;
    }
}
