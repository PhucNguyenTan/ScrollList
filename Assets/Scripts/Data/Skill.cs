using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    private int id;
    private string description;

    public int Id { get { return id; } }
    public string Description { get { return description; } }

    public Skill(int id, string description)
    {
        this.id = id;
        this.description = description;
    }
}
