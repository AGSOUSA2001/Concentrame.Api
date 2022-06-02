using System.Collections.Generic;

namespace ConcentrameApi.Models
{
    public static class DbContext
    {
        public static void InitialLoad()
        {
            Notice = new List<Notice>();

            Notice.Add(new Notice { Id = 1, Title = "Takeda ayuda a dos proyectos de realidad virtual para ayudar a niños con TDAH", Category = "tecnology", Url = "https://www.infosalus.com/farmacia/noticia-takeda-ayuda-dos-proyectos-realidad-virtual-mejorar-habilidades-ejecutivas-ninos-tdah-20220518102442.html", Date = "18 de Mayo de 2022", Paragraph1 = "La II edición de la 'Convocatoria de Ayudas Shibuya: Proyectos Innovadores en TDAH', impulsada por Takeda, ha seleccionado a dos proyectos de realidad virtual que tienen como objetivo mejorar las habilidades ejecutivas de los niños con trastorno por déficit de atención e hiperactividad (TDAH).", Paragraph2 = "Se trata del 'The Secret Trail of Moon', del Hospital Universitario Puerta de Hierro Majadahonda, en Madrid, y 'CogFun-RV', de la Universidad de Granada, los cuales se basan en el uso de la realidad virtual a través de los videojuegos como herramientas para mejorar la calidad de vida de las personas con este trastorno.", Paragraph3 = "Cada una de las iniciativas recibirá 10.000 euros que servirán para financiar su desarrollo y perfeccionamiento. La decisión del comité evaluador se ha basado en el análisis de las propuestas de diversas entidades españolas de acuerdo con sus objetivos, los medios empleados, los recursos disponibles, su labor investigativa, la replicabilidad que el proyecto pudiera tener a nivel sanitario y los resultados que se pretenden alcanzar para la mejora de las personas con TDAH." });

            Notice.Add(new Notice { Id = 2, Title = "Windows 11 integra nuevas funciones pensadas en personas con TDAH", Category = "tecnology", Url = "https://news.microsoft.com/es-xl/windows-11-integra-nuevas-funciones-pensadas-en-personas-con-tdah-y-dificultades-auditivas/", Date = "19 de Mayo de 2022", Paragraph1 = "Sesiones Focus y Subtítulos en vivo son dos experiencias nuevas que Microsoft desarrolló pensando en apoyar a personas con discapacidad.", Paragraph2 = "Esta nueva experiencia fue diseñada para ayudar a esta comunidad y a todos los usuarios a concentrarse. Ahora no solamente se simplifica el control de notificaciones cuando se activa la función “No molestar”, sino que se crearon las sesiones Focus, en donde se desactivan las insignias de la barra de tareas. Esta función se integró dentro de la aplicación Reloj, desde donde se pueden configurar temporizadores y también alarmas para tomar descansos. Además, está integrado con Spotify, para que optimicen su entorno con su audio favorito mientras trabajan.", Paragraph3 = "Para ayudar a personas con alguna discapacidad auditiva, Microsoft trabajó en integrar subtítulos en más contextos que antes. En Windows 11 se puede transcribir de manera automática el contenido hablado de cualquier audio, incluso en aplicaciones como Microsoft Edge o con micrófonos, lo que significa que pueden obtener subtítulos en vivo de una conversación." });

            Notice.Add(new Notice { Id = 3, Title = "La atención de los niños con TDAH mejora si toman frutas y verduras", Category = "food", Url = "https://www.webconsultas.com/noticias/dieta-y-nutricion/la-atencion-de-los-ninos-con-tdah-mejora-si-toman-frutas-y-verduras", Date = "20 de Mayo de 2022", Paragraph1 = "Los niños con TDAH que toman una dieta saludable con muchas frutas y verduras que les aporta las vitaminas y minerales que necesitan tienen síntomas menos graves de falta de atención y controlan mejor sus emociones.", Paragraph2 = "Todos tenemos buenas razones para incluir en nuestra dieta diaria las cinco raciones de frutas y verduras que recomiendan los expertos, como mínimo, ya que hay estudios que han encontrado que duplicar esta cantidad proporciona beneficios adicionales para nuestra salud y longevidad. Ahora, además, un nuevo estudio revela que estos alimentos son especialmente aconsejables en los niños con trastorno por déficit de atención con hiperactividad (TDAH) porque les ayudan a disminuir los problemas de falta de atención que sufren.", Paragraph3 = "Los resultados, que se han publicado en Nutritional Neuroscience, mostraron que los niños que consumían más frutas y verduras manifestaban síntomas menos graves de falta de atención, según ha afirmado Irene Hatsu, coautora del estudio y profesora asociada de nutrición humana en la Universidad Estatal de Ohio. “Comer una dieta saludable, que incluya frutas y verduras, puede ser una forma de reducir algunos de los síntomas del TDAH”, señala." });

            Notice.Add(new Notice { Id = 4, Title = "Así influye la dieta en los niños que tienen TDAH", Category = "food", Url = "https://www.lavanguardia.com/mamas-y-papas/20220523/8287718/asi-influye-dieta-ninos-tdah-nbs.html", Date = "23 de Mayo de 2022", Paragraph1 = "Los avances en nutrición en los últimos años han permitido conocer cómo la dieta puede influir en la sintomatología de determinadas enfermedades. Es lo que ocurre con el TDAH. Esta patología psiquiátrica -que afecta a entre un 5 y un 7% de los niños según la OMS-y que desencadena problemas de concentración y de atención, la desorganización e incapacidad para emprender, desarrollar y finalizar trabajos o tareas, la inconsistencia, la imposibilidad de planificarse de una forma adecuada o los despistes continuos", Paragraph2 = "Un estudio reciente llevado a cabo en Estados Unidos y Canadá por la Universidad Estatal de Ohio y publicado en Nutritional Neuroscience, el consumo de frutas y verduras puede ayudar a reducir los síntomas de los niños. Los expertos realizaron un seguimiento en menores de entre 6 y 12 años durante un periodo de 90 días, registrando el comportamiento de los mismos. ", Paragraph3 = "Los expertos concluyen que los resultados del estudio muestran que los niños que consumen más frutas y verduras muestran síntomas menos graves de falta de atención: 'llevar a cabo una dieta saludable, que incluya frutas y verduras, podría ser una forma de reducir algunos de los síntomas del TDAH', aseguran." });



            Link = new List<Link>();

            Link.Add(new Link { Id = 1, Title = "¿Qué es el TDAH?", Url = "https://www.understood.org/es-mx/articles/what-is-adhd" });

            Link.Add(new Link { Id = 2, Title = "Reportaje sobre el TDAH", Url = "https://www.youtube.com/watch?v=5KwntBMi3l4" });

            Link.Add(new Link { Id = 3, Title = "Los principales tipos de TDH y TDAH", Url = "https://www.publico.es/psicologia-y-mente/los-principales-tipos-de-tdh-y-tdah/" });

            Link.Add(new Link { Id = 4, Title = "9 recomendaciones para padres de niños con TDAH", Url = "https://lamenteesmaravillosa.com/recomendaciones-padres-ninos-tdah/" });

            Link.Add(new Link { Id = 5, Title = "Déficit de atención por ensoñación desadaptativa", Url = "https://www.investigacionyciencia.es/noticias/dficit-de-atencin-por-ensoacin-desadaptativa-20926" });

            Link.Add(new Link { Id = 6, Title = "Canal de Youtube de ayuda contra el TDAH", Url = "https://www.youtube.com/user/tdahytu" });

            Link.Add(new Link { Id = 7, Title = "Animación TDAH", Url = "https://www.youtube.com/watch?v=Hf3UDfp-qUs" });
        }

        public static List<Notice> Notice { get; set; }
        public static List<Link> Link { get; set; }
    }
}
