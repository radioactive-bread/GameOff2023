﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheScenesManager : MonoBehaviour
{
    public static int round; 
    public static int[] GameSpecifics = {1, 6, 3, 4, 5, 6, 3, 2, 1, 7, 5, 4};
 
    public static bool PlayerA = true;


    public void clickedPlayerA() {
        PlayerA = true;
        SceneManager.LoadScene("PlayerA");
    }

    public void clickedPlayerB() {
        PlayerA = false;
        SceneManager.LoadScene("PlayerB");
    }

    public void LoadWeighingScene() {

        if (round < 6) {SceneManager.LoadScene("WeighingScene");}
        else {SceneManager.LoadScene("FinalJudgment");}
    }
    
    public void LoadMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void LoadLevelScene() {
        SceneManager.LoadScene("LevelScene");
    }

    


}
