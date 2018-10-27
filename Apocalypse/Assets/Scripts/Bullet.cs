
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // public GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2.0f);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("enemy"))
        {
            Debug.Log("enemy dead");
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<Demo>().counter += 50;

        }
        if (collider.gameObject.CompareTag("bush"))
        {
            Debug.Log("destroy bullet");
            Destroy(gameObject);


        }


    }
}




