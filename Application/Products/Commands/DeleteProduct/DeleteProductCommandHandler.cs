﻿using MediatR;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Models.Entities;

namespace Application.Products.Commands.DeleteProduct;
public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly INorthwindDbContext _context;
    public DeleteProductCommandHandler(INorthwindDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products.FindAsync(request.Id);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }

        var hasOrders = _context.OrderDetails.Any(od => od.ProductId == entity.ProductId);
        if (hasOrders)
        {
                // TODO: Add functional test for this behaviour.
            throw new DeleteFailureException(nameof(Product), request.Id, "There are existing orders associated with this product.");
        }

        _context.Products.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
