using UnityEngine;

[CreateAssetMenu(fileName = "Plants", menuName = "Scriptable Objects/Plants")]
public class PlantData : ScriptableObject
{
    public string appearSound;
    public string attackSound;
    public string deathSound;
    public float maxHealth;
}
