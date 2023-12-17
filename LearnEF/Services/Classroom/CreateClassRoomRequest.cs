namespace LearnEF.Services.Classroom
{
    public class CreateClassRoomRequest
    {
        public string Name { get; set; }
        public Guid MajorId { get; set; }
        public EntityStatus Status { get; set; }
    }
}
