using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGranate : MonoBehaviour
{
    PlayerManager playermanager;
    public GameObject granate;
    Transform shootPoint;
    GrandeThrowRenderer _ThrowRenderer;
    // Start is called before the first frame update
    void Start()
    {
        this.playermanager = GameObject.Find("Player").GetComponent<PlayerManager>();
        shootPoint = GameObject.Find("shootPoint").GetComponent<Transform>();
        _ThrowRenderer = GameObject.Find("Canvas").GetComponent<GrandeThrowRenderer>();

    }

    float power;
    bool goUp = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (playermanager.playerData.Granates > 0)
            {
                _ThrowRenderer.Show();
                if (goUp)
                {
                    power += 1000 * Time.deltaTime;
                    if (power >= 1000)
                    {
                        goUp = false;
                    }
                } else
                {
                    power -= 1000 * Time.deltaTime;
                    if (power <= 0)
                    {
                        goUp = true;
                    }
                }
                _ThrowRenderer.setPower(power / 1000);
                
            } else
            {
                Debug.Log("geen granaten meer.");
            }
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (playermanager.playerData.Granates <= 0)
            {
                return;
            }
            _ThrowRenderer.Hide();

            playermanager.playerData.Granates -= 1;

            GameObject granateObject = Instantiate(granate, shootPoint.position, transform.rotation);
            granateObject.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(new Vector3(0, 0, power)));

            Destroy(granateObject, 5f);

            power = 0;
        }
    }
}
