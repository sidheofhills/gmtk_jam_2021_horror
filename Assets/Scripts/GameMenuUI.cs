using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMenuUI : MonoBehaviour
{
    #region Blinking Variables
    [SerializeField] CanvasGroup blinkingText; //welcomeText;
    [SerializeField] float blinkingSpeedFrame;
    private float localBlinkingSpeed;
    private bool toBlink = false;
    #endregion

    #region Pop-Up Variables
    [SerializeField] TMP_Text popUpText; //nameText
    [SerializeField] float popUpScale;
    private Mesh mesh;

    private Vector3[] vertices;


    #endregion
    // СДЕЛАТЬ СКРИММЕР ПОСЛЕ ТОГО, КАК ПЛЭЙЕР НАЖАЛ ПЛЭЙ ИЛИ ЛИВ (2ШТ) И не решена проблема с поп-апом, но она сейчас не самое важное
    private void Update()
    {
        BlinkingSetup();
        VertexWobleSetup();

        popUpText.ForceMeshUpdate();
        /*mesh = popUpText.mesh;
        Vector3[] origVertices = mesh.vertices;
        vertices = mesh.vertices;
        for(int i = 0; i < popUpText.textInfo.characterCount; i++)
        {
            TMP_CharacterInfo textChar = popUpText.textInfo.characterInfo[i];
            int index = textChar.vertexIndex;
            vertices[index] = new Vector3 (Mathf.Lerp(vertices[index].x, vertices[index].x - popUpScale, Time.time), Mathf.Lerp(vertices[index].y, vertices[index].y - popUpScale, Time.time),0) ;
            vertices[index+1] = new Vector3(Mathf.Lerp(vertices[index].x, vertices[index].x - popUpScale, Time.time), Mathf.Lerp(vertices[index].y, vertices[index].y + popUpScale, Time.time), 0);
            vertices[index+2] = new Vector3(Mathf.Lerp(vertices[index].x, vertices[index].x + popUpScale, Time.time), Mathf.Lerp(vertices[index].y, vertices[index].y + popUpScale, Time.time), 0);
            vertices[index+3] = new Vector3(Mathf.Lerp(vertices[index].x, vertices[index].x + popUpScale, Time.time), Mathf.Lerp(vertices[index].y, vertices[index].y - popUpScale, Time.time), 0);
            mesh.vertices = vertices;
            popUpText.canvasRenderer.SetMesh(mesh);
        }*/

    }

    private Vector2 VertexWobble(float time)
    {
        return new Vector2(Mathf.Sin(time * 3.3f), Mathf.Cos(time * 2.8f));
    }

    private void VertexWobleSetup()
    {
        popUpText.ForceMeshUpdate();
        mesh = popUpText.mesh;
        vertices = mesh.vertices;

        for(int i = 0; i < vertices.Length; i++)
        {
            Vector3 offset = VertexWobble(Time.time + i);
            vertices[i] += offset;
        }
        mesh.vertices = vertices;
        popUpText.canvasRenderer.SetMesh(mesh);

    }

    #region Blinking Functions

    private void BlinkingSetup()
    {
        if (Time.frameCount % blinkingSpeedFrame==0)
        {
            if (toBlink)
            {
                float noise = Mathf.PerlinNoise(Time.deltaTime, 0.0f);
                blinkingText.alpha = Mathf.Lerp(0f, 1f, Mathf.InverseLerp(0.472f, 0.482f, noise));
                Debug.Log(noise + " " + blinkingText.alpha);
            }
            else
            {
                blinkingText.alpha = 1;
            }
           
        }

    }
    public void Blinking()   // for welcomeText;
    {
        toBlink = true;
    }

    public void StopBlinking()   // for welcomeText;
    {
        toBlink = false;
    }

    #endregion

    #region Pop-Up Functions

    #endregion
}
