using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour {
      void OnMouseUpAsButton() {

        this.GetComponent<AudioSource>().Play();

        GameManager._instance.transfromGameState();
	}
}
