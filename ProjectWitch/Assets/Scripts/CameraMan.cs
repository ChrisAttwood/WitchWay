using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour
{

    public Transform WitchOne;
    public Transform WitchTwo;
    public GameObject GameOver;

    float gameOverDistance = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 average = (WitchOne.transform.position + WitchTwo.transform.position)/2f;

        transform.position = new Vector3(0f, 10f, average.z - 2f);


        if (Vector3.Distance(average, WitchTwo.transform.position) > gameOverDistance)
        {
            GameOver.SetActive(true);
        }
        if (Vector3.Distance(average, WitchOne.transform.position) > gameOverDistance)
        {
            GameOver.SetActive(true);
        }
    }
}
