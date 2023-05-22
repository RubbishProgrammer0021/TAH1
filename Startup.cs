using Microsoft.AspNetCore.Builder;
using TAH1.Models;
using TAH1.Data;
using TAH1.Controllers;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace TAH1
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			// 其他服务配置代码...

			services.AddDbContext<ApplicationDbContext>(options =>
			   options.UseMySql("server=localhost;port=3306;database=tah;user=root;password=patrick0307;",
			   new MySqlServerVersion(new Version(8, 0, 26))));
		}
	}
}
