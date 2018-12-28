

namespace WhatEver.Common.Serialization
{
    public class XmlExceptionSerializer
    {
        /// <summary>
        /// Obtiene la excepción a serializar.
        /// </summary>
        protected Exception Exception { get; private set; }
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase XmlExceptionSerializer.
        /// </summary>
        public XmlExceptionSerializer(Excpetion exception)
        {
            this.Exception = exception;
        }
    }
}
