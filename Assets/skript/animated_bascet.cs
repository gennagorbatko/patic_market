using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animated_bascet : MonoBehaviour
{
    //[SerializeField] GameObject gameObject;
    public void bascetclick()
    {
        iTween.MoveTo(this.gameObject, new Vector3(272.81f, 1488.42f, -42.68f), 5f);
    }
    public void backClick()
    {
        iTween.MoveTo(this.gameObject, new Vector3(992.81f, 1488.42f, -42.68f), 5f);
    }
}

