namespace CohesionAndCoupling.Models
{
    using System;

    internal class FileExtension
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("There is no dot in the provided file name.");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("There is no dot in the provided file name.");
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
