using UnityEngine;

[CreateAssetMenu(fileName = "BichoTop",menuName = "Bichos/BichoTop",order =1)]
public class BichoTop : ScriptableObject
{
    public string bichoName;
    public Bicho.Families familyTop;
    public Sprite sprite;
}
