using MediatR;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Categories.Commands.DeleteCategory;

public class DeleteCategoryCommand : IRequest
{
    public int Id { get; set; }
}
