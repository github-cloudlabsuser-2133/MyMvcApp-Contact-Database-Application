using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class UserController : Controller
{
    public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();

        // GET: User
        public ActionResult Index()
        {
            // Return the list of users to the Index view
            return View(userlist);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Find the user with the specified ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                // Return a NotFound result if the user is not found
                return NotFound();
            }

            // Return the user details to the Details view
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            // Return the Create view to display the form for creating a new user
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Add the new user to the userlist
                userlist.Add(user);

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction(nameof(Index));
            }

            // If the model state is invalid, return the Create view with the current user data
            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // Retrieve the user with the specified ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                // Return a NotFound result if the user is not found
                return NotFound();
            }

            // Return the Edit view with the user data
            return View(user);
        }

        // POST: User/Edit/5
          [HttpPost]
        public ActionResult Edit(int id, User user)
        {
             if (ModelState.IsValid)
            {
                // Find the user with the specified ID
                var existingUser = userlist.FirstOrDefault(u => u.Id == id);

                if (existingUser == null)
                {
                    // Return a NotFound result if the user is not found
                    return NotFound();
                }

                // Update the user's properties
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction(nameof(Index));
            }

            // If the model state is invalid, return the Edit view with the current user data
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Find the user with the specified ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                // Return a NotFound result if the user is not found
                return NotFound();
            }

            // Return the Delete view with the user data for confirmation
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            // Find the user with the specified ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                // Return a NotFound result if the user is not found
                return NotFound();
            }

            // Remove the user from the list
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction(nameof(Index));
        }
}
