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
    [Table("Albums")]
    internal class Album
    {
        private string _Label;
        
        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage ="Album title is required")]
        [StringLength(120, ErrorMessage = "Album Title limited to 120 characters")]
        public string Title { get; set; }

        public int ArtistId { get; set; }

        public int ReleaseYear { get; set; }

        [StringLength(50, ErrorMessage = "Release Label limited to 50 characters")]
        public string ReleaseLabel
        {
            get
            { return _Label; }
            set
            { _Label = string.IsNullOrEmpty(value) ? null : value; }
        }

        //[NotMapped] annotations are also allowed

        // navigational properties
        //many to one direction, child to parent
        public virtual Artist Artist { get; set; }

        //Nav property
        //one to many, parent to child
        public virtual ICollection<Album> Albums { get; set; }
    }
}
