using UnityEngine;
using System.Collections;

//Code from Youtube.com/gamesplusjames/Unity Basics - How to Create a Dialogue Box & Import Text

public class TextImporter : MonoBehaviour {

    public TextAsset textFile;
    public string[] textLines;

    void Start () {
        if (textFile != null)
        {   //Split lines at returns
            textLines = (textFile.text.Split('\n'));
        }        
	}
	
}
