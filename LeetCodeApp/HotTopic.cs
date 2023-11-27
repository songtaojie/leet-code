using System;
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
    }
}
