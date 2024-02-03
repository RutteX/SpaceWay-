using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainSceneScript : MonoBehaviour
{
    public GameObject meteors;
    public float secondSpawnMeteors;

    private void Start(){
        Invoke("SpawnMeteors", 2f);

    }

    private void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
        if(Input.GetKey(KeyCode.P)){
            SceneManager.LoadScene("victory");
        }
    }

    private void SpawnMeteors(){
        Instantiate(meteors, new Vector2(RandCoordsX(), 7f), Quaternion.identity);
        Invoke("SpawnMeteors", secondSpawnMeteors);
    }

    private float RandCoordsX(){
        return Random.Range(-11f, 11f);
    }

    public void NewGame(){
            TimerScript.countMeteors = 0;
            SceneManager.LoadScene("Game");
    }
    public void QuitGame(){
            Application.Quit();
    }
}
