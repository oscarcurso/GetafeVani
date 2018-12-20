using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointscript : MonoBehaviour {

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.name == "Player") {

            GameController.StorePosition(collision.gameObject.transform.position);


            Destroy(this.gameObject);
        }
    }
}
