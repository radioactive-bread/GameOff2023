using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI displayRandomNumber;
    void Start()
    {
        int randomNumber = Random.Range(11, 79);
        displayRandomNumber.text = randomNumber.ToString();
        int secondDigit = randomNumber % 10;
        int firstDigit = (randomNumber - secondDigit) / 10;

        for(int i=0; i < 8; i += 2){
            TheScenesManager.GameSpecifics[i] = TheScenesManager.GameSpecifics[i] + secondDigit;
            if (TheScenesManager.GameSpecifics[i] > 7) {
                TheScenesManager.GameSpecifics[i] = TheScenesManager.GameSpecifics[i] - 8;
            }
        }

        for(int i=1; i < 8; i += 2) {
            TheScenesManager.GameSpecifics[i] = TheScenesManager.GameSpecifics[i] + firstDigit;
            if (TheScenesManager.GameSpecifics[i] > 7) {
                TheScenesManager.GameSpecifics[i] = TheScenesManager.GameSpecifics[i] - 8;
            }
        }

        Debug.Log(TheScenesManager.GameSpecifics[0] + "," + TheScenesManager.GameSpecifics[1] +"," + TheScenesManager.GameSpecifics[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
