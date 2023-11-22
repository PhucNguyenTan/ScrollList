using UnityEngine;

public class NodeGroup : NodeViewBase<NodeGroupData>
{
    [SerializeField]
    private NodeLevel level;
    [SerializeField]
    private NodeSkill skill;
    [SerializeField]
    private NodeSkill skillSpecial;

    public override void UpdateNodeView(NodeGroupData data)
    {
        level.UpdateLevel(data.Level);
        skill.UpdateSkill(data.IdSkill);
        skillSpecial.UpdateSkill(data.IdSkillSpecial);
        level.gameObject.SetActive(data.ShowLevel);
    }
}
