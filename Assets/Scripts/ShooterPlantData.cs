using UnityEngine;

[CreateAssetMenu(fileName = "ShooterPlant", menuName = "Scriptable Objects/ShooterPlant")]
public class ShooterPlantData : PlantData
{
    public float damage;
    public float range;
    public GameObject attackParticles;
    public GameObject bulletPrefab;
    public float shootTime;
    public float fireRate;
    
}
