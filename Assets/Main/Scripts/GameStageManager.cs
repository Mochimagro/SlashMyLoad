using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStageManager : MonoBehaviour {

    [SerializeField] private GameObject PrefubStageLine;
    [SerializeField] private List<StageLine> stageLineList = new List<StageLine> ();
    void Start () {
        for (int i = 0; i < 10; i++) {
            var line = Instantiate (PrefubStageLine);
            stageLineList.Add (line.GetComponent<StageLine> ());
            stageLineList[i].transform.position = new Vector3 (0, 0, i);
            stageLineList[i].transform.SetParent (transform);
        }
    }
}