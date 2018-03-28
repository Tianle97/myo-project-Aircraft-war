using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    private void OnMouseUpAsButton()
    {
        Application.LoadLevel(0);
    }
}
