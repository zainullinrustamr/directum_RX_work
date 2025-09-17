using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.Request;

namespace Akelon.HelpDesk
{
  partial class RequestClientHandlers
  {

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
       
    }

    public override void Refresh(Sungero.Presentation.FormRefreshEventArgs e)
    {
      if (_obj.LifeCycle == HelpDesk.Request.LifeCycle.Closed)
      {
        foreach(var p in _obj.State.Properties)
        {
          p.IsEnabled = false;
        }
      }
    }

  }
}