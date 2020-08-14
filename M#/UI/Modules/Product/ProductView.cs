using MSharp;

namespace Modules
{
    public class ProductView : ViewModule<Domain.Product>
    {
        public ProductView()
        {
            HeaderText("Product details");

            Field(x => x.ProductName);
            Field(x => x.Category);
            Field(x => x.Supplier);

            Button("Back").Icon(FA.ChevronLeft).OnClick(x => x.CloseModal());
        }
    }
}