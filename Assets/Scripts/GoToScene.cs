using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToScene : MonoBehaviour
{

    public SceneUtils.SceneId nextScene = SceneUtils.SceneId.Lobby;

    // Start is called before the first frame update
    public void Go()
    {
        SceneLoader.Instance.LoadScene(SceneUtils.scenes[(int)nextScene]);  
    }

}
