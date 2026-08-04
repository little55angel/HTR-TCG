using UnityEngine;
using UnityEngine.UI;

public class Scrollingbg : MonoBehaviour
{
    //nathans very special scrolling backgound thingy is cool and i am coading so everything will break
    private RawImage teximage;
    private Material texMat;
    public float scrollingSpeed;

    void Start()
    {
     teximage = GetComponent<RawImage>();
     texMat = teximage.material;
    }

    
    void Update()
    {
        texMat.mainTextureOffset = new Vector2(texMat.mainTextureOffset.x - (Time.deltaTime * scrollingSpeed),
            texMat.mainTextureOffset.y + (Time.deltaTime * scrollingSpeed));
        if (texMat.mainTextureOffset.x <= -2)
        {
            texMat.mainTextureOffset = new Vector2(1, 1);
        }
    }
}
