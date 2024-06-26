﻿using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using Code9.Domain.Queries;
using MediatR;

namespace Code9.Domain.Handlers
{
    public class GetAllCinemaHandler : IRequestHandler<GetAllCinemasQuery, List<Cinema>>
    {
        private readonly ICinemaRepository _cinemaRepository;

        public GetAllCinemaHandler(
            ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public async Task<List<Cinema>> Handle(GetAllCinemasQuery request, CancellationToken cancellationToken)
        {
            return await _cinemaRepository.GetAllCinema();
        }
    }
}
