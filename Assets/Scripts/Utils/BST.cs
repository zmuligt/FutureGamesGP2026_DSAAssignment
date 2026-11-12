using Environment;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utils
{
    
    public class BSTNode
    {
        private Employee data;
        public BSTNode? leftChild = null;
        public BSTNode? rightChild = null;


        public Employee GetData()
        {
            return data;
        }

        public BSTNode(Employee inData)
        {
            this.data = inData;
        }
    }
    public class BinarySearchTree
    {
        private BSTNode root;

        public BinarySearchTree(Employee rootData)
        {
            root = new BSTNode(rootData);
        }
        public void Insert(Employee inData)
        {
            BSTNode newNode = new BSTNode(inData);

            if (root == null)
            {
                root = newNode;
                return;
            }

            BSTNode? currentNode = root;
            BSTNode? lastParent = null;

            DateTime newtEntranceTime = DateTime.Parse(inData.lastEntranceInEngineRoom);

            while (currentNode != null)
            {
                lastParent = currentNode;
                DateTime currentEntranceTime = DateTime.Parse(currentNode.GetData().lastEntranceInEngineRoom);

                if (newtEntranceTime < currentEntranceTime)
                {
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                }
            }
            DateTime parentEntranceTime = DateTime.Parse(lastParent.GetData().lastEntranceInEngineRoom);
            if (newtEntranceTime < parentEntranceTime)
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