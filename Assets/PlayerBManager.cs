using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBManager : MonoBehaviour
{
    public TMP_InputField inputField; 

    public void readInput() {
        int.TryParse(inputField.text, out int inputNumber);

        int secondDigit = inputNumber % 10;
        int firstDigit = (inputNumber - secondDigit) / 10;

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
}
