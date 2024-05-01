/* bu sinif gelen command'i handle etmek icin var.
 * command'in icerisine de direkt yazilabiliyor, ayri da kullanilabilir.
 * IRequestHnadler ile sunu demis oluyoruz, CreateBrandCommand'i geldiginde
 * gerekli islemleri yap ve CreateBrandResponse olarak don.
 */

using Application.Repositories;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<CreateBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = _mapper.Map<Brand>(request);
            await _brandRepository.AddAsync(brand);
            // mapper entegrasyonu olmadigi icin bu sekilde gonderdik.
            return new CreateBrandResponse() { Id =brand.Id, Name = brand.Name};
        }
    }
}
