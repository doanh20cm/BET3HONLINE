using LearnEF.Entities;

namespace LearnEF.Services.Classroom
{
    public class ClassRoomService
    {
        private readonly UniversityDbContext _context;

        public ClassRoomService()
        {
            _context = new UniversityDbContext();
        }

        public void CreateClassRoom(CreateClassRoomRequest request)
        {
            var classRoom = new ClassRoom
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Status = request.Status,
                CreatedDate = DateTime.Now,
                MajorId = request.MajorId
            };
            _context.ClassRooms.Add(classRoom);
            _context.SaveChanges();
        }

        public void UpdateClassRoom(UpdateClassRoomRequest request)
        {
            var classRoom = _context.ClassRooms.FirstOrDefault(x => x.Id == request.Id);
            // if (classRoom == null) throw new Exception("ClassRoom not found");
            classRoom.Name = request.Name;
            classRoom.Status = request.Status;
            classRoom.MajorId = request.MajorId;
            _context.ClassRooms.Update(classRoom);
            _context.SaveChanges();
        }

        public void DeleteClassRoom(Guid classRoomId)
        {
            var classRoom = _context.ClassRooms.FirstOrDefault(x => x.Id == classRoomId);
            // if (classRoom == null) throw new Exception("ClassRoom not found");
            _context.ClassRooms.Remove(classRoom);
            _context.SaveChanges();
        }

        public List<ClassRoom> GetClassRooms()
        {
            return _context.ClassRooms.ToList();
        }
    }
}
