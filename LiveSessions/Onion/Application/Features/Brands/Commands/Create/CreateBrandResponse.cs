/* CreateBrandCommand komutu sonucu geriye donecegimiz cevabin sinifi.
 * markanin id'si ve ismi donsun
 */

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
