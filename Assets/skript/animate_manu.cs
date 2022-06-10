using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate_manu : MonoBehaviour
{
    [SerializeField] GameObject Manu_form;
    [SerializeField] float speed_move;
    bool flag = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            Manu_form.transform.Translate(Vector3.right);
        }
    }
}
