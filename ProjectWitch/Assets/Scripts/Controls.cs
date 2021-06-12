using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Witch WitchLeft;
    public Witch WitchRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float Vertical = Input.GetAxis("Vertical");
        float Horizontal = Input.GetAxis("Horizontal");
        Vertical += 0.1f;
        WitchLeft.Move(Horizontal, Vertical);
        WitchRight.Move(Horizontal, Vertical);
    }


}
