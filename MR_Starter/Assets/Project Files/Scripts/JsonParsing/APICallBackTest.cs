using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APICallBackTest : MonoBehaviour
{


    public Post[] postList;

    int index = 0;

    // Use this for initialization
    void Start()
    {
        postList = new Post[100];
        StartCoroutine(GetPosts());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator GetPosts()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        var request = new WWW(url);
        yield return request;

        var posts = new JSONObject(request.text);
        foreach (var post in posts.list)
        {
            Debug.Log(" " + post.ToString());
            var postObj = JsonUtility.FromJson<Post>(post.ToString());
            postList[index++] = postObj;

        }

    }
}


//   "userId": 1,
//   "id": 1,
//   "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
//   "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"

[System.Serializable]
public class Post
{
    [SerializeField]
    int userId;

    [SerializeField]
    string id;

    [SerializeField]
    string title;

    [SerializeField]
    string body;
}
