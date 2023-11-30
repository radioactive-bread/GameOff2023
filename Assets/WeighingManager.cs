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
      // check who's playing and
     
      PartnersRealNumber = LevelManagement.selectedHieroglyph; 
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
