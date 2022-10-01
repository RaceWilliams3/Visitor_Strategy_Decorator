using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponConfig")]
public class WeaponConfig : ScriptableObject, IWeapon
{
    [Range(0, 60)]
    [SerializeField] private float rate;

    [Range(0, 50)]
    [SerializeField] private float range;

    [Range(0, 100)]
    [SerializeField] private float strength;

    [Range(0, 5)]
    [SerializeField] private float cooldown;

    public string weaponName;
    public GameObject weaponPrefab;
    public string weaponDescription;

    public float Rate
    {
        get { return rate; }
    }

    public float Range
    {
        get { return range; }
    }

    public float Strength
    {
        get { return strength; }
    }

    public float Cooldown
    {
        get { return cooldown; }
    }

    
}
