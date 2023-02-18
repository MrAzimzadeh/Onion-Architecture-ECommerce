using ETicaretAPI.Application.Repostories.Prodact;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        readonly private IProdactWriteRepository _prodactWriteRepository;
        readonly private IProdactReadRepository _prodactReadRepository;
        public ValuesController(IProdactWriteRepository prodactWriteRepository, IProdactReadRepository prodactReadRepository)
        {
            _prodactWriteRepository = prodactWriteRepository;
            _prodactReadRepository = prodactReadRepository;
        }
        [HttpGet]

        public async void Get()
        {
            await _prodactWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Prodact1", Price = 100, CreatedDate = DateTime.Now, Stock = 10, },
                new() { Id = Guid.NewGuid(), Name = "Prodact2", Price = 200, CreatedDate = DateTime.Now, Stock = 20, },
                new() { Id = Guid.NewGuid(), Name = "Prodact3", Price = 300, CreatedDate = DateTime.Now, Stock = 30, },
            });
            await _prodactWriteRepository.SaveAsync();
        }
    }
}
