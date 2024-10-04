using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/Weapon", order = 1)]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public int damage;
    public int durability;
}
