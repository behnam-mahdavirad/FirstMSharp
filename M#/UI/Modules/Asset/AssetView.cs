using MSharp;

namespace Modules
{
    public class AssetView : ViewModule<Domain.Asset>
    {
        public AssetView()
        {
            HeaderText("Asset details");

            Field(x => x.Code);
            Field(x => x.Name);
            Field(x => x.Type).LabelText("Asset Type");
            Field(x => x.Cost);
            Field(x => x.Owner).LabelText("Hold by");

            Button("Back").Icon(FA.ChevronLeft).OnClick(x => x.ReturnToPreviousPage());

        }
    }
}