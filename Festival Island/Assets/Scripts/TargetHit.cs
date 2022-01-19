using TMPro;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        GameObject _scoreObj = GameObject.Find("Throwing Game");
        ThrowingGameData _scoreData = _scoreObj.GetComponent<ThrowingGameData>();
        _scoreData.throwingScore += 10;
        //Debug.Log(_scoreData.throwingScore);

        GameObject scoreObj = GameObject.Find("ScoreValue");
        TextMeshPro _scoreText = scoreObj.GetComponent<TextMeshPro>();
        _scoreText.SetText(_scoreData.throwingScore.ToString());
    }
}
