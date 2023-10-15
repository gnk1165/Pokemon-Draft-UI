using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokeballManager : MonoBehaviour
{
    public Image image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Reload(string p)
    {
        p = pFormat(p);
        string file = "Images/";
        if (p.Equals(null) || p.Equals("Pokeball"))
        {
            file += "Pokeball.png";
        }
        file += "Pokemon/" + p +".png";
        var tex = Resources.Load<Texture2D>(file);
        var sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        image.sprite = sprite;
    }

    private string pFormat(string p)
    {
        p = p.Replace(' ', '-');
        // ADD REMOVAL OF : . '
        p = p.Replace(':', ' ');
        return p;
    }
}
