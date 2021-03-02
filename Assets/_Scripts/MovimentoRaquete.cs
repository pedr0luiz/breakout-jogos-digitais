using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRaquete : MonoBehaviour
{
    GameManager gm;
        //[Range(1, 10)] 
        float velocidade = 5.5f;
    // Start is called before the first frame update
    void Start(){
        gm = GameManager.GetInstance();
    }

    void Update()
    {
    if (gm.gameState != GameManager.GameState.GAME) return;

    float inputX = Input.GetAxis("Horizontal");
    transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;  

    if(Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME) {
        gm.ChangeState(GameManager.GameState.PAUSE);
    }
    }
}
