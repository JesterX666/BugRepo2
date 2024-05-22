using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.ToolWindows;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension2
{
    [VisualStudioContribution]
    internal class MyToolWindow : ToolWindow
    {
        private readonly MyToolWindowContent content = new();

        public MyToolWindow(VisualStudioExtensibility extensibility)
            : base(extensibility)
        {
            Title = "My Tool Window";
        }

        public override ToolWindowConfiguration ToolWindowConfiguration => new()
        {
            Placement = ToolWindowPlacement.DocumentWell,
        };

        public override async Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
            => content;

        public override Task InitializeAsync(CancellationToken cancellationToken)
            => Task.CompletedTask;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                content.Dispose();

            base.Dispose(disposing);
        }
    }
}
