using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    private PlayerControls input;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        input = InputMaster.instance.input;
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Slash");

        if (input.PlayerAttack.BasicAttack.IsPressed())
        {
            anim.Play("Slash");
        }
    }
}
