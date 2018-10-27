
using UnityEngine;

public class killEnemy : MonoBehaviour {
    public Transform player;
    public SpriteRenderer rb;
   // private void Start()
    //{
        
    //}

   void FixedUpdate () {
        float dist = player.position.x - rb.transform.position.x;
      //Debug.Log("dist = " + dist);
        if (dist > 0)
        { rb.flipX = false; }
        if (dist>-3 && dist<0)
        {rb.flipX = true;}
        else
        { rb.flipX = false; }

        
    }

   
}
