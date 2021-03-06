using UnityEngine;
using System.Collections;

public class SnakePit : MonoBehaviour {
		
	public GameObject snakePrefab;
	public Vector2 spawnOffset = new Vector2(0.0f, -1.0f);
	
	private static int snakesBeingRespawned = 0;
	private float nextSpawn = 0.0f;
	private float spawnTimer = 0.0f;

	private int minimumSnakes;

	void Awake() {

		// Difficulty settings

		// Default
		minimumSnakes = 1;

		GameObject optionsGameObj = GameObject.Find("GameOptions");

		if (optionsGameObj != null) {

			GameOptions options = optionsGameObj.GetComponent<GameOptions>();

			if (options.difficulty == 0) {
				minimumSnakes = 0;
			} else if (options.difficulty == 3) {
				minimumSnakes = 4;
			}

		} else {
			// Defaults if options can't be found (probably because we're debugging a scene without going via the menu)
		}
	}

	// Update is called once per frame
	void Update () {

		GameObject[] snakes = GameObject.FindGameObjectsWithTag("Predator");
		GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");

		// Don't just instantly respawn or it'll look weird...
		if (((snakes.Length + eggs.Length + snakesBeingRespawned) < minimumSnakes) && (Random.Range(0, 10) == 0)) { // Use a bit of randomness so that the respawn pit is random
			nextSpawn = 5.0f + Random.Range(0, 10);
			spawnTimer = 0.0f;
			snakesBeingRespawned++;
		}

		if (nextSpawn > 0.0f) {

			spawnTimer += Time.deltaTime;

			if (spawnTimer > nextSpawn) {
				Instantiate(snakePrefab, new Vector3(transform.position.x + spawnOffset.x, transform.position.y + spawnOffset.y, snakePrefab.transform.position.z), Quaternion.identity);
				nextSpawn = 0.0f;
				snakesBeingRespawned--;
			}
		}
	}
}
