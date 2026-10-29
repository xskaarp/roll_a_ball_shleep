using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 1;
   private PlayerHealth _health;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(_health == null)
            {
                _health = collision.gameObject.GetComponent<PlayerHealth>();
            }
            _health.TakeDamage(damage);
        }
    }
}
