﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeApp
{
    /// <summary>
    /// 热题100道
    /// </summary>
    public static class HotTopic
    {
        /// <summary>
        /// 字母异位词
        /// 字母异位词 是由重新排列源单词的所有字母得到的一个新单词。
        /// 示例 1: 
        ///     输入: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]   
        ///     输出: [["bat"],["nat","tan"],["ate","eat","tea"]]
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs == null || strs.Length == 0)
                return new List<IList<string>>();
            var dic = new Dictionary<string, IList<string>>();
            foreach(string str in strs) 
            {
                var newStr = string.Join("",str.OrderBy(s => s));
                if (!dic.ContainsKey(newStr))
                {
                    dic[newStr] = new List<string>();
                }
                dic[newStr].Add(str);
            }
            return dic.Values.ToList();
        }

        /// <summary>
        /// 最长连续序列
        /// 给定一个未排序的整数数组 nums ，找出数字连续的最长序列（不要求序列元素在原数组中连续）的长度
        /// 请你设计并实现时间复杂度为 O(n) 的算法解决此问题。
        /// </summary>
        /// <param name="nums">nums = [100,4,200,1,3,2]</param>
        /// <returns>4,最长数字连续序列是 [1, 2, 3, 4]。它的长度为 4。</returns>
        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            var hashTable = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!hashTable.Contains(num))
                    hashTable.Add(num);
            }
            var result = 0;
            foreach (int num in hashTable)
            {
                if (hashTable.Contains(num - 1))
                    continue;
                int currentNum = num;
                int currentStreak = 1;
                while (hashTable.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }
                result = Math.Max(result, currentStreak);
            }
           
            return result;
        }
    }
}
