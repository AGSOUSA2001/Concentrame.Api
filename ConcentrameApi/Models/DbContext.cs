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



            Link = new List<Link>();

            Link.Add(new Link { Id = 1, Title = "¿Qué es el TDAH?", UrL = "https://www.understood.org/es-mx/articles/what-is-adhd" });

            Link.Add(new Link { Id = 2, Title = "Reportaje sobre el TDAH", UrL = "https://www.youtube.com/watch?v=5KwntBMi3l4" });

            Link.Add(new Link { Id = 3, Title = "Los principales tipos de TDH y TDAH", UrL = "https://www.publico.es/psicologia-y-mente/los-principales-tipos-de-tdh-y-tdah/" });

            Link.Add(new Link { Id = 4, Title = "9 recomendaciones para padres de niños con TDAH", UrL = "https://lamenteesmaravillosa.com/recomendaciones-padres-ninos-tdah/" });

            Link.Add(new Link { Id = 5, Title = "Déficit de atención por ensoñación desadaptativa", UrL = "https://www.investigacionyciencia.es/noticias/dficit-de-atencin-por-ensoacin-desadaptativa-20926" });

            Link.Add(new Link { Id = 6, Title = "Canal de Youtube de ayuda contra el TDAH", UrL = "https://www.youtube.com/user/tdahytu" });

            Link.Add(new Link { Id = 7, Title = "Animación TDAH", UrL = "https://www.youtube.com/watch?v=Hf3UDfp-qUs" });
        }

        public static List<Notice> Notice { get; set; }
        public static List<Link> Link { get; set; }
    }
}
