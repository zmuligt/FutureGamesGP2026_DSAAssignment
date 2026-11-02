using UnityEngine;
using System.Collections.Generic;


namespace Utils{
    
    public class Hashmap 
    {
        private List<int>[] hashMap;

        public Hashmap()
        {
            hashMap = new[] {new List<int>()};
        }
        private static int computeHash(int valueToHash, int hashMapLength)
        {
            if(hashMapLength == 0)
            {
                return -1;
            }

            return valueToHash % hashMapLength;
        }

        public void put(int inNewValue)
        {
            int hash = computeHash(inNewValue, hashMap.Length);

            //if bucket = empty
            if(hashMap[hash].Count == 0)
            {
                hashMap[hash].Add(inNewValue);
            }
            else
            {
                //handle collision
                int i;
                hashMap[hash].Add(inNewValue);
                
                for(i = 0; i < hashMap[hash].Count; i++)
                {
                    
                }
                hashMap[hash][i] = inNewValue;
            }
            
            
        }

        public void get(int inValueToSearch)
        {
            
        }
    }
}