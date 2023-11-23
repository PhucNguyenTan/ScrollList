using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI title;
    [SerializeField]
    private TextMeshProUGUI description;
    [SerializeField]
    private Image image;

    [SerializeField]
    private Button btnAcquire;

    private void Start()
    {
        DataManager.Instance.ChosenSkill.AddListener(UpdatePanel);
    }

    private void OnDestroy()
    {
        DataManager.Instance.ChosenSkill.RemoveListener(UpdatePanel);

    }

    public void UpdatePanel(int idSkill)
    {
        var skill = DataManager.Instance.TestSkills.FirstOrDefault(x => x.Id == idSkill);
        title.text = skill.Description;

    }
}
