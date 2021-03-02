
using UnityEngine;
using UnityEngine.UI;
public class UI_FimDeJogo : MonoBehaviour
{
   public Text message;
   public Text highScoreText;
   private int highScore = 0;

    GameManager gm;
   private void OnEnable()
   {
       gm = GameManager.GetInstance();

       if(gm.vidas > 0)
       {
           message.text = "Você Ganhou!!!";
       }
       else
       {
           message.text = "Você Perdeu!!";
       }

        highScore = gm.pontos > highScore ? gm.pontos : highScore;

        highScoreText.text = "Melhor Pontuação: " + highScore.ToString();

   }
    public void Voltar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }
}