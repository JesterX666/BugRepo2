using Microsoft.VisualStudio.Extensibility.UI;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Threading;
using Extension2;
using System.Collections.ObjectModel;

namespace Extension2
{
    internal class MyToolWindowContent : RemoteUserControl
    {
        public MyToolWindowContent()
            : base(dataContext: new MyToolWindowData())
        {
            
        }
        public override async Task ControlLoadedAsync(CancellationToken cancellationToken)
        {
            await base.ControlLoadedAsync(cancellationToken);
            // Your code here            
        }
    }
}