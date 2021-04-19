using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogoController : MonoBehaviour
{
    public GameObject fimDoJogoWrapper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPersonagemMorreu() {
        Debug.Log("Morreu! Mostrar tela de fim de jogo");
        fimDoJogoWrapper.SetActive(true);
    }


    public void BotaoVoltarAoMenuClicado() {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
