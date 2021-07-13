// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RankingApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using RankingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\_Imports.razor"
using RankingApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\Pages\Ranking.razor"
using RankingApp.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\Pages\Ranking.razor"
using RankingApp.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ranking")]
    public partial class Ranking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\vs-code\vs_workspace\Unity_Web\RankingApp\RankingApp\Pages\Ranking.razor"
       

    List<GameResult> _gameResults;

    bool _showPopup;
    GameResult _gameResult;

    protected override async Task OnInitializedAsync()
    {
        _gameResults = await RankingService.GetGameResultsAsync();
    }

    void AddGameResult()
    {
        _showPopup = true;
        _gameResult = new GameResult() { Id = 0 };
    }

    void ClosePopup()
    {
        _showPopup = false;
    }

    void UpdateGameResult(GameResult gameResult)
    {
        _showPopup = true;
        _gameResult = gameResult;
    }

    async Task DeleteGameResult(GameResult gameResult)
    {
        var result = RankingService.DeleteGameResult(gameResult);
        _gameResults = await RankingService.GetGameResultsAsync(); 
    }

    async Task SaveGameResult()
    {
        if (_gameResult.Id == 0)
        {
            _gameResult.Date = DateTime.Now;
            var result = RankingService.AddGameResult(_gameResult);
        }
        else
        {
            var result = RankingService.UpdateGameResult(_gameResult);
        }

        _gameResults = await RankingService.GetGameResultsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RankingService RankingService { get; set; }
    }
}
#pragma warning restore 1591
