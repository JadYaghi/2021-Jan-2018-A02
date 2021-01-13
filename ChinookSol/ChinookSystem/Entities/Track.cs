using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion


namespace ChinookSystem.Entities
{
    [Table("Tracks")]
    class Track
    {
        private string _Composer;

        [Key]
        public int TrackId { get; set; }

        public string Name { get; set; }

        public int? AlbumId { get; set; }

        public int MediaTypeId { get; set; }

        public int? GenreId { get; set; }

        [StringLength(220, ErrorMessage = "Composer Name limited to 220 characters")]
        public string Composer { get {return _Composer; } set {;  _Composer = string.IsNullOrEmpty(value) ? null : value; } }

        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public int UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual MediaType MediaType { get; set; }

        public ICollection<>


    }
}
