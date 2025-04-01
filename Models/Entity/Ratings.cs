namespace Restaurent.Models.Entity
{
    public partial class Ratings
    {
        public long? Id { get; set; }

        public int? Rating { get; set; }

        public string? Comment { get; set; }

        public long? UserID { get; set; }

        public long? ProductID { get; set; }

        public long? BlogID { get; set; }

        public short? Status { get; set; }

        public DateTime? CreateDate { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateBy { get; set; }
    }
}
