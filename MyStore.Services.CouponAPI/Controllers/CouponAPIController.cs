using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyStore.Services.CouponAPI.Data;
using MyStore.Services.CouponAPI.Models.DTOs;

namespace MyStore.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController(AppDbContext context, IMapper mapper) : ControllerBase
    {

        private readonly AppDbContext _context = context;
        private readonly IMapper _mapper = mapper;

        [HttpGet]
        public IActionResult GetCouponList()
        {
            try
            {
                var result = _context.Coupons.ToList();
                var returnDto = _mapper.Map<List<CouponDto>>(result);
                if (result != null)
                {
                    return Ok(returnDto);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCouponById(int id)
        {
            try
            {
                var result = _context.Coupons.FirstOrDefault(x => x.CouponId == id);
                var returnDto = _mapper.Map<CouponDto>(result);
                if (result != null)
                {
                    return Ok(returnDto);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
