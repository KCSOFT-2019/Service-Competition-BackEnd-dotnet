using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;
using RfidAPI.Service;

namespace RfidAPI.Controllers
{
    public class RepoController :ControllerBase
    {
        private readonly RepoService _repoService;

        public RepoController(RepoService repoService)
        {
            _repoService = repoService;
        }

        [HttpPost]
        [Route("api/repo/add")]
        public ActionResult<string> Create(Repo repo)
        {
            var result = _repoService.CreateRepo(repo);
            if (result)
            {
                return "repo create successfully";
            }
            else return "repo create unsuccessfully";
        }
        
    }
}