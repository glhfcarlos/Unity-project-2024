using System.Collections;
using UnityEngine;
using UnityEngine.UI;


namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;


                [SerializeField]private string input;
                [SerializeField]private Color textColor;
                [SerializeField]private Font textFont;

                [Header("Time parameters")]
                [SerializeField] private float delay; 
                [Header("Sound")]
                [SerializeField] private AudioClip sound;

                [Header("Character Image")]
                [SerializeField] private Sprite characterSprite;
                [SerializeField] private Image imageHolder;

        private void Awake()
        {
            textHolder = GetComponent<Text>();
            

            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, sound));
            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true; 
        }
    }
}

