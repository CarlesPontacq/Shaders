using UnityEngine;

public class ColorTintModifier : MonoBehaviour
{
    public Color color;
    public string variableInShaderName;

    void Update()
    {
        //GetComponent<MeshRenderer>().material.SetColor(variableInShaderName, color);    
       Shader.SetGlobalColor(variableInShaderName, color);    
    }
}
