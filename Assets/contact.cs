using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class contact : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HitCounter;
    private int count;
    private string colObject;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        HitCounter.text = string.Format("Hit wall {0}", count);
    
    }
    void OnCollisionEnter(Collision other)
    { 
        if(other.transform.root.gameObject.name == "Wall") //(other.gameObject.name == "Goal")
        {
            count += 1;
        }
        //else{
           //Debug.Log("NULL Object") ;
        //}
        Debug.Log(other.transform.root.gameObject.name);
        

    }
}
