using BlazorWebAssemblyBugEventAggregator.Shared;
using EventAggregator.Blazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyBugEventAggregator.Client.Pages
{
    public class ListenerComponent2ViewModel : ComponentBase, IHandle<Message2>, IDisposable

    {
        [Inject]
        private IEventAggregator EventAggregator { get; set; }

        protected override void OnInitialized()
        {
            this.EventAggregator.Subscribe(this);
            base.OnInitialized();
        }

        public void Dispose()
        {
            this.EventAggregator.Unsubscribe(this);
        }

        public async Task HandleAsync(Message2 message)
        {
            Console.WriteLine("ListenerComponent2 HandleAsync Message2");
            await Task.CompletedTask;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("ListenerComponent2 OnAfterRender");
            base.OnAfterRender(firstRender);
        }
    }
}
