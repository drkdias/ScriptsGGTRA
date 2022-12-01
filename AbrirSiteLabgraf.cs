using UnityEngine;

public class AbrirSiteLabgraf : MonoBehaviour
{
    public string Url;
    
    public void Open()
    {
        Application.OpenURL(Url);
    }
   
}
