using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWall : MonoBehaviour
{
    [SerializeField] float rotateAngle;
    private float angle;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;        
    }

    // Update is called once per frame
    void Update()
    {
        angle = rotateAngle/60;
        myTransform.Rotate(0f, angle,0f, Space.World); 
    }
}
