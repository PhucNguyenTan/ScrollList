using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill: NodeDataBase
{
    private int id;
    private int level;
    private string description;

    public int Id { get { return id; } }
    public string Description { get { return description; } }
    public int Level { get { return level; } }

    public Skill(int id, int level, string description)
    {
        this.id = id;
        this.level = level;
        this.description = description;
    }
}
