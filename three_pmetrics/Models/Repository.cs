namespace three_pmetrics.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, SourceName = "Doğalgaz", SourceIcon= "natural_gas.png" });
            _categories.Add(new Category { CategoryId = 2, SourceName = "Dizel", SourceIcon= "diesel.jpg" });
            _categories.Add(new Category { CategoryId = 3, SourceName = "Benzin", SourceIcon= "petrol.jpg" });

            _products.Add(new Product {ProductId = 1, PointName= "Kombi", PointDescription="Kombilerde tüketilen enerji", PointIcon="kombi.png",EmissionFactor= 2,EmissionFactorTitle= "ton", EmissionIsActive = true, CategoryId = 1 });
            _products.Add(new Product {ProductId = 2, PointName= "Binek araç",  PointDescription="Binek araçlarda tüketilen enerji",PointIcon="car.png",EmissionFactor= 0,EmissionFactorTitle= "litre", EmissionIsActive = false, CategoryId = 2 });
            _products.Add(new Product {ProductId = 3, PointName= "Fırın", PointDescription="Fırınlarda kullanılan enerji",PointIcon="industry.jpg",EmissionFactor= 1,EmissionFactorTitle= "litre", EmissionIsActive = true, CategoryId = 1 });
            _products.Add(new Product {ProductId = 4, PointName= "Kamyon", PointDescription="Kamyonlarda tüketilen enerji",PointIcon="truck.png",EmissionFactor=3,EmissionFactorTitle= "m3", EmissionIsActive = false, CategoryId = 3 });
            
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null) 
            {
                if(!string.IsNullOrEmpty(updatedProduct.PointName)) 
                {
                    entity.PointName = updatedProduct.PointName;
                }
                entity.EmissionFactor = updatedProduct.EmissionFactor;
                entity.PointIcon = updatedProduct.PointIcon;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.EmissionIsActive = updatedProduct.EmissionIsActive;
                entity.PointName = updatedProduct.PointName;
                entity.EmissionFactorTitle = updatedProduct.EmissionFactorTitle;
                entity.CreationDate = updatedProduct.CreationDate;
                entity.CreationTime = updatedProduct.CreationTime;
                entity.PointDescription = updatedProduct.PointDescription;

                
            }
        }

        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null) 
            {
                entity.EmissionIsActive = updatedProduct.EmissionIsActive;
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null) 
            {
                _products.Remove(entity);
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}