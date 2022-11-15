using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LogicaSizeController : MonoBehaviour
{
    public TMP_Dropdown resolucionesDropDown;
    Resolution[] resolutions; 
    void Start()
    {
        RevisarResolution();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RevisarResolution()
    {
        resolutions = Screen.resolutions;
        resolucionesDropDown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucionActual = 0;
        for(int i =0;i<resolutions.Length;i++)
        {
            string opcion = resolutions[i].width+" x " + resolutions[i].height;
            opciones.Add(opcion);

            if(Screen.fullScreen && resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                resolucionActual= i;
            }
        }
        resolucionesDropDown.AddOptions(opciones);
        resolucionesDropDown.value = resolucionActual;
        resolucionesDropDown.RefreshShownValue();
    }
    public void CambiarResolucion(int indiceResolucion)
    {
        Resolution resolucion = resolutions[indiceResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
    }
}
