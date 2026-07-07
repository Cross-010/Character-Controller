using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Scriptable Objects/Items")]
public class Items : ScriptableObject
{
    public string itemName;
    public string itemType;
    public string itemDescription;
    public Sprite icon;

    public float amount;
}
