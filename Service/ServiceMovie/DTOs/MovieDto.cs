using Service.ServiceBase.DTOs;

namespace Service.ServiceMovie.DTOs
{
    public class MovieDto : BaseDto
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
    }
}
