using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManagement : MonoBehaviour
{
    public int YourConfessionsNumber;

    public TextMeshProUGUI YourConfessionsOutput;
    public TextMeshProUGUI TextRound;
    // Start is called before the first frame update
    void Start() {
        YourConfessionsNumber = 0;
        TheScenesManager.round++;
        //int roundCopy = TheScenesManager.round;
        Debug.Log(TheScenesManager.round);
        TextRound.text = "Round " + TheScenesManager.round.ToString();
    }

    // Update is called once per frame
    void Update() {
        
    }
    
    public void PickConfessionsPlus() {
        if (YourConfessionsNumber < 7) {
            YourConfessionsNumber++;
            YourConfessionsOutput.text = YourConfessionsNumber.ToString();
        }
    }

    public void PickConfessionsMinus() {
        if (YourConfessionsNumber > 0) {
            YourConfessionsNumber = YourConfessionsNumber - 1;
            YourConfessionsOutput.text = YourConfessionsNumber.ToString();
        }
    }

    /*private void GoToWeighingScene() {
        TheScenesManager.Instance.LoadWeighing();
    }*/

}
