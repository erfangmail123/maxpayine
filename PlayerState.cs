using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public float moveSpeed = 5f;
    public float bulletForce = 20f;

    public void UpgradeHealth(int amount)
    {
        maxHealth += amount;
        GetComponent<Health>().currentHealth += amount;
    }

    public void UpgradeSpeed(float amount)
    {
        moveSpeed += amount;
        GetComponent<PlayerController>().moveSpeed = moveSpeed;
    }

    public void UpgradeBullet(float amount)
    {
        bulletForce += amount;
        GetComponent<PlayerShooting>().bulletForce = bulletForce;
    }
}
