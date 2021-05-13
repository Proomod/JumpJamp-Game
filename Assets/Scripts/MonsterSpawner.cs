using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] spawns;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(monsterSpawner());

    }

    // Update is called once per frame

    IEnumerator monsterSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));

            GameObject spawn = spawns[Random.Range(0, spawns.Length)];
            //left side
            Transform left = gameObject.transform.Find("Left").gameObject.transform;

            //right side
            Transform right = gameObject.transform.Find("Right").gameObject.transform;

            // Instantiate(spawn,);
            Transform[] randomPosition = { left, right };
            int randInt = Random.Range(0, randomPosition.Length);


            GameObject spawned = Instantiate(spawn);
            if (randInt == 0)
            {
                spawned.transform.position = left.position;
                spawned.GetComponent<Monster>().enemySpeed = Random.Range(4, 10);

            }
            else
            {
                spawned.transform.position = right.position;
                spawned.GetComponent<Monster>().enemySpeed = -Random.Range(4, 10);
                spawned.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }

        }
    }


}
