using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingEnemyBehaviorOverTime : MonoBehaviour
{
    /*
    #region To New Position Setup
    private static Vector3 GetRandomDir2d()    // i use it only in this script so it's private. but in another project i might put it in a sep script and use it as a library
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;   //left unityEngine in case i'll put it in a lib some day
    }

    private IEnumerator LerpToNewPosition()
    {
        Vector3 newPos = this.transform.position + GetRandomDir2d();
        if (timeElapsed < lerpDuration)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, newPos, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        else
        {
            this.transform.position = newPos;
        }
    }
    #endregion
        */

}

