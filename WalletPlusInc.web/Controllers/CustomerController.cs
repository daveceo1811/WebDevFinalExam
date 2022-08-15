using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WalletPlusInc.web.Data;
using WalletPlusInc.web.Data.Entities;
using WalletPlusInc.web.Data.Repository;
using WalletPlusInc.web.Data.Repository.Interface;



namespace WalletPlusInc.web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly Data.Repository.Interface.IRepository<Customer, Guid> _customerRepository;

        public CustomerController(Data.Repository.Interface.IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public async Task<IActionResult> Index()
        {
            var customers = await _customerRepository.Get("");

            return View(customers);
        }

        public IActionResult Create()
        {
            var model = new Customer { BirthDate = DateTime.Now};

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                await _customerRepository.Add(model);

                return RedirectToAction("Index", "Customer");
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _customerRepository.Get(id);

            return View(model);
        }

        //[ HttpPost]
        public async Task<IActionResult> Edit(Guid id, Customer model)
        {
            if (ModelState.IsValid)
            {
                await _customerRepository.Update(model);

                return RedirectToAction("Index", "Customer");
            }

            return View(model);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _customerRepository.Delete(id);

            return RedirectToAction("Index", "Customer");
        }
    }
}
