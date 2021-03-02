using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject Bloco;
    GameManager gm;
    private Color[] colors = new Color[] { new Color(1, 0, 0, 1), new Color(0, 1, 0, 1), new Color(0, 0, 1, 1), new Color(1, 1, 0, 1) };

  void Start()
  {
      gm = GameManager.GetInstance();
      GameManager.changeStateDelegate += Construir;
      Construir();
  }

  void Construir()
  {
      if (gm.gameState == GameManager.GameState.GAME)
      {
          for(int i = 0; i < 10; i++)
          {
              for(int j = 0; j < 4; j++){
                  Vector3 posicao = new Vector3(-7 + 1.55f * i, 4 - 0.55f * j);

                  GameObject bloco =  Instantiate(Bloco, posicao, Quaternion.identity, transform);
                  bloco.GetComponent<Bloco>().setLifes(4 - j);
                  bloco.GetComponent<Bloco>().setColor(colors[3 - j]);
              }
          }
      }
  }

  void Update()
  {
      if (transform.childCount <= 0 && gm.gameState == GameManager.GameState.GAME)
      {
          gm.ChangeState(GameManager.GameState.ENDGAME);
      }
  }

}

