using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public PlayerBuildController buildController;
	public PlayerMoving moving;

	private void Awake() {
		GameManager.Instance.player = this;
	}

	private void OnDestroy() {
		if(GameManager.Instance.player == this)
			GameManager.Instance.player = null;
	}
}
