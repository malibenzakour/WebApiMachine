
namespace WebApiMachine.Models
{
    public partial class Article
    {
        /// <summary>
        /// Id de l'article
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Libellé de l'article
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prix d'article
        /// </summary>
        public string Prix { get; set; }

        /// <summary>
        /// Url de l'image article
        /// </summary>
        public string UrlImage { get; set; }

        /// <summary>
        /// Quantité
        /// </summary>
        public int? Quantite { get; set; }

        /// <summary>
        /// Type d'article
        /// </summary>
        public string TypeArticle { get; set; }

        /// <summary>
        /// Code postal.
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Cl.
        /// </summary>
        public int? Cl { get; set; }
    }
}
