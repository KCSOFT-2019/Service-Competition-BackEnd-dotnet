using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public interface RepoService
    {
        bool CreateRepo(Repo repo);

        Task<ActionResult<IEnumerable<Repo>>> getAllRepos();
    }
}