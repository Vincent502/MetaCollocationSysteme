using UnityEngine;

public class TestScript : MonoBehaviour
{
    public TMPro.TextMeshPro m_TextMeshPro;
    public void OnClick()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        var newText = "Nous avons changer le texte";
        m_TextMeshPro.text = newText;
    }
}
