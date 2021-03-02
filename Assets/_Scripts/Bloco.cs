using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour{
    private int lifes;
    GameManager gm;
    private void OnTriggerEnter2D(Collider2D collision){
        AudioSource audioSrc = GetComponent<AudioSource>();
        if(collision.gameObject.CompareTag("Bola")){
            audioSrc.Play();
        }
        lifes--;
        if(lifes <= 0){
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = false;
            Destroy(gameObject, audioSrc.clip.length);
            gm.pontos++;
        }
    }
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    void Update()
    {
        
    }

    public void setLifes(int l){
        lifes = l;
    }

    public void setColor(Color color){
        GetComponent<SpriteRenderer>().color = color;
    }
}
