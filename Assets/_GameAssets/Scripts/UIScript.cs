using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    [SerializeField] Player player;
    [SerializeField] GameObject panelVidas;
    public Image prefabImagenVida;
    Image nuevaImage;
    Image[] imagenesVida= new Image[5];
    private int numeroVidas;
    



    void Start () {
        numeroVidas = player.GetVidas();
        for(int i=0; i< imagenesVida.Length; i++) {
            imagenesVida[i] = Instantiate(prefabImagenVida, panelVidas.transform);
            
        }
		
	}
	
}
