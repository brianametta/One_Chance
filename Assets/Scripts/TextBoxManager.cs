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
        {   //Split lines of text at returns
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {   //End at last line of text if none specified
            endAtLine = textLines.Length - 1;
        }
    }

    void Update()
    {
        theText.text = textLines[currentLine];
        if (Input.GetKeyDown(KeyCode.Return))
        {   //Go to next line when enter is pressed
            currentLine += 1;
        }
        if (currentLine == 13)
        {   //Load next level at the end of the story
            Application.LoadLevel(2);
        }

    }

}
