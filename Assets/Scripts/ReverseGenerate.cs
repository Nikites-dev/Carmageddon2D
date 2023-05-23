using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGenerate : MonoBehaviour
{
    [SerializeField] private GameObject _bonusPrefab;
    private int time = 30;
    GameObject bonus;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn(30));
    }

    void Update()
    {
        if (bonus != null)
        {
            bonus.GetComponent<Rigidbody2D>().velocity = -bonus.transform.right * 6;
        }
    }

    // Update is called once per frame
    private IEnumerator Spawn(int startTime)
    {
        yield return new WaitForSeconds(startTime);

        while (true)
        {
            var randY = Random.Range(0.75f, -3.8f);
            bonus = Instantiate(_bonusPrefab, new Vector3(11, randY, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
