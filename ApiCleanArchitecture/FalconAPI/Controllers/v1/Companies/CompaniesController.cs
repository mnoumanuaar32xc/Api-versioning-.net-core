﻿using Microsoft.AspNetCore.Mvc;


namespace FalconAPI.Controllers.v1.Companies
{

    [Route("/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<string>> GetCompanies()
        {
            // Example list of companies
            var companies = new List<string> { "CompanyA" };
            return await Task.FromResult(companies);
        }
    }
}
