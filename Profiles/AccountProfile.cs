using AutoMapper;
using Challenge.Dtos;
using Challenge.Models;

namespace Challenge.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            //Source - Target
            CreateMap<Account, AccountReadDto>();
            CreateMap<AccountCreateDto, Account>();
            CreateMap<AccountUpdateDto, Account>();
            CreateMap<Account, AccountUpdateDto>();
        }
    }
}