using UnityEngine;
using System;
public class Rocket : MonoBehaviour
{
    public float speed = 15f;
    public GameObject leftArrow;
    public GameObject rightArrow;

    private void Update(){
        Move();
        if (Input.GetKeyDown(KeyCode.Space)){
             Attack();
        }
    }

    private void Move(){
        if(Input.GetKey(KeyCode.A) && transform.position.x > -8f){
            transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x < 8f){
            transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime);
        }
    }

    private void Attack(){
        Instantiate(leftArrow, new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f), Quaternion.identity);
        Instantiate(rightArrow, new Vector2(transform.position.x - 0.5f, transform.position.y + 0.5f), Quaternion.identity);
    }
}