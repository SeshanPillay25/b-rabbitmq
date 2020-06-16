using System.Collections.Generic;
using BRabbitMQ.Transfer.Application.Interfaces;
using BRabbitMQ.Transfer.Application.Services;
using BRabbitMQ.Banking.Domain.Models;
using BRabbitMQ.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BRabbitMQ.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : Controller
    {
        //Injecting account service
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        
        //GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<AccountTransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}