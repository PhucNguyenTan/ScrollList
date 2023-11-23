using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager
{
    public static DataManager Instance;


    public List<NodeGroupData> TestGroupData = new List<NodeGroupData>()
    {
        new NodeGroupData(3, 2, 103, 30),
        new NodeGroupData(4, 2, 104, 40),
        new NodeGroupData(5, 3, 105, 50),
        new NodeGroupData(6, 3, 106, 60),
        new NodeGroupData(7, 3, 107, 70),
        new NodeGroupData(8, 4, 108, 80),
        new NodeGroupData(9, 4, 109, 90),
        new NodeGroupData(10, 4, 110, 100),
        new NodeGroupData(11, 5, 111, 110),
    };

    public List<Skill> TestSkills = new List<Skill>
    {
        new Skill(3, "Blue Magic"),
        new Skill(4, "Red Magic"),
        new Skill(5, "Black Magic"),
        new Skill(6, "Yellow Magic"),
        new Skill(7, "Spear"),
        new Skill(8, "Dagger"),
        new Skill(9, "Test skill 9"),
        new Skill(10, "Test skill 10"),
        new Skill(11, "Test skill 11"),
    };

    public UnityEvent<int> ChosenSkill = new();

    private DataManager() { }

    static DataManager()
    {
        Instance = new DataManager();
    }
}
