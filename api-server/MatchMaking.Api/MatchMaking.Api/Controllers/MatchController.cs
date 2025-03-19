using AutoMapper;
using MatchMaking.Api.Models;
using MatchMaking.Core.DTOs;

using MatchMaking.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MatchMaking.Core.DTOs.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MatchMaking.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        private readonly IMapper _mapper;

        public MatchController(IMatchService matchService, IMapper mapper)
        {
            _matchService = matchService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var list = _matchService.GetAll();
            var listDto = _mapper.Map<IEnumerable<MatchDto>>(list);
            return Ok(listDto);
        }

        [HttpGet("Id")]
        public ActionResult Get(int Id)
        {
            var match = _matchService.GetById(Id);
            var matchDbo = _mapper.Map<MatchDto>(match);
            return Ok(matchDbo);
        }

        [HttpGet("Date")]
        public Match Get(DateTime date)
        {
            return _matchService.GetByDate(date);
        }
        //הוספת שידוך
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MatchPostModel m)
        {
            var addMatch = new Match { MatchMakerId = m.MatchMakerId, IdF = m.IdF, Date = m.Date };

            var newMatchMaker = await _matchService.AddAsync(addMatch);
            return Ok(newMatchMaker);
        }


        //מחיקת שידוך
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _matchService.Delete(id);
        }


    }
}