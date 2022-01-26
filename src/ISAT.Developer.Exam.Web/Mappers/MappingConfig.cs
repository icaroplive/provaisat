using AutoMapper;
using ISAT.Developer.Exam.Core.Entities.Models;
using ISAT.Developer.Exam.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAT.Developer.Exam.Web.Mappers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingcConfig = new MapperConfiguration( config =>
            {
                config.CreateMap<Usuario, UsuarioViewModel>();
                config.CreateMap<UsuarioViewModel,Usuario>();

            }
            );
            return mappingcConfig;
        }
    }
}
