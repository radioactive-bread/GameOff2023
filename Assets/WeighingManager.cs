using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeighingManager : MonoBehaviour
{
    public static int scoreYou = 0;
    public static int scorePartner = 0;

    public int PartnersRealNumber;
    public int TemporaryStorage;

    void Start()
    {
      Debug.Log("YourConfessionsNumber = " + LevelManagement.YourConfessionsNumber + " & Partner = " + LevelManagement.selectedHieroglyph); 
      // check who's playing and find out what your partners real number was

      if (TheScenesManager.PlayerA == true) {
        PartnersRealNumber = LevelManagement.selectedHieroglyph - TheScenesManager.GameSpecifics[2 * TheScenesManager.round - 1];
        Debug.Log("Partner's Real Number was: " + PartnersRealNumber);
      }
      else {
        PartnersRealNumber = LevelManagement.selectedHieroglyph - TheScenesManager.GameSpecifics[2 * TheScenesManager.round - 2];
      }
     
      ; 
      // actual weighing
      if (LevelManagement.YourConfessionsNumber > PartnersRealNumber) {
        scoreYou = scoreYou + LevelManagement.YourConfessionsNumber;
        scorePartner = scorePartner + 7;
      }
      if (LevelManagement.YourConfessionsNumber == PartnersRealNumber) {
        TemporaryStorage = scoreYou;
        scoreYou = scorePartner;
        scorePartner = TemporaryStorage;
      }
      if (LevelManagement.YourConfessionsNumber < PartnersRealNumber) {
        scorePartner = scorePartner + LevelManagement.YourConfessionsNumber;
        scoreYou = scoreYou + 7;
      }

      Debug.Log("Score: " + scoreYou + "(You) vs. " + scorePartner + "(Partner)");
    }

}
