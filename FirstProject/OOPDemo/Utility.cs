using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    static class Utility
    {

        public enum DocumentStatus
        {
            New = 2,
            InProgress = 4,
            InReview = 6,
            Approved = 8,
            Rejected = 10
        }

        private static string _name;
        public static string GetValue()
        {
            return _name;
        }

        public static void SetValue(string name)
        {
            _name = name;
        }
    }
}
