using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Vector2 levelSize = new Vector2(20f, 15f);
    public Sprite[] wallTiles;
    public Transform tileBase;
    public GameObject environment;
    //public ExitLadder ladder;

    public int levelLoaded = 0;

    void Start() {
        for(int i = 0; i < levelSize.x; i++) {
            for(int j = 0; j < levelSize.y; j++) {
                Transform tile = Instantiate(tileBase, new Vector3(i - levelSize.x/2, j - levelSize.y/2, 7f), Quaternion.identity);
                tile.GetComponent<SpriteRenderer>().sprite = wallTiles[(int)Mathf.Floor(Random.Range(0f, wallTiles.Length-float.Epsilon))];
                tile.transform.SetParent(environment.transform);
            }
        }
    }

    void Update() {
        /*if(ladder.inContactWithPlayer) {
            levelLoaded++;

            string sceneName = "Level" + levelLoaded;

            SceneManager.LoadScene(sceneName);
        }*/
    }
}