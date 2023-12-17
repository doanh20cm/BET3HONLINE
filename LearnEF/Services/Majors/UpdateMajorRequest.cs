namespace LearnEF.Services.Majors
{
    public class UpdateMajorRequest
    {
        public Guid Id { get; set; }
        public EntityStatus Status { get; set; }
        public string Name { get; set; }
    }
}
