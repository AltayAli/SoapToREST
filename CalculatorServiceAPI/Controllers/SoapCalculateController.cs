using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorServiceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoapCalculateController : ControllerBase
    {
        ICalculateService calculateService;
        public SoapCalculateController(ICalculateService service)
        {
            calculateService = service;
        }
        [HttpGet("Add")]
        public async Task<ActionResult> AddAsync(int a,int b)
        {
            try
            {
                return Ok(await calculateService.AddAsync(a, b));
            }
            catch (Exception)
            {

                return BadRequest("Yanlisliq var");
            }
           
        }
        [HttpGet("Devide")]
        public async Task<ActionResult> DevideAsync(int a, int b)
        {
            try
            {
                return Ok(await calculateService.DivideAsync(a, b));
            }
            catch (Exception)
            {

                return BadRequest("Yanlisliq var");
            }
            
        }
        [HttpGet("Multiply")]
        public async Task<ActionResult> MultiplyAsync(int a, int b)
        {
            try
            {
                return Ok(await calculateService.MultiplyAsync(a, b));
            }
            catch (Exception)
            {

                return BadRequest("Yanlisliq var");
            }

        }
        [HttpGet("Subtract")]
        public async Task<ActionResult> SubtractAsync(int a, int b)
        {
            try
            {
                return Ok(await calculateService.SubtractAsync(a, b));
            }
            catch (Exception)
            {

                return BadRequest("Yanlisliq var");
            }

        }
    }
}