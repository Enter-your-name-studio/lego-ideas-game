using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;
using yaSingleton;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "GameManager", menuName = "Singletons/GameManager")]
public class GameManager : Singleton<GameManager> {
	public InputReader input = new InputReader();
	public Player player;

	protected override void Initialize() {
		base.Initialize();

		input.Init();
	}

	protected override void Deinitialize() {
		input.UnInit();

		base.Deinitialize();
	}
}
