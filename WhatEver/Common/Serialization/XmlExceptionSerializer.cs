

namespace WhatEver.Common.Serialization
{
    protected Exception Exception { get; private set; }
    
    public class XmlExceptionSerializer
    {
        public XmlExceptionSerializer(Excpetion exception)
        {
            this.Exception = exception;
        }
    }
}
