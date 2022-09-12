using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static float planetHealth, currentScore;
    public Image healthImg;
    public TMP_Text scoreText, highScoreText;
    public GameObject gameON, gameOFF, planetPrefab, planetSpawner, meteorSpawner, missionFail;

    public static bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlanetController.isDestroyed == true)
        {
            GameOver();
            missionFail.SetActive(true);
        }
        PlanetController.isDestroyed = false;
        

        healthImg.fillAmount = planetHealth;
        scoreText.text = currentScore.ToString();
    }

    public void GameStart()
    {
        gameON.SetActive(true);
        gameOFF.SetActive(false);
        missionFail.SetActive(false);

        planetHealth = 1;
        currentScore = 0;
        scoreText.text = "0";
        
        SpawnPlanetEarth();

        
    }

    public void GameOver()
    {
        if(currentScore > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", currentScore);
            highScoreText.text = PlayerPrefs.GetFloat("HighScore").ToString();
        }

        foreach(Transform child in meteorSpawner.transform)
            child.GetComponent<MeteorController>().Burst();

        gameON.SetActive(false);
        gameOFF.SetActive(true);
            
    }
    
    void SpawnPlanetEarth()
    {
        if(planetSpawner.transform.childCount == 0)
        { 
            var planetInstance = Instantiate(planetPrefab);

            planetInstance.transform.SetParent(planetSpawner.transform);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
