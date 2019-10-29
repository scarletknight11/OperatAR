//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Windows.Speech;

//public class SpeechRecognizer : MonoBehaviour {


//    KeywordRecognizer keywordRecognizerObj;
//    public string[] Keywords_array;
//    public float jumpSpeed = 3.0f;

//    private Vector3 moveDirection = Vector3.zero;


//    private Animator anim;
//	// Use this for initialization
//	void Start () {

//        keywordRecognizerObj = new KeywordRecognizer(Keywords_array);
//        keywordRecognizerObj.OnPhraseRecognized += OnKeywordsRecognized;
//        keywordRecognizerObj.Start();

//        anim = GetComponent<Animator>();
//	}

//    void OnKeywordsRecognized(PhraseRecognizedEventArgs args) {
//        Debug.Log("keyword" + args.text + "; confidence " + args.confidence);

//        ActionPerformer(args.text);
//    } 

//    void ActionPerformer(string command) {
//        if(command.Contains("jump")) {
//            moveDirection.y = jumpSpeed;
//        }
//        if (command.Contains("rage"))
//        {

//        }
//    }

//    // Update is called once per frame
//    void Update () {
		
//	}
//}
