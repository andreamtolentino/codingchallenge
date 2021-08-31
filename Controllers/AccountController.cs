using System.Collections.Generic;
using AutoMapper;
using Challenge.Data;
using Challenge.Dtos;
using Challenge.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _repository;
        private readonly IMapper _mapper;

        public AccountController(IAccountRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/account
        [HttpGet]
        public ActionResult<IEnumerable<AccountReadDto>> GetAllAccount()
        {
            var accountItems = _repository.GetAllAccount();

            return Ok(_mapper.Map<IEnumerable<AccountReadDto>>(accountItems));
        }

        //GET api/account/{user}
        [HttpGet("{user}", Name = "GetAccountByUser")]
        public ActionResult<AccountReadDto> GetAccountByUser(string user)
        {
            var accountItems = _repository.GetAccountByUser(user);
            if (accountItems != null)
            {
                return Ok(_mapper.Map<AccountReadDto>(accountItems));
            }
            return NotFound();
        }

        //POST api/account
        [HttpPost]
        public ActionResult<AccountReadDto> CreateAccount(AccountCreateDto accountCreateDto)
        {
            var accountModel = _mapper.Map<Account>(accountCreateDto);
            _repository.CreateAccount(accountModel);
            _repository.SaveChanges();

            var accountReadDto = _mapper.Map<AccountReadDto>(accountModel);

            return CreatedAtRoute(nameof(GetAccountByUser), new { User = accountReadDto.User }, accountReadDto);
        }

        //PUT api/account/{user}
        [HttpPut("{user}")]
        public ActionResult UpdateAccount(string user, AccountUpdateDto accountUpdateDto)
        {
            var accountModelFromRepo = _repository.GetAccountByUser(user);
            if (accountModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(accountUpdateDto, accountModelFromRepo);

            _repository.UpdateAccount(accountModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/account/{user}
        [HttpPatch("{user}")]
        public ActionResult PartialAccountUpdate(string user, JsonPatchDocument<AccountUpdateDto> patchDoc)
        {
            var accountModelFromRepo = _repository.GetAccountByUser(user);
            if (accountModelFromRepo == null)
            {
                return NotFound();
            }

            var accountToPatch = _mapper.Map<AccountUpdateDto>(accountModelFromRepo);
            patchDoc.ApplyTo(accountToPatch, ModelState);

            if (!TryValidateModel(accountToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(accountToPatch, accountModelFromRepo);

            _repository.UpdateAccount(accountModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/account/{user}
        [HttpDelete("{user}")]
        public ActionResult DeleteAccount(string user)
        {
            var accountModelFromRepo = _repository.GetAccountByUser(user);
            if (accountModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteAccount(accountModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}