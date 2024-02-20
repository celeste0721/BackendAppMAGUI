using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
ggfgfgg
namespace BackendApp.Entidades
{
    public class ObtenerPreguntasApi
    {
        public string question {  get; set; }
        public string correctAnswer { get; set;}
        public string incorrectAnswer { get; set;}
        public List<string> tags { get; set;}
        public string type { get; set;}
        public string difficulty { get; set; }
        public List<string> regions { get; set; }
        public bool isNiche { get; set; }

    }
}
