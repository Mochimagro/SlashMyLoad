using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerManager : MonoBehaviour {

    [SerializeField] private GameObject playerObject;

    void Start () {

    }

    public void PlayerMoveX (int value) {
        var position = playerObject.transform.position;
        position.x += value;

        playerObject.transform.position = position;
    }

}