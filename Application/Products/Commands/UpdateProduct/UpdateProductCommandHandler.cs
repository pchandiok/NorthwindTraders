﻿using MediatR;
using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Models.Entities;

namespace Application.Products.Commands.UpdateProduct;
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly INorthwindDbContext _context;

    public UpdateProductCommandHandler(INorthwindDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products.FindAsync(request.ProductId);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Product), request.ProductId);
        }

        entity.ProductId = request.ProductId;
        entity.ProductName = request.ProductName;
        entity.CategoryId = request.CategoryId;
        entity.SupplierId = request.SupplierId;
        entity.UnitPrice = request.UnitPrice;
        entity.Discontinued = request.Discontinued;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
