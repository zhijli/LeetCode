// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P71
    {
        public string SimplifyPath(string path)
        {
            var folders = new List<string>();
            string[] pathList = path.Split('/');
            foreach (string p in pathList)
            {
                if (p == "..")
                {
                    if (folders.Count > 0) folders.RemoveAt(folders.Count - 1);
                }
                else if (p == "." || p == "")
                {
                    continue;
                }
                else
                {
                    folders.Add(p);
                }
            }

            if (folders.Count == 0)
            {
                return "/";
            }

            var result = string.Empty;
            foreach (string folder in folders)
            {
                result += "/" + folder;
            }

            return result;
        }
    }
}
