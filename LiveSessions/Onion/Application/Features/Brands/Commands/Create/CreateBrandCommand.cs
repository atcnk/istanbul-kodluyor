/* brand yaratmak istedigimiz kullanilacak olan komut sinifi.
 * iletisim mediatr pattern uzerinden saglaniyor. 
 * komutun gerceklesmei icin kullanicidan istedigimiz gerekli
 * ozellikleri buraya yazabiliyoruz lakin
 * donus icin cevaba ihtiyacimiz oldugundan ayri bir dto yani
 * response sinifi yazdik ve irequest icerisine verdik.
 */

using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommand : IRequest<CreateBrandResponse>
    {
        public string Name { get; set; }
    }
}
