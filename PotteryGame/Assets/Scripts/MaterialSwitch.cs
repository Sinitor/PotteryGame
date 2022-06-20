using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitch : MonoBehaviour
{
    [SerializeField] private Renderer playerMaterial;
    [SerializeField] private ParticleSystem woodFX;
    public List<Material> rendererList; 
    private void Start()
    {
        rendererList = new List<Material>(Resources.LoadAll<Material>("Material"));
    } 
     
    public void Switch()
    {
        for (int i = 0; i < rendererList.Count; i++)
        {
            if (gameObject.name == rendererList[i].name)
            {
                playerMaterial.material = rendererList[i];
                woodFX.GetComponent<Renderer>().material = rendererList[i];
            }
        }
    }

}
