using Microsoft.EntityFrameworkCore;
using WebApplication5;
using WebApplication5.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

Category category1 = new Category()
{
    Id = Guid.NewGuid(),
    Name = "�����������",
    Description = "����������� ������� � ������ �����"
};

Category category2 = new Category()
{
    Id = Guid.NewGuid(),
    Name = "������� �������",
    Description = "������� ��� ������� ����"
};

Brand brand = new Brand()
{
    Id = Guid.NewGuid(),
    Name = "SAMSUNG",
    Description = "������� ���, �� �� ��"
};


//Product newProduct = new Product
//{
//    Id = Guid.NewGuid(), // ��������� ������ ����������� �������������� ���� Guid
//    Name = "New Product",
//    Description = "A new product",
//    Price = 9.99M,
//    BrandId = brand.Id, // ��������� �������������� ���������� ������� Brand
//    Categories = new List<Category> { category1, category2 } // ��������� ��������� �������� Category
//};
using (ApplicationContext db = new ApplicationContext())
{
    db.Brands.Add(brand);
    db.Categories.AddRange(category1, category2);
    db.SaveChanges();
}

app.Run();
