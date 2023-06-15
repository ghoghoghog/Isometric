using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coin : MonoBehaviour
{
    
  public TextMeshProUGUI score;
  public int Coin=0;

  

  private void Update()
  {
      score.text = "coin : " + Coin.ToString()+" / 100";
      if (Coin>=100)
      {
          SceneManager.LoadScene(sceneName: "clear");
      }
  }

  private void OnTriggerEnter2D(Collider2D collision)
      {
          if (collision.gameObject.CompareTag("coin"))
          {
              Coin += 1;
          }
       
      }
}
