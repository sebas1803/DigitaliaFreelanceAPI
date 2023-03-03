using DigitaliaFreelanceAPI.Models;
using DigitaliaFreelanceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DigitaliaFreelanceAPI.Controllers {
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase {
        private readonly IReceiptsService _receiptsService;
        public ReceiptsController(IReceiptsService receiptsService) {
            _receiptsService = receiptsService;
        }
   
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetReceiptById(int id) {
            var receipt = await _receiptsService.GetReceiptById(id);
            if (receipt == null) {
                return NotFound();
            }
            return Ok(receipt);
        }

        // POST api/<ReceiptsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<CreatedResult> CreateReceipt([FromBody] Receipt receipt) {
            var createdReceipt = await _receiptsService.CreateReceipt(receipt);
            return Created("Receipt created", createdReceipt);
        }
    }
}
