using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PITON.Business.Abstract;
using PITON.DataAccess;
using PITON.Entity;

namespace PITON.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ETransactionController : ControllerBase
    {
        private readonly IETransactionService eTransactionService;
        private readonly Context context;
        private readonly IConfiguration configuration;
       

        public ETransactionController(IETransactionService eTransactionService,Context context,IConfiguration configuration)
        {   
            this.eTransactionService = eTransactionService;
            this.context = context;
            this.configuration = configuration;
        }

        [HttpPost("Create")]
        public async Task<string> CreateAsync()
        {
            string url = configuration["ApiRoute:Url"];
            HttpClient httpClient = new HttpClient();
            var request = httpClient.GetAsync(url).Result;
            var response = request.Content.ReadAsStringAsync().Result;

            if (request.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ETransaction value = JsonConvert.DeserializeObject<ETransaction>(response);

                if (context.ETransactions.Any(k => k.CardNumberMasked == value.CardNumberMasked))
                {

                    return "Aynı kayıt mevcut olduğundan ekleme yapılamamıştır. ";
                }
                else
                {
                    eTransactionService.Add(value);

                    return "Kayıt başarıyla eklendi";
                }
            }
            else
            {
                return "Veri çekilemedi";
            }
        }

        [HttpGet("GetAll")]
        public IEnumerable<ETransaction> GetAll()
        {
            return eTransactionService.GetAll();
        }
    }
}
