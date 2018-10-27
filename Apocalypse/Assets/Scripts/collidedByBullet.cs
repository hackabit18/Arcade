using UnityEngine;

public class collidedByBullet : MonoBehaviour
{

   

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject,0.2f);
        }
    }
}
