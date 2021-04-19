using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemPrincipalController : MonoBehaviour
{
    private float speed = 20.0f;
    public JogoController jogoController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Space key was pressed.");
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("OnCollisionEnter" + collision.collider.tag);
        if(collision.collider.tag == "Bomba" || collision.collider.tag == "Cenario") {
            jogoController.onPersonagemMorreu();
        }

    }
}
