using System;
using System.Runtime.Serialization;

namespace RestApiLayer.Mappers {
    [Serializable]
    public class MapNaarDomeinException : Exception {
        public MapNaarDomeinException() {
        }

        public MapNaarDomeinException(string message) : base(message) {
        }

        public MapNaarDomeinException(string message, Exception innerException) : base(message, innerException) {
        }

        protected MapNaarDomeinException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}