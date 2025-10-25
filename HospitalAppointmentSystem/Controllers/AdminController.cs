using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context) { _context = context; }

        public async Task<IActionResult> Dashboard()
        {
            ViewData["PatientsCount"] = await _context.Patients.CountAsync();
            ViewData["DoctorsCount"] = await _context.Doctors.CountAsync();
            ViewData["AppointmentsCount"] = await _context.Appointments.CountAsync();
            return View();
        }

        public async Task<IActionResult> Reports()
        {
            var appointments = await _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).OrderByDescending(a => a.AppointmentDate).ToListAsync();
            return View(appointments);
        }
    }
}
