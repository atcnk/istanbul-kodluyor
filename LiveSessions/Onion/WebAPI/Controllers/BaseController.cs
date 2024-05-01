/* surekli ayni bagimlili eklemektense base bi controller olusturduk
 * burada mediator var sadece ve protected, alt siniflar ulasabilir yani.
 * ayni zamanda ctor kaldirip RequestService yontemiyle mediatr'i ekledik
 * bu sayede alt siniflar ctor eklemeden mediator kullanabilir durumdalar.
 */

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // sen git mediatr servisi almaya calis alamazsan da exception firlat.
        protected IMediator _mediator => HttpContext.RequestServices.GetService<IMediator>() ?? throw new InvalidOperationException("Imediator can not be resolved");
    }
}
