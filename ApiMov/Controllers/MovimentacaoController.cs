using ApiMov.Controllers.Requests;
using ApiMov.Data;
using ApiMov.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMov.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimentacaoController : ControllerBase
    {
        private readonly AppDbContext _AppDbContext;
        public MovimentacaoController(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        [HttpPost]
        public IActionResult Create([FromBody] MovCreateDto CreateMovDto)
        {
            Mov CreateMov = new Mov()
            {
                TP_MOV = CreateMovDto.TP_MOV,
                DT_MOV = DateTime.UtcNow,
                VL_MOV = CreateMovDto.VL_MOV,
                DS_MOV = CreateMovDto.DS_MOV
            };

             _AppDbContext.Mov.Add(CreateMov);

            _AppDbContext.SaveChanges();

            return Ok();
        }


        [HttpPut]
        public IActionResult Update([FromBody] MovUpdateDto PutMovDto)
        {
            Mov PutMov = new Mov()
            {   
                DT_MOV = DateTime.UtcNow,
                TP_MOV = PutMovDto.TP_MOV,
                VL_MOV = PutMovDto.VL_MOV,
                DS_MOV = PutMovDto.DS_MOV
            };

            return Ok();

        }

        [HttpDelete("{ID}")]
        public IActionResult Delete(int ID) 
        { 
            return Ok(new
            {
                Message = $"Movimentação com ID {ID} excluída com sucesso"
            });
        }

        [HttpGet("{ID}")]
        public IActionResult GetById(int ID)
        {
            return Ok(new
            {
                Message = $"Movimentação com ID {ID} retornada com sucesso"
            });
        }

    }



}
