using AutoMapper;
using TodoApp.Application.Features.Commands.TagCommands.CreateTag;
using TodoApp.Application.Features.Commands.TagCommands.UpdateTag;
using TodoApp.Application.Features.Commands.TodoCommands.CreateTodo;
using TodoApp.Application.Features.Commands.TodoCommands.UpdateTodo;
using TodoApp.Application.Features.Queries.TagQueries.GetAllTag;
using TodoApp.Application.Features.Queries.TagQueries.GetByIdTag;
using TodoApp.Application.Features.Queries.TodoQueries.GetAllTodo;
using TodoApp.Application.Features.Queries.TodoQueries.GetByIdTodo;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            //Tag Mapping
            CreateMap<Tag, GetAllTagQueryResponse>().ReverseMap();
            CreateMap<Tag, GetByIdTagQueryResponse>().ReverseMap();
            CreateMap<Tag, CreateTagCommand>().ReverseMap();
            CreateMap<Tag, UpdateTagCommand>().ReverseMap();

            //Todo Mapping
            CreateMap<Todo, GetAllTodoQueryResponse>().ReverseMap();
            CreateMap<Todo, GetByIdTodoQueryResponse>().ReverseMap();
            CreateMap<Todo, CreateTodoCommand>().ReverseMap();
            CreateMap<Todo, UpdateTodoCommand>().ReverseMap();


        }
    }
}
