using AspNetMvc.Models;

namespace AspNetMvc.Services;
public class ProductService:List<ProductModel>{
    public ProductService(){
        this.AddRange(new ProductModel[]{
            new ProductModel() {Id=1, Name = "Iphone X", Price = 1200},
            new ProductModel() {Id=2, Name = "Note 10+", Price = 800},
            new ProductModel() {Id=3, Name = "S22 Ultra", Price = 1100},
            new ProductModel() {Id=4, Name = "Mi 13 Ultra", Price = 1000},
        });
    }
}