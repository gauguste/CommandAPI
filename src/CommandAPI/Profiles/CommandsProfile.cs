using AutoMapper;
using CommandAPI.Dtos;
using CommandAPI.Models;

namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target --- for Read
            CreateMap<Command, CommandReadDto>();

            // Source -> Target --- for Create
            CreateMap<CommandCreateDto, Command>();

            // Source -> Target --- for Update
            CreateMap<CommandUpdateDto, Command>();

            // Source -> Target --- for Update
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
