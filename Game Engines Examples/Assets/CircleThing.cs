using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleThing : MonoBehaviour
{
    public int elements = 6;
    public float radius = 5;
    public int rings = 9;
    public GameObject dodec;

    // Start is called before the first frame update
    void Start()
    {
        for(int j = 1; j < (rings+1); j++){
            float theta = Mathf.PI * 2.0f / (float) (elements * j);
            for(int i = 0 ; i < (elements*rings) ; i ++)
            {
                GameObject sp = Instantiate(dodec);
                Vector3 pos = new Vector3(Mathf.Sin(theta * i) * (radius*j), Mathf.Cos(theta * i) * (radius*j), 0);
                sp.transform.position = transform.TransformPoint(pos);
                sp.transform.localScale = new Vector3(4, 4, 4);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
