﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string Scene;

    public void Click()
    {
       SceneManager.LoadScene(Scene);
    }
}
