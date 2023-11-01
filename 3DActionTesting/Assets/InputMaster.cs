using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMaster : MonoBehaviour
{
    public static InputMaster instance;

    public PlayerControls input;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        input = instance.input;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
