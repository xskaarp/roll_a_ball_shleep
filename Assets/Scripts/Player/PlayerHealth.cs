using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int _maxHealth = 1;

    private void Start()
    {
        health = _maxHealth;
    }


    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
            PlayerRespawn.instance.EnableDeathScreen();
        }
    }
}
