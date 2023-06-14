using System;
using AutoMapper;

namespace ConsoleAppAutoMapper
{
    class Program
    {
        static void Main1(string[] args)
        {
 
          var config = new MapperConfiguration(cfg =>
          {
              cfg.CreateMap<AuthorModel, AuthorDTO>()
                  .ForMember(destination => destination.ContactDetails,
                      opts => 
                          opts.MapFrom(source => 
                              source.FirstName));
          });
           
            IMapper iMapper = config.CreateMapper();
           
            var source = new AuthorModel();
            source.Id = 1;
            source.FirstName = "Joydip";
            source.LastName = "Kanjilal";
            source.Address = "India";
            
            
            var destination = iMapper.Map<AuthorModel, AuthorDTO>(source);
           
            Console.WriteLine($"Author Name: {destination.FirstName} {destination.LastName}");
            Console.WriteLine($"ContactDatails Name: {destination.ContactDetails}");
            Console.WriteLine("Hello World!");
        }
    }

    public class AuthorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string ContactDetails { get; set; }
    }
}