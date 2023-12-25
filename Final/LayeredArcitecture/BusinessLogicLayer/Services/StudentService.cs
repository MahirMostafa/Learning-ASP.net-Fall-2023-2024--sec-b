using AutoMapper;
using BusinessLogicLayer.DTOS;
using DataAccessLayer.EF.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StudentService
    {
        public static List<StudentDTO> Get()
        {
            var data = StudentRepo.Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<StudentDTO>>(data);
        }

        public static StudentDTO Get(int id)
        {
            var data = StudentRepo.Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<StudentDTO>(data);
        }

        public static bool Add(StudentDTO student)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Student>(student);
            return StudentRepo.Add(data);
        }
        
    }
}
