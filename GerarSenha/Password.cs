using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarSenha
{
    internal class Password
    {

        private string _password;
        public string Senha
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        public string passwordGenerator(int size)
        {
            Random random = new Random();
            int aux = 0;
            string padrao = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890987654321_?!";
            string senha = "";
            for (int i = 0; i < size; i++)
            {
                aux = random.Next(0, 73);
                senha = padrao[aux] + senha;
            }
            return senha;
        }
    }
}
