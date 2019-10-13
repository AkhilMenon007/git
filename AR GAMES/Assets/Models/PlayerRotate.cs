using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public Transform player;
    public Transform self;
    // Start is called before the first frame update
    void Update()
    {
        self.rotation = Quaternion.LookRotation(Vector3.ProjectOnPlane(self.position - player.position, Vector3.up), Vector3.up);
    }

    // Update is called once per frame

}
