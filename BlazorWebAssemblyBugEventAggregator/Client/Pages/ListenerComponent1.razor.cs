using BlazorWebAssemblyBugEventAggregator.Shared;
using EventAggregator.Blazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyBugEventAggregator.Client.Pages
{
    public class ListenerComponent1ViewModel : ComponentBase, IHandle<Message1>, IDisposable
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

        public async Task HandleAsync(Message1 message)
        {
            Console.WriteLine("ListenerComponent1 HandleAsync Message1");
            await Task.CompletedTask;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("ListenerComponent1 OnAfterRender");
            base.OnAfterRender(firstRender);
        }
    }
}
