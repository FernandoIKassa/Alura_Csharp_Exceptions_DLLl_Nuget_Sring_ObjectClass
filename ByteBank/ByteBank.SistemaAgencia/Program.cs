﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "pagina?argumentos";
            //int indiceInterrogacao = url.IndexOf("?");
            //Console.WriteLine(indiceInterrogacao);
            //
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //
            //Console.WriteLine(url);
            //Console.WriteLine(argumentos);

            //string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            //Console.WriteLine(extrator.GetValor("moedaOrigem")); // real
            //Console.WriteLine(extrator.GetValor("moedaDestino")); // dolar
            //Console.WriteLine(extrator.GetValor("valor")); // 1500

            //REGEX - another examples
            //string patternPhone = "[0123456789][0123456789][0123456789][0123456789][-])[0123456789][0123456789][0123456789][0123456789]"
            //string patternPhone = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string patternPhone = "[0-9]{4}[-][0-9]{4}";
            //string patternPhoneCellPhone = "[0-9]{4,5}[-][0-9]{4,5}";
            //string patternPhoneCellPhone = "[0-9]{4,5}-[0,1][0-9]{4,5}";
            //string patternPhoneCellPhone = "[0-9]{4,5}-?[0-9]{4,5}";

            /*string padraoNumeroTelefoneCelular = "[0-9]{4,5}-?[0-9]{4,5}";
            string texto = "Meu numero de celular é 91234-1234.";

            Match match = Regex.Match(texto, padraoNumeroTelefoneCelular);
            Console.WriteLine(match.Value);*/


            //Override ToString to print objects
            /*ContaCorrente conta = new ContaCorrente(1234, 1234567);
            Console.WriteLine(conta);*/

            Cliente fernando1 = new Cliente();
            fernando1.Nome = "Fernando";
            fernando1.CPF = "123.123.123.-79";
            fernando1.Profissao = "Suporte L2";

            Cliente fernando2 = new Cliente();
            fernando2.Nome = "Fernando";
            fernando2.CPF = "123.123.123.-79";
            fernando2.Profissao = "Suporte L2";

            Console.WriteLine(fernando1.Equals(fernando2));

            Console.ReadLine();
        }

        
    }
}
