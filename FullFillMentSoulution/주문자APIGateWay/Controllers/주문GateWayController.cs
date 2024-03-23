//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using MediatR;
//using System.Threading.Tasks;
//using 주문Common.DTO.주문대기; // DTO 네임스페이스 추가

//namespace 주문자APIGateWay.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class 주문GateWayController : ControllerBase
//    {
//        private readonly ILogger<주문GateWayController> _logger;
//        private readonly IMediator _mediator;

//        public 주문GateWayController(ILogger<주문GateWayController> logger, IMediator mediator)
//        {
//            _logger = logger;
//            _mediator = mediator;
//        }

//        [HttpPost("CreateOrder")]
//        public async Task<IActionResult> CreateOrder([FromBody] Create주문DTO orderDto)
//        {
//            _logger.LogInformation("새로운 주문 처리 시작");

//            // DTO를 Command로 매핑
//            var createOrderCommand = new CreateOrderCommand
//            {
//                OrderId = orderDto.OrderId, // 예시 매핑
//                // 다른 필드 매핑
//            };

//            // Command를 MediatR로 처리
//            var result = await _mediator.Send(createOrderCommand);

//            if (result)
//            {
//                _logger.LogInformation($"주문 {createOrderCommand.OrderId} 처리 성공");
//                return Ok();
//            }
//            else
//            {
//                _logger.LogWarning($"주문 {createOrderCommand.OrderId} 처리 실패");
//                return BadRequest();
//            }
//        }
//    }
//}
