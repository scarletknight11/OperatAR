//ausing System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;
//using UnityEngine.Windows.Speech;

//using UnityEngine.SceneManagement;


//public class MoveOnVoiceCommand : MonoBehaviour
//{

//    [SerializeField]
//    private Rigidbody cannonballPrefab;
//    [SerializeField]
//    private Transform firePoint;

//    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
//    private KeywordRecognizer keywordRecognizer;

//    // Use this for initialization
//    void Start()
//    {

//		SceneManager.LoadScene ("testscene");
//		Debug.Log ("shut up");
//		SceneManager.LoadScene ("threedee");
//		Debug.Log ("i changed scenes");

//        keywordActions.Add("turn right", TurnRight);
//        keywordActions.Add("turn left", TurnLeft);
//        keywordActions.Add("move up", MoveUp);
//        //keywordActions.Add("move down", MoveDown);
//        //keywordActions.Add("move left", MoveLeft);
//        //keywordActions.Add("move right", MoveRight);

//        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
//        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
//        keywordRecognizer.Start();
//    }

//    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
//    {
//        Debug.Log("Keyword: " + args.text);
//        keywordActions[args.text].Invoke();
//    }

//    private void TurnLeft()
//    {
//        transform.Rotate(0f, -30f, 0f);
//    }

//    private void TurnRight()
//    {
//        transform.Rotate(0f, 30f, 0f);
//    }

//    private void MoveUp()
//    {
		
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
