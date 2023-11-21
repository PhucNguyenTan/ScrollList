using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NodeLevel : MonoBehaviour
{
    private TextMeshProUGUI TextLevel;

    private void Awake()
    {
        TextLevel = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void UpdateLevel()
    {

    }
}
