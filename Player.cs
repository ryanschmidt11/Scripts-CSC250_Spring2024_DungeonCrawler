using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject Exit1;
    private float speed = 0.1f;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider Exit1)
    {
        //print("Secret Number = " + MySingleton.secretNumber);
        //MySingleton.secretNumber = 5;
        EditorSceneManager.LoadScene("Room1");
        EditorSceneManager.MoveGameObjectsToScene(Player, Room1);
    }

    
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.Exit1.transform.position, this.speed);
    }
}
