using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BlockGenerator : MonoBehaviour {

    public GameObject blockBluePrefab;
    public GameObject blockGreenPrefab;
    public GameObject blockYellowPrefab;
    public GameObject blockRedPrefab;

    private GameObject[] blockPrefab;

    public int blockNum = 4;
    private float[,] blockPlace;
    public bool[] blocks;

    void Start()
    {
        blockPrefab = new GameObject[] { blockBluePrefab, blockGreenPrefab, blockYellowPrefab, blockRedPrefab };
        
        if (blockNum == 4) {
            blockPlace = new float[,] { { -1.5f, -1.0f }, { -0.5f, -1.0f }, { 0.5f, -1.0f }, { 1.5f, -1.0f } };
            blocks = new bool[4] { true, true, true, true };
            for (int i = 0; i < blockNum; i++) {
                int rnd = UnityEngine.Random.Range(0, 4);
                var obj = Instantiate(blockPrefab[rnd], new Vector3(blockPlace[i, 0], blockPlace[i, 1], 0.0f), Quaternion.identity);
                obj.name = i.ToString();
            }
        }
    }

    void Update()
    {
        //Debug.Log(blocks[0] + ", " +  blocks[1] + ", " + blocks[2] + ", " + blocks[3]);
        for (int i = 0; i < blockNum; i++) {
            if (blocks[i] == false) {
                int rnd = UnityEngine.Random.Range(0, 4);
                var obj = Instantiate(blockPrefab[rnd], new Vector3(blockPlace[i, 0], blockPlace[i, 1], 0.0f), Quaternion.identity);
                obj.name = i.ToString();
                blocks[i] = true;
            }
        }
        
    }
}
