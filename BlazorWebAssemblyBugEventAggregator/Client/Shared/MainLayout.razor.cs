using EventAggregator.Blazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyBugEventAggregator.Client.Shared
{
    public class MainLayoutViewModel : LayoutComponentBase
    {
        [Inject]
        private IEventAggregator EventAggregator { get; set; }

        protected override void OnInitialized()
        {

            base.OnInitialized();
        }
    }
}
