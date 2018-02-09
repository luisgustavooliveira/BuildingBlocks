﻿using MediatR;

namespace BuildingBlocks.Mediatr.Commands
{
    public interface ICommand<out T> : IRequest<T>
    {
    }

    public interface ICommand : ICommand<bool>
    {
    }
}
