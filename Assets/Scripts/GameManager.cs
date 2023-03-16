using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    
    public int score;
    public static int hiScore = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiScoreText;

    public GameObject[] asteroidFields;
    public GameObject player;
    public Animator fadeScreen;
    public float transitionTime = 2f;

    private void Start()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        hiScoreText.text = "highscore: " + hiScore.ToString();       
    }
    public void StartGame()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));
        
    }
    
    
    public void Retry()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));
    }
    public void Quit()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(0));
    }

    public void AddScore()
    
    {
        score += 1;
        scoreText.text = score.ToString();

        if(score > hiScore)
        {
            hiScore = score;
            hiScoreText.text = "HighScore:" +hiScore.ToString();
            PlayerPrefs.SetInt("HiScore", hiScore);
            PlayerPrefs.Save();
        }
    }

    public void SpawnAsteroidField()
    {
        int rnd = Random.Range(0,4);
        Instantiate(asteroidFields[rnd],new Vector3(player.transform.position.x,player.transform.position.y+30,player.transform.position.z),player.transform.rotation);
    }

    public IEnumerator LoadLevel(int levelToLoad)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelToLoad);
    }



}


