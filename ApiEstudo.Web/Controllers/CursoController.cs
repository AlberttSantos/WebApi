using ApiEstudo.Domain.Entities;
using ApiEstudo.Domain.Interfaces;
using ApiEstudo.Web.Model;
using ApiEstudo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ApiEstudo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : BaseController
    {
        private readonly IBaseService<Curso> _service;

        public CursoController(IBaseService<Curso> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Obter()
        {
            var cursos = await _service.Query.ToListAsync();

            if (cursos.Count == 0)
                return NotFound();

            return Ok(new ApiResult
            {
                Success = true,
                Message = "Cusos encontrados",
                Data = cursos
            });
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var result = await _service.Query.FirstOrDefaultAsync(x => x.Id == id);

            if (result == null)
                return NotFound();

            return Ok(new ApiResult
            {
                Success = true,
                Message = "Curso Encontrado",
                Data = result
            });
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(CursoViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var curso = new Curso
                {
                    Nome = model.Nome,
                    CargaHoraria = model.CargaHoraria
                };

                var result = await _service.AddAsync(curso);

                return Ok(new ApiResult
                {
                    Success = true,
                    Message = "Curso adicionado",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return Error(new ApiResult
                {
                    Success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Alterar(CursoViewModel model, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var curso = await _service.Query.FirstOrDefaultAsync(x => x.Id == id);

                if (curso == null)
                    return NotFound();

                curso.Nome = model.Nome;
                curso.CargaHoraria = model.CargaHoraria;

                var result = await _service.UpdateAsync(curso);

                return Ok(new ApiResult
                {
                    Success = true,
                    Message = "Curso alterado",
                    Data = result
                });
            }
            catch (Exception ex)
            {
                return Error(new ApiResult
                {
                    Success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            try
            {
                var curso = await _service.Query.FirstOrDefaultAsync(x => x.Id == id);

                if (curso == null)
                    return NotFound();

                await _service.DeleteAsync(curso);

                return Ok(new ApiResult
                {
                    Success = true,
                    Message = "Curso deletado"
                });
            }
            catch (Exception ex)
            {
                return Error(new ApiResult
                {
                    Success = false,
                    Message = ex.Message
                });
            }

        }
    }
}