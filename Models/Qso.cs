using System;

namespace qso_site.Models
{
    public class Qso
    {
        public int Id { get; set; }
        public string Call { get; set; }
        public string Gridsquare { get; set; }
        public string Mode { get; set; }
        public string RstSent { get; set; }
        public string RstReceived { get; set; }
        public DateTime QsoDate { get; set; }
        public DateTime TimeOn { get; set; }
        public DateTime QsoDateOff { get; set; }
        public DateTime TimeOff { get; set; }
        public string Band { get; set; }
        public string Freq { get; set; }
        public string StationCallsign { get; set; }
        public string MyGridsquare { get; set; }
        public string TxPower { get; set; }
    }
}