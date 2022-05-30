using System.Collections.Generic;

namespace ConcentrameApi.Models
{
    public static class DbContext
    {
        public static void InitialLoad()
        {
            Notice = new List<Notice>();

            Notice.Add(new Notice { Id = 1, Title = "Takeda ayuda a dos proyectos de realidad virtual para ayudar a niños con TDAH", Category = "tecnology", UrL = "https://www.infosalus.com/farmacia/noticia-takeda-ayuda-dos-proyectos-realidad-virtual-mejorar-habilidades-ejecutivas-ninos-tdah-20220518102442.html" });

            Notice.Add(new Notice { Id = 2, Title = "La atención de los niños con TDAH mejora si toman frutas y verduras", Category = "food", UrL = "https://www.webconsultas.com/noticias/dieta-y-nutricion/la-atencion-de-los-ninos-con-tdah-mejora-si-toman-frutas-y-verduras" });

            Notice.Add(new Notice { Id = 3, Title = "Windows 11 integra nuevas funciones pensadas en personas con TDAH", Category = "tecnology", UrL = "https://news.microsoft.com/es-xl/windows-11-integra-nuevas-funciones-pensadas-en-personas-con-tdah-y-dificultades-auditivas/" });

            Notice.Add(new Notice { Id = 4, Title = "Así influye la dieta en los niños que tienen TDAH", Category = "food", UrL = "https://www.lavanguardia.com/mamas-y-papas/20220523/8287718/asi-influye-dieta-ninos-tdah-nbs.html" });
        }

        public static List<Notice> Notice { get; set; }
    }
}
