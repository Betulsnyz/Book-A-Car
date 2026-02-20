
using BookACar.Application.Features.CQRS.Commands.BrandCommands;
using BookACar.Application.Features.CQRS.Handlers.BrandHandlers;
using BookACar.Application.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookACar.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandsController(GetBrandByIdQueryHandler getBrandByIdQueryHandler, GetBrandQueryHandler getBrandQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var result = await _getBrandQueryHandler.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var result = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok("Marka Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return Ok("Marka Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Marka Bilgisi Güncellendi");
        }
    }
}
