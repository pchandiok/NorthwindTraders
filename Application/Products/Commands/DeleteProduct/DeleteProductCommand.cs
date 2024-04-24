﻿using MediatR;

namespace Application.Products.Commands.DeleteProduct;
public class DeleteProductCommand : IRequest
{
    public int Id { get; set; }
}
