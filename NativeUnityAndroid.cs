using UnityEngine;
using NativeAndroidElements;
using System.Collections;

public class NativeUnityAndroid : MonoBehaviour
{
    public string toast = "We could not find such user in our database";
    
    public string title = "Congratulations!";
    public string message = "You will receive the invitation as soon as it is confirmed";
    public string alertButton = "Exit";

    public void ShowToast()
    {        
        Toast.Show(toast, Toast.LENGTH_LONG);
    }

    public void ShowAlert()
    {
        Alert alertDiaolog = new Alert();
        alertDiaolog.onFail += () => { Toast.Show(message, Toast.LENGTH_LONG); };
        alertDiaolog.onFailLitener(() => { Toast.Show(message, Toast.LENGTH_LONG); });
        alertDiaolog.onSucessLitener(() => { Toast.Show(message, Toast.LENGTH_LONG); });
        alertDiaolog.Show(title, message, alertButton);
        StartCoroutine(ExitGame());
    }

    public void ShowCalendar()
    {
        Calendar cal = new Calendar();
        cal.onSelectListener(() => { Toast.Show(cal.getSelectedDate().ToString(), Toast.LENGTH_LONG); });
        cal.Show();
    }

    public IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(5f);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_ANDROID
        Application.Quit();
        //System.Diagnostics.Process.GetCurrentProcess().Kill();        
#endif
    }
}