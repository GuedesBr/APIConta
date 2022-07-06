using APIConta.Model;
using Microsoft.AspNetCore.Mvc;
using RestSharp;


namespace APIConta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        // GET: api/<ViaCepController>
        [HttpGet]
        public ViaCep Get()
        {
            var client = new RestClient("http://viacep.com.br");
            var request = new RestRequest("ws/:cep/json/", Method.Get);
            request.AddHeader("Accept", "text/json");
            request.AddParameter("cep", "01001000", ParameterType.UrlSegment);
 
            var queryResult = client.Execute<ViaCep>(request).Data;

            return queryResult;
        }

    }
}
