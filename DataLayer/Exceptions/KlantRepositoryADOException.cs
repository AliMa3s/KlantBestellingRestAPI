using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Exceptions {
    [Serializable]
    public class KlantRepositoryADOException : Exception{
        public KlantRepositoryADOException() {
        }

        public KlantRepositoryADOException(string message) : base(message) {
        }

        public KlantRepositoryADOException(string message, Exception innerException) : base(message, innerException) {
        }

        protected KlantRepositoryADOException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
