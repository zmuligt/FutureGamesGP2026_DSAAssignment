/*
using Environment;
using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    
    public class BSTNode
    {
        private int data;
        public BSTNode? leftChild = null;
        public BSTNode? rightChild = null;


        public int GetData()
        {
            return data;
        }

        public BSTNode(int inData)
        {
            this.data = inData;
        }
    }
    public class BinarySearchTree
    {
        private BSTNode root;

        public BinarySearchTree(int rootData)
        {
            root = new BSTNode(rootData);
        }
        public void Insert(int inData)
        {
            BSTNode newNode = new BSTNode(inData);
            BSTNode? currentNode = root;
            BSTNode? lastParent = null;

            while (currentNode != null)
            {
                if (inData < currentNode.GetData())
                {
                    lastParent = currentNode;
                    currentNode = currentNode.leftChild;

                }
                else
                {
                    lastParent = currentNode;
                    currentNode = currentNode.rightChild;
                }
            }
            if (inData < lastParent.GetData())
            {
                lastParent.leftChild = newNode;
            }
            else
            {
                lastParent.rightChild = newNode;
            }
        }
    }
}
*/