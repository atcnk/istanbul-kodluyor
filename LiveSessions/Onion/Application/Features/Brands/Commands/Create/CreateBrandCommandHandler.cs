/* bu sinif gelen command'i handle etmek icin var.
 * command'in icerisine de direkt yazilabiliyor, ayri da kullanilabilir.
 * IRequestHnadler ile sunu demis oluyoruz, CreateBrandCommand'i geldiginde
 * gerekli islemleri yap ve CreateBrandResponse olarak don.
 */

using Application.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreateBrandResponse>
    {
        /* kullanacagim bagimliliklari DI ile entegre ediyoruz.
         * best pracitce adina private readonly ve alt cizgiyle yaziyoruz.
         */

        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreateBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new()
            {
                Name = request.Name
            };
            await _brandRepository.AddAsync(brand);
            // mapper entegrasyonu olmadigi icin bu sekilde gonderdik.
            return new CreateBrandResponse() { Id =brand.Id, Name = brand.Name};
        }
    }
}
