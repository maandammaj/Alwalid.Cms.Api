namespace Alwalid.Cms.Api.Entities
{
    public class Feedback : Shared.AuditableEntity
    {
        public int Id { get; set; }
        
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Comment { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty; // e.g., Engineer, Accountant, etc.
        public bool IsActive { get; set; } = true;
        public int Rating { get; set; } = 5; // 1-5 star rating
    }
}
