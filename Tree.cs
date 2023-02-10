using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xuan{
    public class Tree : MonoBehaviour
    {

        class Btree<T>
        {
            public T data;
            public Btree<T> left;
            public Btree<T> right;

            public Btree(T data)
            {
                this.data = data;
            }
            void printBtreeFirst(Btree<int> btree, int dept, Dictionary<int, int> map)
            {
                if (btree == null)
                {
                    return;
                }
                if (!map.ContainsKey(dept))
                {
                    map.Add(dept, btree.data);
                }
                if (btree.left != null)
                {
                    printBtreeFirst(btree.left, dept + 1, map);
                }
                if (btree.right != null)
                {
                    printBtreeFirst(btree.right, dept + 1, map);
                }
                //返回结果为list
                //for (int i = 0; i < dept; i++)
                // new List<int>().Add(map[i]);
            }
        }
    }
}
