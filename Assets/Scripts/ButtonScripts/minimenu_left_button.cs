﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 

public class minimenu_left_button : MonoBehaviour
{

    public void goto_mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
