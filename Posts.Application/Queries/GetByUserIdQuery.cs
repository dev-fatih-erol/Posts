﻿using System.Collections.Generic;
using MediatR;
using Posts.Infrastructure.Entities;

namespace Posts.Application.Queries
{
    public class GetByUserIdQuery : IRequest<List<Post>>
    {
        public int UserId{ get; }

        public int PageIndex { get; }

        public GetByUserIdQuery(int userId, int pageIndex)
        {
            UserId = userId;

            PageIndex = pageIndex < 1 ? 1 : pageIndex;
        }
    }
}