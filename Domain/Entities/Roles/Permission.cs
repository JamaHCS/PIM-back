namespace Domain.Entities.Roles
{
    public class Permission
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string? FrontendRoute { get; set; } = default!;
        public string? Label { get; set; } = default!;
    }
}
