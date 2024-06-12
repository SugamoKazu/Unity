using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] private Vector3 deltaPositon;
    [SerializeField] private Vector3 rangePositon;
    
    Transform myTransform;
    Vector3 position_start;
    Vector3 position_now;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
        position_start = myTransform.position;
        position_now = position_start;        
    }

    // Update is called once per frame
    void Update()
    {
        position_now += direction*deltaPositon;
        if((position_start - position_now) == direction*rangePositon)
        {
            //Debug.Log("turn");
            direction *= -1;
        }
        myTransform.position = position_now;
        //Debug.Log(rangePositon);
        //Debug.Log(position_start - position_now);        
    }
}
