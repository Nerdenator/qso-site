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
        public string RstRcvd { get; set; }
        public DateTime QsoDateTimeOn { get; set; }
        public DateTime QsoDateTimeOff { get; set; }
        public DateTime TimeOff { get; set; }
        public string Band { get; set; }
        public string Freq { get; set; }
        public string StationCallsign { get; set; }
        public string MyGridsquare { get; set; }
        public string TxPower { get; set; }
    }
}