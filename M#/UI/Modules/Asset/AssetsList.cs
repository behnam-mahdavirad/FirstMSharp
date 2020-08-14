using MSharp;

namespace Modules
{
    public class AssetsList : ListModule<Domain.Asset>
    {
        public AssetsList()
        {
            HeaderText("Assets");

            Search(x => x.Type).Label("Type:");

            Search(GeneralSearch.AllFields).Label("Fine:");

            /*M#:w[14]T-Prop:Workflow-Type:ModuleButton-A button must have some workflow (redirect, previous page, close modal, etc).*/SearchButton("Search");

            ButtonColumn("View").HeaderText("View").Icon(FA.SearchPlus)
                .OnClick(x => x.Go<UI.Pages.Asset.ViewPage>().Send("item", "item.ID").SendReturnUrl());

            Column(x => x.Code);
            Column(x => x.Name);
            Column(x => x.Type).LabelText("Asset Type");
            Column(x => x.Cost);
            Column(x => x.Owner);

            ButtonColumn("Edit").HeaderText("Edit").GridColumnCssClass("actions").Icon(FA.Edit)
                .OnClick(x => x.Go<UI.Pages.Asset.EnterPage>().Send("item", "item.ID").SendReturnUrl());

            ButtonColumn("Delete").HeaderText("Delete").Icon(FA.Remove).GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Asset?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add Asset").Icon(FA.Plus)
                /*M#:w[38]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<UI.Pages.Asset.EnterPage>());
        }
    }
}
