using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
[HttpGet]
	public int Get(int uno, int dos, int tres)
	{
		return uno + dos + tres;
	}
}
