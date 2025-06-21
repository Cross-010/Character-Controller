using UnityEngine;

public enum WeaponType
{
    None,
    Melee,
    Ranged,
};

public enum Rarity
{
    Common,
    Uncommon,
    Epic,
    Legendary,
};

[CreateAssetMenu(fileName = "Weapons", menuName = "Scriptable Objects/Weapons")]
public class Weapons : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public Sprite weaponIcon;

    public Rarity weaponRarity;

    public int weaponDamage;
    public float weaponSpeed;
    public float weaponRange;
    public int weaponDurability;

    public WeaponType weaponType;
}
