using UnityEngine;
using System.IO;

public class ScreenshotTaker : MonoBehaviour
{
    public string filename = "screenshot.png";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            string path = Path.Combine(Application.dataPath, filename);
            ScreenCapture.CaptureScreenshot(path);
            Debug.Log("Screenshot gespeichert unter: " + path);
        }
    }
}
