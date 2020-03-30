using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class ScaleIn : MonoBehaviour
{

    private RectTransform _transform;
    [SerializeField] private float ScaleTo = 0;
    void Awake()
    {
        _transform = this.gameObject.GetComponent<RectTransform>();
        _transform.localScale = new Vector3(0, 0, 0); 
    }

    private void Start()
    {
        StartCoroutine(scale());
    }


    public IEnumerator scale()
    {
        yield return new WaitForFixedUpdate();

        float x = _transform.localScale.x + 1.2f * Time.deltaTime;
        float y = _transform.localScale.y + 1.2f * Time.deltaTime;
        float z = _transform.localScale.z + 1.2f * Time.deltaTime;

        _transform.localScale = new Vector3(x, y, z);

        if (_transform.localScale.x <= ScaleTo)
        {
            StartCoroutine(scale());
        } else
        {
            _transform.localScale = new Vector3(ScaleTo, ScaleTo, ScaleTo);
        }
    }
}
