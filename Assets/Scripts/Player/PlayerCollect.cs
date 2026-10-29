using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCollect : MonoBehaviour
{
    [SerializeField] private ScoreDatas _scoreData;
    [SerializeField] private UIController _uiController;
    [SerializeField] private AudioClip StarCollect;
    [SerializeField] private AudioClip BadCollect;
    [SerializeField] private AudioClip SheepCollect;
    private void OnTriggerEnter(Collider other)
    {
        // COLLECTIBLES

        Debug.Log("Touch something");
        if (other.gameObject.GetComponent<YellowStar>())
        {
            _scoreData._score = _scoreData._score + other.gameObject.GetComponent<YellowStar>()._scoreValue;
            AudioManager.instance.PlaySoundFXClip(StarCollect, transform, 0.5f);
            _uiController._updateScoreText(_scoreData._score);
            Debug.Log("Destroy yellow star");
            Destroy(other.gameObject);
        }
        if (other.gameObject.GetComponent<PurpleStar>())
        {
            _scoreData._score = _scoreData._score + other.gameObject.GetComponent<PurpleStar>()._scoreValue;
            AudioManager.instance.PlaySoundFXClip(BadCollect, transform, 0.5f);
            _uiController._updateScoreText(_scoreData._score);
            Debug.Log("Destroy purple star");
            Destroy(other.gameObject);
        }
        if (other.gameObject.GetComponent<Sheep>())
        {
            AudioManager.instance.PlaySoundFXClip(SheepCollect, transform, 0.5f);
            Destroy(other.gameObject);

        }
    

        // LEVEL TRIGGER

        if (other.gameObject.GetComponent<LevelTrigger>())
        {
            Debug.Log("Level trigger collision");
            SceneManager.LoadScene("LVL_1");
            
        }
        if (other.gameObject.GetComponent<Level2Trigger>())
        {
            Debug.Log("Level 2 trigger collision");
            SceneManager.LoadScene("LVL_2");
            
        }
        if (other.gameObject.GetComponent<Level3Trigger>())
        {
            Debug.Log("Level 3 trigger collision");
            SceneManager.LoadScene("LVL_3");
            
        }
        if (other.gameObject.GetComponent<VictoryTrigger>())
        {
            Debug.Log("Victory collision");
            SceneManager.LoadScene("LVL_VICTORY");
            
        }
        if (other.gameObject.GetComponent<MainTrigger>())
        {
            Debug.Log("Main collision");
            SceneManager.LoadScene("LVL_Main");
            
        }




    }

}
