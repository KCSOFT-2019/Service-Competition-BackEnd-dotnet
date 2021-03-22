using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RfidAPI.Data;
using RfidAPI.Models;

namespace RfidAPI.Service
{
    public class RepoServiceImpl : RepoService
    {
        public DataContext _Context;

        public RepoServiceImpl(DataContext context)
        {
            _Context = context;
        }
        public bool CreateRepo(Repo repo)
        {
            _Context.Repos.Add(repo);
            return _Context.SaveChanges() > 0;
            
        }

        public async Task<ActionResult<IEnumerable<Repo>>> getAllRepos()
        {
            return await _Context.Repos.ToListAsync();
        }
    }
}