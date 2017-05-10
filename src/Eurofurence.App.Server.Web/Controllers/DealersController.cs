﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eurofurence.App.Server.Services.Abstractions;
using Eurofurence.App.Server.Web.Extensions;
using Eurofurence.App.Domain.Model.Dealers;

namespace Eurofurence.App.Server.Web.Controllers
{
    [Route("Api/v2/[controller]")]
    public class DealersController : Controller
    {
        readonly IDealerService _dealerService;

        public DealersController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }

        /// <summary>
        /// Retrieves a list of all dealer entries.
        /// </summary>
        /// <returns>All dealer Entries.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(IEnumerable<DealerRecord>), 200)]
        public Task<IEnumerable<DealerRecord>> GetDealerEntriesAsync()
        {
            return _dealerService.FindAllAsync();
        }

        /// <summary>
        /// Retrieve a single dealer.
        /// </summary>
        /// <param name="id">id of the requested entity</param>
        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(DealerRecord), 200)]
        public async Task<DealerRecord> GetDealerAsync([FromRoute] Guid id)
        {
            return (await _dealerService.FindOneAsync(id)).Transient404(HttpContext);
        }
    }
}
