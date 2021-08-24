using qso_site.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace qso_site.Services
{
    public static class QsoService
    {
        static List<Qso> Qsos { get; }
        static int nextId = 3;
        static QsoService() 
        {
            Qsos = new List<Qso>
            {
                new Qso
                {
                    Id = 1,
                    Call = "N9123",
                    Gridsquare = "EN52",
                    Mode = "FT8",
                    RstSent = "+08",
                    RstRcvd = "0",
                    QsoDateTimeOn = new DateTime(2021, 07, 24, 21, 07, 03),
                    QsoDateTimeOff = new DateTime(2021, 07, 24, 21, 07, 24),
                    Band = "10m",
                    Freq = "28.075352",
                    StationCallsign = "KJ7YJM",
                    MyGridsquare = "EM29QE",
                    TxPower = "5w"
                }
            };
        }
        public static List<Qso> GetAll() => Qsos;

        public static Qso Get(int id) => Qsos.FirstOrDefault(q => q.Id == id);
            
        public static void Add(Qso qso) 
        {
            qso.Id = nextId++;
            Qsos.Add(qso);
        }

        public static void Delete (int id)
        {
            var qso = Get(id);
            if(qso is null){
                return;
            }

            Qsos.Remove(qso);
        }

        public static void Update(Qso qso)
        {
            var index = Qsos.FindIndex(q => q.Id == qso.Id);
            if (index == -1) {
                return;
            }

            Qsos[index] = qso;
        }
    }
}
