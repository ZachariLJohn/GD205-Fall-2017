﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loadscene2 : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)

    {

        SceneManager.LoadScene(sceneIndex);

    }
}
