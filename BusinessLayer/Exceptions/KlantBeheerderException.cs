using System;
using System.Runtime.Serialization;

namespace BusinessLayer.Managers {
    [Serializable]
    public class KlantBeheerderException : Exception {
        public KlantBeheerderException() {
        }

        public KlantBeheerderException(string message) : base(message) {
        }

        public KlantBeheerderException(string message, Exception innerException) : base(message, innerException) {
        }

        protected KlantBeheerderException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}