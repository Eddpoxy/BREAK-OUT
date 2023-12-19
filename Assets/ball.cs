using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float ballspeed;
    Rigidbody rb;
    int liv = 3;
    int score = 0;
    [SerializeField]
    GameObject livtext;

    [SerializeField]
    AudioClip Hit;
    [SerializeField]
    AudioClip Death;
    [SerializeField]
    GameObject platfrom;
    TextMeshProUGUI textcomponent;
    TextMeshProUGUI ScoreTextComponent; 

    [SerializeField]
    GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textcomponent = livtext.GetComponent<TextMeshProUGUI>();
        ScoreTextComponent = scoreText.GetComponent<TextMeshProUGUI>();
        rb.velocity = new Vector3(0, -100, 0);
        liv = 3;
        score = 0;
        textcomponent.text = "Jag vet var du bor"; 
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = ballspeed;
        rb.velocity = rb.velocity.normalized * speed; 
        if (gameObject.transform.position.y <= -25)
        {
            gameObject.transform.position = platfrom.transform.position + new Vector3(0,1,0); 
            liv -= 1;
            textcomponent.text = "Jag är " + liv + " km ifrån dig";

        } 
        if (liv == 0)
        {
            textcomponent.text = "GAMEOVER";
            AudioSource.PlayClipAtPoint(Death, transform.position);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject && collision.gameObject.name.Contains("Cube"))
        {
            Destroy(collision.gameObject);
            Debug.Log("det funkar!!"); 
            ballspeed += 0.25f;
            score += 50;
            ScoreTextComponent.text = "DU HAR "+score+" POÄNG";
            AudioSource.PlayClipAtPoint(Hit, transform.position);
        } 
        Debug.Log("det funkar!!");
    }
}
