using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreTest;

    private void Start()
    {
        _updateScoreText(0);
    }

    public void _updateScoreText(int scoreValue)
    {
        _scoreTest.text = scoreValue.ToString();
    }

}