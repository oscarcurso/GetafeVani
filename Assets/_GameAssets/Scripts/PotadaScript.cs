﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotadaScript : MonoBehaviour {

    [SerializeField] RectTransform[] rt;

    [SerializeField] float speed = 1f;

    public void StartGame() {

        SceneManager.LoadScene(1);

    }
    private void Update() {
       
        for (int i = 0; i < rt.Length; i++) {
            float xPos = -1 * Time.deltaTime * speed;

            if ((rt[i].position.x + rt[i].rect.width) < 0) {

                xPos = 1000;
            }


            rt[i].Translate(xPos, 0, 0);

        }

    }
}