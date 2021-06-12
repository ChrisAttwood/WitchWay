using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{

    public Transform WitchOne;
    public Transform WitchTwo;
   

    float gameOverDistance = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.IsGameOver) return;




        //Vector3 pos = transform.position;

        //pos.z += 0.01f;


        //transform.position = pos;




        //if (Vector3.Distance(average, WitchTwo.transform.position) > gameOverDistance)
        //{
        //    GameManager.instance.GameOver();
        //}
        //if (Vector3.Distance(average, WitchOne.transform.position) > gameOverDistance)
        //{
        //    GameManager.instance.GameOver();
        //}


        Vector3 average = (WitchOne.transform.position + WitchTwo.transform.position) / 2f;

        transform.position = new Vector3(0f, 10f, average.z - 5f);




        if (Vector3.Distance(average, WitchTwo.transform.position) > gameOverDistance)
        {
            GameManager.instance.GameOver();
        }
        if (Vector3.Distance(average, WitchOne.transform.position) > gameOverDistance)
        {
            GameManager.instance.GameOver();
        }
    }
}
