using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Os : MonoBehaviour
{
    public SnapshotCamera snapCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            snapCam.CallTakeSnapshot();
        }
    }
}
