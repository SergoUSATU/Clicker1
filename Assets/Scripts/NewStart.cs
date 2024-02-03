using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewStart : MonoBehaviour
{
 public void Starting()
 {
    SceneManager.LoadScene("Game");
 }

 public void Improvement()
 {
    SceneManager.LoadScene("Menu2");
 }

 public void Exit()
 {
    Application.Quit();
 }
}
