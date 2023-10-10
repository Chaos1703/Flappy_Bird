using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Score : MonoBehaviour
{
    public int score = 0;
    public Text score_text;
    public void AddScore(int add){
        score = score + add;
        score_text.text = score.ToString();
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
