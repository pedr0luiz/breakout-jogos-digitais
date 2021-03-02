using UnityEngine;
using UnityEngine.UI;

public class UI_PowerUp : MonoBehaviour
{   public Text textPU;
   GameManager gm;
   void Start()
   {
       textPU = GetComponent<Text>();
       gm = GameManager.GetInstance();
   }
   
   void Update()
   {
       textPU.text = $"Power Ups: {gm.powerUps}";
   }
}
