using LearnEF.Entities; 

namespace LearnEF.Services.Majors
{
    public class MajorService
    {
        private readonly UniversityDbContext _context;

        public MajorService()
        {
            _context = new UniversityDbContext();
        }

        public void CreateMajor(CreateMajorRequest request)
        {
            var major = new Major
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Status = request.Status,
                CreatedDate = DateTime.Now
            };
            _context.Majors.Add(major);
            _context.SaveChanges();
        }

        public void UpdateMajor(UpdateMajorRequest request)
        {
            var major = _context.Majors.FirstOrDefault(x => x.Id == request.Id);
            // if (major == null) throw new Exception("Major not found");
            major.Name = request.Name;
            major.Status = request.Status;
            _context.Majors.Update(major);
            _context.SaveChanges();
        }

        public void DeleteMajor(Guid majorId)
        {
            var major = _context.Majors.FirstOrDefault(x => x.Id == majorId);
            // if (major == null) throw new Exception("Major not found");
            _context.Majors.Remove(major);
            _context.SaveChanges();
        }

        public List<Major> GetMajors()
        {
            return _context.Majors.ToList();
        }
    }
}
