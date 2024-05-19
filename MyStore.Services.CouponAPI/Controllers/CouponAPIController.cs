using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyStore.Services.CouponAPI.Data.Repository.Interfaces;
using MyStore.Services.CouponAPI.Models.DTOs;

namespace MyStore.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController(ICouponRepository iCouponRepository, IMapper mapper) : ControllerBase
    {

        private readonly ICouponRepository _iCouponRepository = iCouponRepository;
        private readonly IMapper _mapper = mapper;

        [HttpGet]
        public async Task<IActionResult> GetCouponList()
        {
            try
            {
                var listOfCoupons = await _iCouponRepository.GetListOfCoupons();
                var returnDto = _mapper.Map<List<CouponDto>>(listOfCoupons);
                return Ok(returnDto);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouponById(int id)
        {
            try
            {
                var coupon = await _iCouponRepository.GetACouponById(id);
                var returnDto = _mapper.Map<CouponDto>(coupon);
                return Ok(returnDto);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
