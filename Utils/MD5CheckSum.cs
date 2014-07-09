﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JFrog.Artifactory.Utils
{
    /// <summary>
    /// generate a SHA1 to a given file
    /// </summary>
    public class MD5CheckSum
    {

        /// <summary>
        /// generate the SHA1 for a file
        /// </summary>
        /// <param name="path">the path for the file and its name</param>
        /// <returns>SHA1 as string</returns>
        public string GenerateMD5(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var md5 = MD5.Create())
            {
                return BitConverter.ToString(md5.ComputeHash(fs)).Replace("-", "").ToLower();
            }
        }
    }
}