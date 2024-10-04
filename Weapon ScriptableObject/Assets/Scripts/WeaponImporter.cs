using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class WeaponImporter : MonoBehaviour
{
    [MenuItem("Tools/Import Weapons from CSV")]
    public static void ImportWeaponsFromCSV()
    {
        string filePath = "Assets/Weapons/weapons.csv";
        string[] dataLines = File.ReadAllLines(filePath);

        for (int i = 1; i < dataLines.Length; i++)
        {
            string[] weaponData = dataLines[i].Split(',');

            string weaponName = weaponData[0];
            int damage = int.Parse(weaponData[1]);
            int durability = int.Parse(weaponData[2]);

            Weapon newWeapon = ScriptableObject.CreateInstance<Weapon>();
            newWeapon.weaponName = weaponName;
            newWeapon.damage = damage;
            newWeapon.durability = durability;

            string assetPath = $"Assets/Weapons/{weaponName}.asset";
            AssetDatabase.CreateAsset(newWeapon, assetPath);
        }

        AssetDatabase.SaveAssets();
        Debug.Log("Weapons imported succesffuly.");
    }
}
