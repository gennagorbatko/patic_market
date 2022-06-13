using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    float delta;
    private Vector3 resultVector;
    [SerializeField] GameObject bascetform;
    [SerializeField] GameObject backGraund;
    float heightPanel;
    float heightbackgraund;
    float startPositionY;
    float positionBottomY;
    void Start()
    {
        startPositionY = transform.position.y;
        heightPanel = GetComponent<RectTransform>().rect.height / 2;
        resultVector = Vector3.zero;
        positionBottomY = +backGraund.transform.position.y + ((backGraund.GetComponent<RectTransform>().rect.height) / 2);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (bascetform.transform.localPosition.x == -87.19f)
        {
            if (Input.GetMouseButton(0))
            {
                resultVector.x = transform.position.x;
                resultVector.y = Input.mousePosition.y - delta;
                resultVector.z = transform.position.z;
                transform.position = resultVector;
            }
            else
            {
                delta = Input.mousePosition.y - this.gameObject.transform.position.y;
            }
            if (Input.GetMouseButtonUp(0))
            {
                if (transform.position.y <= startPositionY)
                {
                    // Debug.Log(transform.position.y);
                    iTween.MoveTo(this.gameObject, new Vector3(transform.position.x, 538.6074f, transform.position.y), 0.5f);
                }

                if (transform.position.y - heightPanel >= positionBottomY)
                {
                   float position = transform.position.y - ((transform.position.y - heightPanel) - positionBottomY);
                    iTween.MoveTo(this.gameObject, new Vector3(transform.position.x, position, transform.position.y), 0.5f);
                }
            }
        }
        
    }
}
