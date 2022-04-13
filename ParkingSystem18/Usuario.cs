using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class Usuario
    {
        private string user;
        private string password;
        private DateTime ultAcceso;
        private string pregunta;
        private string respuesta;

        public Usuario(string user, string password,DateTime ultacceso)
        {
            this.user = user;
            this.password = password;
            this.ultAcceso = ultacceso;
            
        }

        public Usuario()
        {
            

        }

        public Usuario(string user, string password,string pregunta,string respuesta)
        {
            this.user = user;
            this.password = password;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.ultAcceso = DateTime.Now;
        }

        public override string ToString()
        {
            return user;
        }


        public DateTime UltAcceso
        {
            get
            {
                return ultAcceso;
            }

            set
            {
                ultAcceso = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Pregunta
        {
            get
            {
                return pregunta;
            }

            set
            {
                pregunta = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public void CambiarClave(string password,string user)
        { this.password = password;
            this.user = user;
        }

        public void CambiarPregunta(string pregunta,string respuesta)
        {  this.pregunta = pregunta;
            this.respuesta = respuesta;
        }
       
      
    }
}