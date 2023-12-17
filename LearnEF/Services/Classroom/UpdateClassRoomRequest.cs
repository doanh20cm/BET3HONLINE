namespace LearnEF.Services.Classroom
{
    public class UpdateClassRoomRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid MajorId { get; set; }
        public EntityStatus Status { get; set; }
    }
}
