using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class LevelManagement : MonoBehaviour
{
    public static int YourConfessionsNumber;

    public TextMeshProUGUI YourConfessionsOutput;
    public TextMeshProUGUI TextRound;
    public TextMeshProUGUI TextScore;

    //for future reference... the tutorial I used: https://www.youtube.com/watch?v=8ogyT842otg
    public SpriteRenderer sr;

    public GameObject playerSpriteA;
    public GameObject playerSpriteB;
    public SpriteRenderer srYourOutput;
    public List<Sprite> myHieroglpyhs = new List<Sprite>();
    public static int selectedHieroglyph = 0;

    public int YourHieroglyphOutputIndex; 
    

    void Start() {
        YourConfessionsNumber = 0;

        if (TheScenesManager.PlayerA == true) {
            playerSpriteA.GetComponent<SpriteRenderer>().enabled = true;
            playerSpriteB.GetComponent<SpriteRenderer>().enabled = false;
        }
        else {
            playerSpriteA.GetComponent<SpriteRenderer>().enabled = false;
            playerSpriteB.GetComponent<SpriteRenderer>().enabled = true;
        }
        
        TheScenesManager.round++;
        TextRound.text = "Round " + TheScenesManager.round.ToString();
        TextScore.text = WeighingManager.scoreYou.ToString() + " (You) vs. " + WeighingManager.scorePartner.ToString()+ " (Your Partner)";
        Translating();


    }
   
   // the translating (using the round and the player to determine by how much the confession-number should be altered. this alternation is the hieroglyphindex, thus providing the players each round with new hieroglyphs, even if they picked the same number over and over...)
   public void Translating() {
    if (TheScenesManager.PlayerA == true)
      {
         YourHieroglyphOutputIndex = YourConfessionsNumber + TheScenesManager.GameSpecifics[2 * TheScenesManager.round - 2];
         if (YourHieroglyphOutputIndex > 7) {YourHieroglyphOutputIndex = YourHieroglyphOutputIndex - 8;}

      }
    else {
        YourHieroglyphOutputIndex = YourConfessionsNumber + TheScenesManager.GameSpecifics[2 * TheScenesManager.round - 1];
         if (YourHieroglyphOutputIndex > 7) {YourHieroglyphOutputIndex = YourHieroglyphOutputIndex - 8;}
    }

    srYourOutput.sprite = myHieroglpyhs[YourHieroglyphOutputIndex];
   }

   // display the hieroglyph (for your own confession)


    // picking your own confessions
    public void PickConfessionsPlus() {
        if (YourConfessionsNumber < 7) {
            YourConfessionsNumber++;
            YourConfessionsOutput.text = YourConfessionsNumber.ToString();
            Translating();
        }
    }

    public void PickConfessionsMinus() {
        if (YourConfessionsNumber > 0) {
            YourConfessionsNumber = YourConfessionsNumber - 1;
            YourConfessionsOutput.text = YourConfessionsNumber.ToString();
            Translating();
        }
    }

 // picking the partners translation
    public void NextOption() {
        selectedHieroglyph = selectedHieroglyph + 1;
        if (selectedHieroglyph == myHieroglpyhs.Count) {
            selectedHieroglyph = 0;
        }
        sr.sprite = myHieroglpyhs[selectedHieroglyph];
    }
    public void BackOption() {
        selectedHieroglyph = selectedHieroglyph - 1;
        if (selectedHieroglyph < 0) {
            selectedHieroglyph = myHieroglpyhs.Count -1;
        }
        sr.sprite = myHieroglpyhs[selectedHieroglyph];
    }

    




}
