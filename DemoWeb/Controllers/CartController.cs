using DemoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class CartController : Controller
{
    private static List<CartItem> cart = new List<CartItem>();

    public ActionResult Index()
    {
        return View(cart);
    }

    public ActionResult AddToCart(int id)
    {
        var product = GetProductById(id); // Lấy thông tin sản phẩm từ cơ sở dữ liệu hoặc nguồn khác
        if (product != null)
        {
            var cartItem = cart.FirstOrDefault(c => c.Product.Id == id);
            if (cartItem == null)
            {
                cart.Add(new CartItem { Product = product, Quantity = 1 });
            }
            else
            {
                cartItem.Quantity++;
            }
        }
        return RedirectToAction("Index");
    }

    private Product GetProductById(int id)
    {
        // Giả sử bạn có một phương thức để lấy thông tin sản phẩm từ cơ sở dữ liệu
        // Thay thế phương thức này bằng cách lấy dữ liệu thực tế từ cơ sở dữ liệu
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Harry Potter và hòn đá phù thủy", Price = 30000, ImageUrl = "/picture/harry1.jpg" },
            new Product { Id = 2, Name = "Harry Potter và hoàng tử lai", Price = 30000, ImageUrl = "/picture/harry2.jpg" },
            new Product { Id = 3, Name = "Harry Potter và hội phượng hoàng", Price = 30000, ImageUrl = "/picture/harry3.jpg" },
            new Product { Id = 4, Name = "Harry Potter and the Philosopher's Stone", Price = 30000, ImageUrl = "/picture/harry4.jpg" },
            new Product { Id = 5, Name = "Hãy nhớ tên anh ấy", Price = 30000, ImageUrl = "/picture/haynhotenanhay.jpg" },
            new Product { Id = 6, Name = "Sọ dừa", Price = 30000, ImageUrl = "/picture/sodua.jpg" },
            new Product { Id = 7, Name = "Hoàng tử bé", Price = 30000, ImageUrl = "/picture/hoangtube.jpg" },
            new Product { Id = 8, Name = "Nội giới và ngoại giới", Price = 30000, ImageUrl = "/picture/noigioivangoaigioi.jpg" },
            // Thêm các sản phẩm khác
        };
        return products.FirstOrDefault(p => p.Id == id);
    }
}
