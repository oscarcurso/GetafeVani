using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    [SerializeField] Player player;
    [SerializeField] GameObject panelVidas;
    public Image prefabImagenVida;
    Image nuevaImage;
    // Image[] imagenesVida= new Image[5];
    public Image[] imagenesVida;
    private int numeroVidas;
    



    void Start () {
        numeroVidas = player.GetVidas();
        imagenesVida = new Image[numeroVidas];


        for(int i=0; i< imagenesVida.Length; i++) {
            imagenesVida[i] = Instantiate(prefabImagenVida, panelVidas.transform);
            
        }
		
	}

    public void RestarVida() {
        numeroVidas = player.GetVidas();
        for (int i = numeroVidas; i > imagenesVida.Length; i++) {
            imagenesVida[i].color = new Color32(160, 160, 160, 128);
        }

    }

}
