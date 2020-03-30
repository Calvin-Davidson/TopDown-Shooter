using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ButtonClicks : MonoBehaviour
{

    private TextMeshProUGUI txt;
    private void Awake()
    {
        txt = GameObject.Find("MainScreenText").GetComponent<TextMeshProUGUI>();
    }
    public void StartGame()
    {
        Debug.Log("The Gaming is starting");
        SceneManager.LoadScene("Map");
    }

    public void Credits()
    {
        txt.text = "Gemaakt door\nCalvin Davidson\nklas: GD1B\nSchool: Media amsterdam";
    }

    public void Shop()
    {
        txt.text = "Comming Soon";
    }

    public void Controlls()
    {
        txt.text = "NONE";
    }
}
