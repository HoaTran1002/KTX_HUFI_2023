using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KTX_HUFI_2023.Models;

namespace KTX_HUFI_2023.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
}