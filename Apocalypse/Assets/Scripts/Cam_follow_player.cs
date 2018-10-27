
using UnityEngine;

public class Cam_follow_player : MonoBehaviour
{

    public Transform player;
    private float lockPos;
    private void Start()
    {

        lockPos = player.position.y;
       

    }
   
    public Transform target;
    Vector3 velocity = Vector3.zero;
    public float smoothtime = .15f;
    public bool Xmaxenabled = false;
    public float Xmaxvalue = 0;
    public bool Xminenabled = false;
    public float Xminvalue = 0;
    /*public bool Ymaxenabled = false;
    public float Ymaxvalue = 0;
    public bool Yminenabled = false;
    public float Yminvalue = 0;*/
    private void FixedUpdate()
    {
        Vector3 targetpos = target.position;
       /* if (Yminenabled && Ymaxenabled)
        {
            targetpos.y = Mathf.Clamp(target.position.y, Yminvalue, Ymaxvalue);
        }
        else if (Yminenabled)
            targetpos.y = Mathf.Clamp(target.position.y, Yminvalue, target.position.y);
        else if (Ymaxenabled)
            targetpos.y = Mathf.Clamp(target.position.y, target.position.y, Ymaxvalue);*/
        //horizontal
        if (Xminenabled && Xmaxenabled)
        {
            targetpos.x = Mathf.Clamp(target.position.x, Xminvalue, Xmaxvalue);
        }
        if (Xminenabled)
            targetpos.x = Mathf.Clamp(target.position.x, transform.position.x, target.position.x);
        else if (Xmaxenabled)
            targetpos.x = Mathf.Clamp(target.position.x, target.position.x, Xmaxvalue);
        targetpos.z = transform.position.z;
        targetpos.y = lockPos;
        transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref velocity, smoothtime);
    }

}



