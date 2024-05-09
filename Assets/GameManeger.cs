using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject playerPrefab;

    int[,] map;

    //bool MoveNumber(int number,int moveFrom,int moveTo)
    //{
    //    //移動先が範囲外なら移動不可
    //    if(moveTo<0||moveTo>=map.Length)
    //    {
    //        return false;
    //    }
    //    //移動先に2(箱)がいたら
    //    if (map[moveTo] == 2)
    //    {
    //        //どの方向へ移動するかを算出
    //        int offset= moveTo - moveFrom;
    //        //プレイヤーの移動先から、さらにさきへ2（箱）を移動させる
    //        //箱の移動処理。MoveNumberメソッド内でMoveNumberメソッドを
    //        //呼び、処理が再帰している。移動可不可をboolで記録
    //        bool success = MoveNumber(2, moveTo, moveTo + offset);
    //        //もし箱が移動失敗したら、プレイやーの移動も失敗
    //        if (!success) 
    //        { 
    //            return false;
    //        }
    //    }
    //    //プレイヤー・箱関わらずの移動処理
    //    map[moveTo] = number;
    //    map[moveFrom] = 0;
    //    return true;
    //}

    //int GetPlayerIndex()
    //{
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;

    //}

    //void PrintArray()
    //{
    //    string debugText = "";

    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        debugText += map[i].ToString() + ",";
    //    }

    //    Debug.Log(debugText);
    //}

    // Start is called before the first frame update
    void Start()
    {

        map = new int[,]
        {
            { 0, 1, 0, 2, 0, 2, 0, 0, 0 },
            { 0, 1, 0, 2, 0, 2, 0, 0, 0 },
            { 0, 1, 0, 2, 0, 2, 0, 0, 0 },
        };

        for(int y=0; y < map.GetLength(0); y++)
        {
            for(int x = 0; x < map.GetLength(1); x++)
            {
                if (map[y, x] == 1)
                {
                    GameObject instance = Instantiate(
                        playerPrefab,
                        new Vector3(x, map.GetLength(0) - y, 0),
                        Quaternion.identity
                    );
                }
            }
        }

        string debugText = "";
        //変更。二重for文で二次元配列の情報を出力
        for(int y = 0; y < map.GetLength(0); y++)
        {
            for(int x = 0; x < map.GetLength(1); x++)
            {
                debugText += map[y,x].ToString() + ",";
            }
            debugText += "\n";//改行
        }
        Debug.Log(debugText);
    }

    // Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();
    //        MoveNumber(1, playerIndex, playerIndex + 1);
    //        PrintArray();
    //    }

    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();
    //        MoveNumber(1, playerIndex, playerIndex - 1);
    //        PrintArray();
            
    //    }

    //}
}
