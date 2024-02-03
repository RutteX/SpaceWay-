using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class meteor : MonoBehaviour
{
    public float speed;

    private void Update(){
        speed = UnityEngine.Random.Range(5f, 15f);
        Move();
    }

    private void Move(){
        if (transform.position.y > -7f){
            transform.Translate(new Vector2(0, -1 * speed * Time.deltaTime));
        } else{
            Destroy(gameObject);        
        }
    }   

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Rocket"){
            SceneManager.LoadScene("GameOver");
            TimerScript.countMeteors = TimerScript.countMeteors;

        }
        Destroy(collision.gameObject);
    }
}
