using System;
using System.Collections.Generic;

namespace CINEKONG.Models
{
    public class RepositorioButacas
    {
        private int _ind = 0;
        private int _ind2 = 0;
        private List<Butaca> _butacas = new List<Butaca>();

        private char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public RepositorioButacas(){
            for (int i = 0; i <90; i++)
            {
                int ale = new Random().Next(2);

                if (i%18==0 && i!=0){
                    _ind++;
                    _ind2=0;
                    }
                    _ind2++;

                if(i<54){
                    if(ale==0){
                        _butacas.Add(new Butaca
                        {
                            idbut = "" + alpha[_ind] + (_ind2),
                            tipbut = "tradicional",
                            estbut = "disponible"
                        });
                    } else {
                        _butacas.Add(new Butaca
                        {
                            idbut = "" + alpha[_ind] + (_ind2),
                            tipbut = "tradicional",
                            estbut = "ocupada"
                        });
                    }
                    
                    }else{
                        _butacas.Add(new Butaca{
                    idbut=""+alpha[_ind]+(_ind2),
                    tipbut="preferencial",
                    estbut="ocupada"
                });
                    }

            }
        }

        public List<Butaca> obtenerButacas() {
            return _butacas;
        }

    }
}