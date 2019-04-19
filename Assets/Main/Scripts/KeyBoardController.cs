using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyBoardController : MonoBehaviour {

    [SerializeField] private UnityEvent onUp, onDown, onRight, onLeft, onFire, onJump;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.UpArrow)) {
            onUp.Invoke ();
        }

        if (Input.GetKeyDown (KeyCode.DownArrow)) {
            onDown.Invoke ();
        }

        if (Input.GetKeyDown (KeyCode.RightArrow)) {
            onRight.Invoke ();
        }

        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            onLeft.Invoke ();
        }

        if (Input.GetKeyDown (KeyCode.Space)) {
            onFire.Invoke ();
        }
    }
}