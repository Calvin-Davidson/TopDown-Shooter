using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GrandeThrowRenderer : MonoBehaviour
{

    private Slider _GranadePower;
    private GameObject _SliderObject;
    void Start()
    {
        _GranadePower = GameObject.Find("GranadeThrowPower").GetComponent<Slider>();
        _SliderObject = GameObject.Find("GranadeThrowPower");
        this.Hide();
    }

    public void setPower(float value)
    {
        _GranadePower.value = value;
    }

    public void Hide()
    {
        _SliderObject.SetActive(false);   
    }

    public void Show()
    {
        _SliderObject.SetActive(true);
    }
}
