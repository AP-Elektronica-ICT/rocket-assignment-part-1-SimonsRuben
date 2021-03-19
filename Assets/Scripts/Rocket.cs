using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    public Transform trans;
    public Rigidbody rigid;



    private bool jump;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        rigid.AddForce(0, v, 0);


        float h = CrossPlatformInputManager.GetAxis("Horizontal"); 
        //rigid.AddForce(0, 0, h * 0.2f);
        trans.Rotate(h*0.1f , 0, 0);
        
        jump = CrossPlatformInputManager.GetButton("Jump");
        if (jump)
        {
            rigid.AddRelativeForce(0, 1, 0);
        }
        
    }
}
