//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAmp2.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            this.AlbumSongArtist = new HashSet<AlbumSongArtist>();
            this.PlayListDetail = new HashSet<PlayListDetail>();
        }
    
        public int IdSong { get; set; }
        public int IdGenre { get; set; }
        public string Name { get; set; }
        public System.TimeSpan Length { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbumSongArtist> AlbumSongArtist { get; set; }
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayListDetail> PlayListDetail { get; set; }
    }
}
