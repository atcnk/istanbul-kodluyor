/* bu sinif brand ile alakali http isteklerini karsiliyor.
 * api/brands yolunda erisilebilir oldugunu belirttik.
 * mediatr bagimliligini eklemedik zaten basecontroller'da var
 * body'den aldik komut olarak ve mediatr'a gonderdik.
 * o komutu handle edip bize gerekli resposne donecektir.
 */

using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateBrandCommand command)
        {
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
