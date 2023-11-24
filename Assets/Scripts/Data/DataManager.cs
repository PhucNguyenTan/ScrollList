using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager
{
    public static DataManager Instance;


    public List<Skill> TestSkills = new List<Skill>
    {
        new Skill(3,2 ,  "Blue Magic"),
        new Skill(4,2, "Red Magic"),
        new Skill(5,3, "Black Magic"),
        new Skill(6,3, "Yellow Magic"),
        new Skill(7,4, "Spear"),
        new Skill(8,4, "Dagger"),
        new Skill(9,4, "Test skill 9"),
        new Skill(10,4, "Test skill 10"),
        new Skill(11,5, "Test skill 11"),
    };

    public UnityEvent<int> ChosenSkill = new();

    private DataManager() { }

    static DataManager()
    {
        Instance = new DataManager();
    }
}
