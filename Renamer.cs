using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace LJM_Utils
{
    class Renamer
    {
        /// <summary>
        /// The directory assigned for this renamer execution
        /// </summary>
        public string TargetDirectory { get; set; }
        public string[] ExtenstionInclusions { get; set; } = null;
        /// <summary>
        /// The amount of files that can be or have been renamed
        /// </summary>
        public int FileCount { get; set; } = 0;

        /// <summary>
        /// Renames the file by using File.Move() 
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        /// <exception cref="FileNotFoundException"> When oldPath does not exist</exception>
        /// <exception cref="ArgumentException"> When newPath is invalid (in name or if new
        /// path already exists.</exception>
        public void RenameFile(string oldPath, string newPath)
        {
            if (!File.Exists(oldPath))
                throw new FileNotFoundException($"File \"{oldPath}\" does not exist");

            if (newPath.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                throw new ArgumentException($"Renamed path \"{newPath}\" is not a valid path.", "newPath");

            if (File.Exists(newPath))
                throw new ArgumentException($"Renamed path \"{newPath}\" already exists.");

            File.Move(oldPath, newPath);
        }

        /// <summary>
        /// Returns a string array based off of Renamer instance's TargetDirectory and
        /// ExtenstionInclusions.
        /// </summary>
        public string[] GetFiles()
        {
            List<string> matchingFiles = new List<string>();

            if (this.ExtenstionInclusions != null)
            {
                foreach (string ext in this.ExtenstionInclusions)
                {
                    foreach (string filePath in Directory.GetFiles(this.TargetDirectory, searchPattern: "*" + ext))
                    {
                        matchingFiles.Add(filePath);
                    }
                }

                this.FileCount = matchingFiles.ToArray().Length;
                return matchingFiles.ToArray();
            }
            else
            {
                return Directory.GetFiles(this.TargetDirectory);
            }
        }

        public virtual void Execute()
        {
            throw new NotImplementedException("Base class invocation of Execute is not available.");
        }

    }

    class LinearRenamer : Renamer
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }

        public LinearRenamer(string folderPath, string[] extInclusions, string prefix = "", string suffix = "")
        {
            this.Prefix = prefix.Trim();
            this.Suffix = suffix.Trim();
            this.TargetDirectory = folderPath;
            this.ExtenstionInclusions = extInclusions;
        }

        public override void Execute()
        {
            int num = 1;
            int paddingWidth;
            string paddedNumber;
            string fileNameFormatString = this.TargetDirectory + Path.DirectorySeparatorChar;
            string[] renamePaths = GetFiles();
            Array.Sort(renamePaths);

            if (renamePaths.Length < 99)
            {
                paddingWidth = 2;
            }
            else if (renamePaths.Length < 999)
            {
                paddingWidth = 3;
            }
            else
            {
                paddingWidth = 4;
            }

            string newFilename, newPath;
            foreach (string filePath in renamePaths)
            {
                paddedNumber = num.ToString().PadLeft(paddingWidth, '0');
                newFilename = $"{Prefix} {paddedNumber} {Suffix}".Trim() + Path.GetExtension(filePath);
                newPath = Path.Combine(this.TargetDirectory, newFilename);

                RenameFile(filePath, newPath);
                num++;
            }
        }

        public static string ExampleFilename(string examplePrefix, string exampleSuffix)
        {
            return $"{examplePrefix} 05 {exampleSuffix}".Trim() + ".mkv";
        }
    }

    class RandomRenamer : Renamer
    {
        public long RandMin { get; set; }
        public long RandMax { get; set; }

        public RandomRenamer(string folderPath, string[] extInclusions, int chars = 15)
        {
            this.TargetDirectory = folderPath;
            this.ExtenstionInclusions = extInclusions;
            this.RandMin = Convert.ToInt64("1".PadRight(chars, '0'));
            this.RandMax = Convert.ToInt64("9".PadRight(chars, '9'));
        }

        public static long LongRandom(long min, long max)
        {
            // Source: https://stackoverflow.com/a/6651661
            Random rand = new Random();
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        public override void Execute()
        {
            string newPath, newName;
            int loopCount;

            foreach (string filePath in GetFiles())
            {
                loopCount = 0;
                do
                {
                    if (loopCount > 20)
                    {
                        throw new Exception("Random number generation may be insufficient, naming loop has ran over 20 times.");
                    }
                    loopCount++;
                    newName = PrepareFileName(filePath);
                    newPath = Path.Combine(Path.GetDirectoryName(filePath), newName);
                    Thread.Sleep(50);
                } while (File.Exists(newPath));

                RenameFile(filePath, newPath);
            }
        }

        private string PrepareFileName(string filePath)
        {
            Random newRand = new Random();
            long randomNumber = LongRandom(this.RandMin, this.RandMax);

            return Convert.ToString(randomNumber) + Path.GetExtension(filePath);
        }

        public static string ExampleFilename(int chars)
        {
            long exampleRandMin = Convert.ToInt64("1".PadRight(chars, '0'));
            long exampleRandMax = Convert.ToInt64("9".PadRight(chars, '9'));
            Random newRand = new Random();
            long randomNumber = LongRandom(exampleRandMin, exampleRandMax);

            return $"{Convert.ToString(randomNumber)}.mkv";
        }
    }
}
