using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheScenesManager : MonoBehaviour
{
    // Tutorial for future reference: https://youtu.be/jrPTpD2eAMw?feature=shared
    /*public static TheScenesManager Instance;
    // Start is called before the first frame update
    private void Awake () {
        Instance = this;
    }

     public enum Scene {
        Menu,
        Tutorial,
        LevelScene,
        WeighingScene,
        FinalJudgement
    }

    public void LoadScene(Scene scene) {
        TheScenesManager.LoadScene(scene.ToString());
    }

    public void LoadNewRound() {
        TheScenesManager.LoadScene(Scene.LevelScene.ToString());
    }

    public void LoadWeighing() {
        //if round < 6
        TheScenesManager.LoadScene(Scene.WeighingScene.ToString());
    }*/

    public static int round; 

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
