using System.Collections;
using System.Collections.Generic;
using BRabbitMQ.Banking.Application.Interfaces;
using BRabbitMQ.Banking.Application.Models;
using BRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BRabbitMQ.Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : Controller
    {
        //Injecting account service
        private readonly ITransferService _transferService;

        public BankingController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        
        //GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_transferService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _transferService.TransferFunds(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}