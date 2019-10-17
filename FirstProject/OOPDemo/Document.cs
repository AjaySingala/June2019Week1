using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    class Document
    {
        public string Name;
        // Possible values: New, InProgress, ToReview, Approved, Rejected
        public Utility.DocumentStatus Status;
    }
}
