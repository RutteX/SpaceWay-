using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 15;
    public int counter = 0;

    private void Update()
    {
        BANG();
    }

    private void BANG(){
        if (transform.position.y < 7f){
            transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
        } else{
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        TimerScript.countMeteors++;
        Destroy(collision.gameObject);

    }
}
