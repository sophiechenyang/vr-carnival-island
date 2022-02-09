using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TargetHit : MonoBehaviour
{
    private ActionBasedController xr;

    void Start()
    {
        xr = (ActionBasedController)GameObject.FindObjectOfType(typeof(ActionBasedController));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            xr.SendHapticImpulse(0.8f, 0.3f);
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
