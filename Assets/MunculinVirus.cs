using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehaviour
{
	public GameObject virus;
	public float waktuMinimal, waktuMaksimal;
	public float posisiMinimal, posisiMaksimal; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator MunculVirus()
	{
		Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMinimal, posisiMaksimal), Quaternion.identity);
		yield return new WaitForSeconds(Random.Range(waktuMinimal, waktuMaksimal));
		StartCoroutine(MunculVirus());
	}
}