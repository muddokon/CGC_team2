using UnityEngine;

[CreateAssetMenu(fileName = "BichoTop",menuName = "Bichos/BichoBottom",order =2)]
public class BichoBottom : ScriptableObject
{
    public string bichoName;
    public Bicho.Families familyBottom;
    public Sprite sprite;
}