using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;

    State stateRef;

    [SerializeField] State startingState;
    // Start is called before the first frame update
    void Start()
    {
        stateRef = startingState;
        textComponent.text = stateRef.GetStateStoryText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    void ManageStates()
    {
        //Creamos un array de estados, donde guardamos los estados a los que podemos ir desde el estado actual en el que estamos
        State[] nextStates = stateRef.GetNextStates();

        //Si pulsamos la tecla X del teclado cambiamos al siguiente estado
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            stateRef = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            stateRef = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Del estado en el que esté pasa al siguiente estado que esté en la posición del array 0
            stateRef = nextStates[2];
        }
        //Accedemos al componente text dentro del textComponent y metemos lo que haya dentro del campo storyText del estado actual
        textComponent.text = stateRef.GetStateStoryText();
    }
}
