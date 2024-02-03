using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clicker : MonoBehaviour
{

private int num; //инфа о кол-ве кликов
public Text textNum; // ссылка на текст элемент

public void AddNum()
{
    num++;
    textNum.text = "Score: " + num.ToString();
}

 public void Perebros()
 {
    SceneManager.LoadScene("Menu1");
 }

}
