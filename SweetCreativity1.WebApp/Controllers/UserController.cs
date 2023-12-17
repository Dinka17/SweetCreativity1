using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using NuGet.Protocol.Core.Types;
using SweetCreativity1.Core.Context;
using SweetCreativity1.Core.Entities;
using SweetCreativity1.Repositories.DTOs.User;
using SweetCreativity1.Reposotories.Interfaces;
using SweetCreativity1.Reposotories.Repos;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SweetCreativity1.WebApp.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserReposotory userReposotory;

        public UserController(IUserReposotory userReposotory)
        {
            this.userReposotory = userReposotory;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await userReposotory.GetAll());
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new UserCreateDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateDto model)
        {
            if (ModelState.IsValid)
            {
                var userId = await userReposotory.Create(model);
                return RedirectToAction("Edit", new { id = userId });
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {

            var userUpdate = (await userReposotory.Get(id));
            var user = new UserUpdateDto
            {
                Email = userUpdate.Email,
                    FullName = userUpdate.FullName,
                    Id = userUpdate.Id,
                    //IsConfirmed = userUpdate.IsConfirmed,
                    Roles = await userReposotory.GetRoles()
                };
            return View(user);
        }

        /* [HttpPost]
         [AutoValidateAntiforgeryToken]
         public async Task<IActionResult> Edit(UserReadDto model, string[] roles)
         {
             if (ModelState.IsValid)
             {
                 await usersRepository.UpdateAsync(model, roles);
                 return RedirectToAction("Index");
             }
             ViewBag.Roles = await usersRepository.GetRolesAsync();
             return View(model);
         }*/
    }

    //[HttpPost]
    //public IActionResult Edit(User item)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        try
    //        {
    //            var existingItem = userReposotory.Get(item.Id);

    //            if (existingItem != null)
    //            {
    //                existingItem.UserName = item.UserName;
    //                existingItem.Email = item.Email;
    //                existingItem.Password = item.Password;
    //                existingItem.FullName = item.FullName;
    //                existingItem.PhoneNumber = item.PhoneNumber;
    //                existingItem.UrlSocialnetwork = item.UrlSocialnetwork;

    //                userReposotory.Update(existingItem);
    //                userReposotory.Save();

    //                return RedirectToAction(nameof(Index));
    //            }
    //            else
    //            {
    //                // Якщо запис не знайдено, обробіть це відповідним чином
    //                return NotFound();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            // Обробте помилку при оновленні даних, якщо вона виникла
    //            // Виведіть або збережіть повідомлення про помилку для подальшого аналізу
    //            // Ви можете також відправити користувачеві повідомлення про помилку, якщо це потрібно
    //            return View(item);
    //        }
    //    }
    //    return View(item);
    //}


}





