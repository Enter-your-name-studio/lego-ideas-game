using UnityEngine;

public class PlayerBuildController : MonoBehaviour {
	[Header("Refs")]
	[SerializeField] GameObject[] buildPrefabs;
	[SerializeField] int currPrefab = 0;

	bool isHit;
	Ray ray;
	RaycastHit hit;
	int layer;

	private void Awake() {
		layer = LayerMask.GetMask("Brick");

		GameManager.Instance.input.onBuild += Build;
		GameManager.Instance.input.onBroke += Broke;
	}

	private void OnDestroy() {
		GameManager.Instance.input.onBuild -= Build;
		GameManager.Instance.input.onBroke -= Broke;
	}

	void Build() {
		DoRay();
		if (!isHit)
			return;

		GameObject prefab = buildPrefabs[currPrefab];
		currPrefab = (int)Mathf.Repeat(currPrefab + 1, buildPrefabs.Length);

		GameObject spawned = Instantiate(prefab, hit.point, Quaternion.identity, null);
		spawned.transform.position = hit.point;
	}

	void Broke() {
		DoRay();
		if (!isHit)
			return;

	}

	void DoRay() {
		ray = TemplateGameManager.Instance.Camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
		isHit = Physics.Raycast(ray, out hit, 100, layer, QueryTriggerInteraction.Ignore);

		Debug.Log($"Ray - {isHit} {hit.point}");
	}
}
