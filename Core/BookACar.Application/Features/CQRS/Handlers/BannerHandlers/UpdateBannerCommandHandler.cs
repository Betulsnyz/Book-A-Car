using BookACar.Application.Features.CQRS.Commands.BannerCommands;
using BookACar.Application.Interfaces;
using BookACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var banner = await _repository.GetByIdAsync(command.BannerID);
            if (banner != null)
            {
                banner.Title = command.Title;
                banner.Description = command.Description;
                banner.VideoDescription = command.VideoDescription;
                banner.VideoUrl = command.VideoUrl;
                await _repository.UpdateAsync(banner);
            }
        }
    }
}
