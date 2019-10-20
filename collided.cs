using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collided : MonoBehaviour {

	public GameObject explosion;
    public int scoreValue;
    private GameController gameController;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Bullet") {
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.AddScore(scoreValue);
        }
        
    }
}
