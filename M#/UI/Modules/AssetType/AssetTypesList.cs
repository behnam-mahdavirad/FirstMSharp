using MSharp;

namespace Modules
{
    class AssetTypesList : ListModule<Domain.AssetType>
    {
        public AssetTypesList()
        {
            HeaderText("Asset Types");

            Column(x => x.Name);

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<UI.Pages.AssetType.EnterPage>()
                .Send("item", "item.ID")
                .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderTemplate("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Asset Type?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("New Asset Type").Icon(FA.Plus)
                .OnClick(x => x.Go<UI.Pages.AssetType.EnterPage>()
                .SendReturnUrl());
        }
    }
}