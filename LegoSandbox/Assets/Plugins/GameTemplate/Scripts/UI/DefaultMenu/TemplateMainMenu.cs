using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateMainMenu : MenuBase {
	[SerializeField] int sceneIdToLoad = 1;
	[SerializeField] int testScene1 = 2;
	[SerializeField] int testScene2 = 3;

	public void Play() {
		SceneLoader.Instance.LoadScene(sceneIdToLoad, true, true);
	}

	public void Load() {
		SceneLoader.Instance.LoadScene(sceneIdToLoad, false, false);
	}

	public void PlayTestScene1() {
		SceneLoader.Instance.LoadScene(testScene1, true, true);
	}

	public void PlayTestScene2() {
		SceneLoader.Instance.LoadScene(testScene2, true, true);
	}
}
