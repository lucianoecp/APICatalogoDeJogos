using Microsoft.AspNetCore.Mvc;

namespace APICatalogoDeJogos.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {

            return Ok();

        }

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idJogo)
        {

            return Ok();

        }

        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo()
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, object jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<AcceptedResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }





    }
}

