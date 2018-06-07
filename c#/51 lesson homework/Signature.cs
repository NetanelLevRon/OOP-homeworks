﻿namespace DelegateEvent
{
    public class Signature
    {
        public string FullName { get; }
        public string FullSignature { get; }

        public Signature(string fullName, string fullSignature)
        {
            FullName = fullName;
            FullSignature = fullSignature;
        }
    }

}
