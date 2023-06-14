using AutoMapper;

namespace ConsoleAppAutoMapper
{
   
    public class Program1
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorDTO2, AuthorModel2>()
                    .ForMember(destination => destination.Address,
                        map => map.MapFrom(
                            source => new Address
                            {
                                City = source.City,
                                State = source.State,
                                Country = source.Country
                            }));
            });
        }
    }

    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class AuthorModel2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }

    public class AuthorDTO2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}