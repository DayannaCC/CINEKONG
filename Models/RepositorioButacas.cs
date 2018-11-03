using System;
using System.Collections.Generic;

namespace CINEKONG.Models
{
    public class RepositorioButacas
    {
        private int _indabc = 0;
        private int _indnum = 1;
        private int _marc1 = 0;
        private int _marc2 = 0;
        private List<Butaca> _butacas = new List<Butaca>();

        private char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public RepositorioButacas()
        {
            for (int i = 0; i < 198; i++)
            {
                int ale = new Random().Next(2);

                if (i % 18 == 0 && i != 0)
                {
                    _indabc++;
                    _indnum = 1;
                    _marc1 = 0;
                    _marc2 = 0;
                }

                if (i < 180)
                {
                    if (_indnum == 5 && _marc1 == 0)
                    {
                        _indnum = 3;
                        _marc1++;
                    }
                    else if (_indnum == 15 && _marc2 == 0)
                    {
                        _indnum = 13;
                        _marc2++;
                    }

                    if (((_indnum == 3 || _indnum == 4) && _marc1 == 0) || ((_indnum == 13 || _indnum == 14) && _marc2 == 0))
                    {
                        _butacas.Add(new Butaca
                        {
                            idbut = "  ",
                            tipbut = "",
                            estbut = ""
                        });
                    }
                    else
                    {
                        if (i >=162)
                        {
                            _butacas.Add(new Butaca
                            {
                                idbut = "" + alpha[_indabc] + (_indnum),
                                tipbut = "preferencial",
                                estbut = "ocupada"
                            });
                        }
                        else{

                            if (ale == 0)
                            {
                                _butacas.Add(new Butaca
                                {
                                    idbut = "" + alpha[_indabc] + (_indnum),
                                    tipbut = "tradicional",
                                    estbut = "disponible"
                                });
                            }
                            else
                            {
                                _butacas.Add(new Butaca
                                {
                                    idbut = "" + alpha[_indabc] + (_indnum),
                                    tipbut = "tradicional",
                                    estbut = "ocupada"
                                });
                            }
                        }
                    }
                }
                else
                {
                    _butacas.Add(new Butaca
                    {
                        idbut = "" + alpha[_indabc] + (_indnum),
                        tipbut = "preferencial",
                        estbut = "ocupada"
                    });
                }

                _indnum++;

            }
        }

        public List<Butaca> obtenerButacas()
        {
            return _butacas;
        }

    }
}