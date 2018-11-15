using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsSpawner : MonoBehaviour {

    public GameObject ingredient1;
    //private IEnumerator spawnIngredient;

    // Use this for initialization
    void Start () {
        StartCoroutine(spawnIngredient());
	}
	
	// Update is called once per frame
	void Update () {
	}

    private IEnumerator spawnIngredient()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Instantiate(ingredient1, this.transform.position, this.transform.rotation);
        }

    }
}
