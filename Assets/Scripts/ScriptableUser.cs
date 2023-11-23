using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable/UserData")]
public class ScriptableUser : ScriptableObject
{
    public int Level;
    public List<int> SkillAcquired;
}
