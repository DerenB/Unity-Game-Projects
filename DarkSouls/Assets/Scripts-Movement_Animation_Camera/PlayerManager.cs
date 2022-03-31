using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DB
{
    public class PlayerManager : MonoBehaviour
    {
        InputManager inputHandler;
        Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            inputHandler = GetComponent<InputManager>();
            anim = GetComponentInChildren<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            inputHandler.isInteracting = anim.GetBool("isInteracting");
            inputHandler.rollFlag = false;
            inputHandler.sprintFlag = false;
        }
    }
}

