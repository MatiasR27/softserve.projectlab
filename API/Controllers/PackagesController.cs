using API.Abstractions;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackagesController : ControllerBase
    {
        private readonly IPackageDomainService _packageDomainService;

        public PackagesController(IPackageDomainService packageDomainService)
        {
            _packageDomainService = packageDomainService;
        }

        [HttpPost]
        public async Task<ActionResult<Package>> CreatePackage([FromBody] Package package)
        {
            var createdPackage = await _packageDomainService.CreatePackageAsync(package);
            return Ok(createdPackage);
        }
        
        [HttpPost("{packageId}/Items/{itemId}")]
        public async Task<ActionResult<Package>> AddItem([FromRoute] string packageId, [FromRoute] string itemId)
        {
            var updatedPackage = await _packageDomainService.AddItemAsync(packageId, itemId);
            return Ok(updatedPackage);
        }

        [HttpDelete("{packageId}/Items")]
        public async Task<ActionResult<Package>> DeleteItem([FromRoute] string packageId, [FromRoute] string itemId)
        {
            var updatedPackage = await _packageDomainService.DeleteItemAsync(packageId, itemId);
            return Ok(updatedPackage);
        }

        [HttpPost("{packageId}/Customers")]
        public async Task<ActionResult<Package>> AddCustomer([FromRoute] string packageId, [FromBody] Customer customer)
        {
            var updatedPackage = await _packageDomainService.AddCustomerAsync(packageId, customer);
            return Ok(updatedPackage);
        }
    }
}
