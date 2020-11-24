using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;//pede para o programador o tempo
    public Text countdownDislpay;//pede o formato do texto

    private void Start()
    {//Quando o jogo começar, o contador tambem começa.
        StartCoroutine(CountdownToStart);
    }

    IEnumerator CountdownToStart()
    {
        while(countdownTime>0)
        {
            countdownDislpay.txt=countdownTime.ToString();
            yield return new WaitForSeconds(1f);//faz esperar 1 segundo para diminuir o tempo
            countdownTime--;
        }
        countdownDislpay.text = "TEMPO ENCERRADO!"
        //----------------------------------------
        //GameController.instance.StopGame();//verificar como imergir esse contado com o programa
        //-----------------------------------------
        //yield return new  waitForSeconds(1f);//caso queira que diga tempo encerrado, e tenha mais um segundo para encerrar
        countdownDisplay.ganeObject.SetActive(false)//tirar o contador da tela
    }
}