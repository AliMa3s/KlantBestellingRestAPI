using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiLayer.Model.Input {
    public class BestellingRESTInputDTO {
        #region Properties
        public int KlantId { get; set; }
        public int Product { get; set; }
        public int Aantal { get; set; }
        #endregion
    }
}
