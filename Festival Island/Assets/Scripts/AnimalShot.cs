using UnityEngine;
using TMPro;

public class AnimalShot : MonoBehaviour
{
    private AudioSource m_audio;

    private void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("chicken"))
        {
            m_audio.Play();
            UpdateScore();
            Destroy(gameObject);
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
