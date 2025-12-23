namespace EventManager.Server.Models
{
    public class Event
    {
        public int Id { get; set; } // Ajout de la clé primaire
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; } // Utilisation de DateTime pour les dates
        public string Description { get; set; } = string.Empty;

        // Relation : Un événement se passe dans une scène
        public int SceneId { get; set; }
        public Scene Location { get; set; } = null!;
    }
}
