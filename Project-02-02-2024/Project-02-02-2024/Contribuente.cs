﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02_02_2024
{

    // dichiarazione classe
    public class Contribuente
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public char Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }

        // costruttore base
        public Contribuente() { }

        // costruttore personalizzato
        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, double redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        // metodo per calcolo aliquote
        public double CalcoloImposta()
        {
            double imposta = 0;

            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23;
            } 
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                imposta = 3450 + ((RedditoAnnuale - 15000) * 0.27);   
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                imposta = 6960 + ((RedditoAnnuale - 28000) * 0.38);
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                imposta = 17220 + ((RedditoAnnuale - 55000) * 0.41);
            }
            else
            {
                imposta = 25420 + ((RedditoAnnuale - 75000) * 0.43);
            }

            return imposta;
        }
    }
}
