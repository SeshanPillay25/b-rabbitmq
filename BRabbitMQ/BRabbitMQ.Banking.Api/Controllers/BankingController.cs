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
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        //GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            _accountService.TransferFunds(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}