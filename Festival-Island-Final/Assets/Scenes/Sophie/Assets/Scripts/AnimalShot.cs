using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class AnimalShot : MonoBehaviour
{
    private AudioSource m_audio;
    private ActionBasedController xr;

    private void Start()
    {
        m_audio = GetComponent<AudioSource>();
        xr = (ActionBasedController)GameObject.FindObjectOfType(typeof(ActionBasedController));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("chicken"))
        {
            m_audio.Play();
            xr.SendHapticImpulse(0.8f, 0.3f);
            UpdateScore();
            Destroy(other.gameObject);
        }
    }

    private void UpdateScore()
    {
        GameObject shootingManager = GameObject.Find("ShootingManager");
        ShootingGameManager shootingScoreScript = shootingManager.GetComponent<ShootingGameManager>();
        shootingScoreScript.shootingScore += 10;
        Debug.Log(shootingScoreScript.shootingScore);

        GameObject scoreTextObj = GameObject.Find("ShootingScoreTxt");
        TextMeshPro scoreText = scoreTextObj.GetComponent<TextMeshPro>();
        scoreText.SetText(shootingScoreScript.shootingScore.ToString());
    }
}
