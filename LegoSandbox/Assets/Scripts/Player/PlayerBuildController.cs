using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuildController : MonoBehaviour {


	private void Awake() {
		GameManager.Instance.input.onBuild += Build;
		GameManager.Instance.input.onBroke += Broke;
	}

	private void OnDestroy() {
		GameManager.Instance.input.onBuild -= Build;
		GameManager.Instance.input.onBroke -= Broke;
	}

	void Build() {
		Debug.Log("Build");
	}

	void Broke() {
		Debug.Log("Broke");
	}
}
