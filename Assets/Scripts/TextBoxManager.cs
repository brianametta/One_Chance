using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Code from Youtube.com/gamesplusjames/Unity Basics - How to Create a Dialogue Box & Import Text
public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;

    public Text theText;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;


    void Start()
    {
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }

    void Update()
    {
        theText.text = textLines[currentLine];
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }
    }

}
