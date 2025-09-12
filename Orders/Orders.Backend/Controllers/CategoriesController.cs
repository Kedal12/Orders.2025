using Microsoft.AspNetCore.Mvc;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : GenericController<Category>
{
    public CategoriesController(UnitsOfWork.Interfaces.IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
    {
    }
}