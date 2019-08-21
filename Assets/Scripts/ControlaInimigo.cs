using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour {

    public GameObject jogador;
    public float Velocidade = 5;
    Vector3 direcao;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate(){

        Vector3 direcao = jogador.transform.position - transform.position;

        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position +
            direcao.normalized * Velocidade * Time.deltaTime);
    }
}
