using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    private void OnGUI()
    {
        int buttonW = 100;
        int buttonH = 50;

        float ScreenW = Screen.width / 2;
        float ScreenH = Screen.height / 2;
        float ScreenB = buttonW / 2;

        if (GUI.Button(new Rect(ScreenW - ScreenB, ScreenH, buttonW, buttonH), "Play"))
        {
            SceneManager.LoadScene("Stage01");
        }
        if (GUI.Button(new Rect(ScreenW - ScreenB, ScreenH + 60, buttonW, buttonH), "End"))
        {
            Application.Quit();
        }
    }
}
