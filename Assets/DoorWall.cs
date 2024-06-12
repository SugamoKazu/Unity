using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWall : MonoBehaviour
{
    [SerializeField] float rotateAngle;
    [SerializeField] Vector3 rotateCenter;//  = new Vector3(0f, 1f, -3f);
    
    Transform myTransform;
    Vector3 axis = new Vector3(0f, 1f, 0f); 
    
    private float angle;
    private float elapsedTime;
    int direction;
    float angle_start;
    float angle_now;  
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;   
        elapsedTime = 0.0f;
        direction = 1;
        
        angle_start = 0.0f;
        angle_now = 0.0f;  
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //Debug.Log(elapsedTime);
        if(2 < elapsedTime)
        {
            angle = rotateAngle/60;
            angle_now += angle;
            //Debug.Log(angle_now);
            myTransform.RotateAround(rotateCenter, axis, direction*angle);
            //Debug.Log(angle_now - angle_start);
            if((angle_now - angle_start) == 90)
            {  
                direction *= -1;
                angle_now = 0;
                angle_start = 0;
                elapsedTime = 0.0f;
            }
        }
    }
}
/*

        Debug.Log(elapsedTime);
        
            angle = rotateAngle*Time.deltaTime;
            myTransform.Rotate(0f, direction*angle,0f, Space.World);
            rotate_now += angle;
            //Debug.Log(rotate_now);
            if((rotate_start - rotate_now) > 90)
            {
                //Debug.Log("turn");
                
                
            }
        }
*/