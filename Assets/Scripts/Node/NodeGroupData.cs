


using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NodeGroupData : NodeDataBase
{
    private int idSkill = 0;
    private int level = 0;
    private int idSkillSpecial = 0;
    private int expNeed = 0;
    private bool showLevel = false;

    public int IdSkill { get { return idSkill; } }
    public int Level { get { return level; } }
    public int IdSkillSpecial { get { return idSkillSpecial; } }
    public int IdexpNeedSkill { get { return expNeed; } }
    public bool ShowLevel { get { return showLevel; } }

    public NodeGroupData(int idSkill, int level, int idSkillSpecial, int expNeed)
    {
        this.idSkill = idSkill;
        this.level = level;
        this.idSkillSpecial = idSkillSpecial;
        this.expNeed = expNeed;
    }

    public void SetShowLevel(bool isShow)
    {
        this.showLevel = isShow;
    }
}
